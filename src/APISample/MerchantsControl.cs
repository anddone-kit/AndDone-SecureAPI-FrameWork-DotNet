using APISample.APIProcessor;
using APISample.Settings;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APISample
{
    public partial class MerchantsControl : UserControl
    {
        ConfigSettings _settings;
        public MerchantsControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void merchantUpdatePolicyGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorSearch.json";
            myProcess.Start();
        }

        private void merchantUpdatePolicyAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-search-post", UseShellExecute = true });
        }

        private void merchantUpdatePolicyClearButton_Click(object sender, EventArgs e)
        {
            merchantSearchStatusTextBox.Text = "";
            merchantSearchResponseStatusBox.Text = "";
            merchantSearchTree.Nodes.Clear();
        }

        private void merchantUpdatePolicyRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorSearch.json"));
            var vendorId = (string)data["vendorId"];

            try
            {
                ApiResponse<PageVendorResponseDTO> response = VendorAPIProcessor.Search(vendorId, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/vendors/search");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantSearchStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                merchantSearchResponseStatusBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(merchantSearchTree, root, "Search");
            }
            catch (ApiException ex)
            {
                merchantSearchResponseStatusBox.Text = ex.Message;
                merchantSearchStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Search: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void DisplayTreeView(TreeView theTree, JToken root, string rootName)
        {
            theTree.BeginUpdate();
            try
            {
                theTree.Nodes.Clear();
                var tNode = theTree.Nodes[theTree.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;
                AddNode(root, tNode);

                //createPaymentRespJson.ExpandAll();
            }
            finally
            {
                theTree.EndUpdate();
            }
        }

        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
                }
            }
            else
            {
                Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
            }
        }

        private void merchantsCreateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorCreate.json";
            myProcess.Start();
        }

        private void tokensDetailsAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-post", UseShellExecute = true });
        }

        private void merchantsCreateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorCreate.json"));

            VendorRequestDTO request = JsonConvert.DeserializeObject<VendorRequestDTO>(data.ToString());

            try
            {
                ApiResponse<SecureVendorResponseDTO> response = VendorAPIProcessor.Create(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/vendors");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsCreateStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                merchantsCreateResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(merchantsCreateTreeView, root, "Create");
            }
            catch (ApiException ex)
            {
                merchantsCreateResultsTextBox.Text = ex.Message;
                merchantsCreateStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Create: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsCraeteResetButton_Click(object sender, EventArgs e)
        {
            merchantsCreateStatusBox.Text = "";
            merchantsCreateResultsTextBox.Text = "";
            merchantsCreateTreeView.Nodes.Clear();
        }

        private void merchantsDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorDetails.json";
            myProcess.Start();
        }

        private void merchantsDetailsAPILink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-details-post", UseShellExecute = true });
        }

        private void merchantsDetailsRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorDetails.json"));

            SecureVendorRequestDTO request = JsonConvert.DeserializeObject<SecureVendorRequestDTO>(data.ToString());

            try
            {
                ApiResponse<VendorResponseDTO> response = VendorAPIProcessor.Details(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/vendors/details");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsDetailsStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                merchantsDetailsResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(merchantsDetailsTreeView, root, "Details");
            }
            catch (ApiException ex)
            {
                merchantsDetailsResultsTextBox.Text = ex.Message;
                merchantsDetailsStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Details: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsDetailsResetButton_Click(object sender, EventArgs e)
        {
            merchantsDetailsStatusBox.Text = "";
            merchantsDetailsResultsTextBox.Text = "";
            merchantsDetailsTreeView.Nodes.Clear();
        }

        private void merchantsSuspendGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorSuspend.json";
            myProcess.Start();
        }

        private void merchantsSuspendAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-suspend-post", UseShellExecute = true });
        }

        private void merchantsSuspendRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorSuspend.json"));

            SecureVendorStatusRequestDTO request = JsonConvert.DeserializeObject<SecureVendorStatusRequestDTO>(data.ToString());

            try
            {
                ApiResponse<Object> response = VendorAPIProcessor.Suspend(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/vendors/suspend");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsSuspendStatusBox.Text = response.StatusCode + "";

                if (response.RawContent.Equals(""))
                    merchantsSuspendResultsTextBox.Text = "Suspended Vendor";
                else
                    merchantsSuspendResultsTextBox.Text = "Error Suspending Vendor";

                //var root = JToken.Parse(response.RawContent);
                //DisplayTreeView(merchantsSuspendTreeView, root, "Suspend");
            }
            catch (ApiException ex)
            {
                merchantsSuspendResultsTextBox.Text = ex.Message;
                merchantsSuspendStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Suspend: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsSuspendResetButton_Click(object sender, EventArgs e)
        {
            merchantsSuspendStatusBox.Text = "";
            merchantsSuspendResultsTextBox.Text = "";
            //merchantsSuspendTreeView.Nodes.Clear();

        }

        private void merchantsUnsuspendGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorUnsuspend.json";
            myProcess.Start();
        }

        private void merchantsUnsuspendAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-unsuspend-post", UseShellExecute = true });
        }

        private void merchantsUnsuspendRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorUnsuspend.json"));

            SecureVendorStatusRequestDTO request = JsonConvert.DeserializeObject<SecureVendorStatusRequestDTO>(data.ToString());

            try
            {
                ApiResponse<Object> response = VendorAPIProcessor.Unsuspend(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/vendors/unsuspend");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsUnsuspendStatusBox.Text = response.StatusCode + "";

                if (response.RawContent.Equals(""))
                    merchantsUnsuspendResultsTextBox.Text = "UnSuspended Vendor";
                else
                    merchantsUnsuspendResultsTextBox.Text = "Error UnSuspending Vendor";

                //var root = JToken.Parse(response.RawContent);
                //DisplayTreeView(merchantsSuspendTreeView, root, "Suspend");
            }
            catch (ApiException ex)
            {
                merchantsUnsuspendResultsTextBox.Text = ex.Message;
                merchantsUnsuspendStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.UnSuspend: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsUnsuspendResetButton_Click(object sender, EventArgs e)
        {
            merchantsUnsuspendStatusBox.Text = "";
            merchantsUnsuspendResultsTextBox.Text = "";
            //merchantsUnsuspendTreeView.Nodes.Clear();
        }

        private void merchantsDeleteGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorDelete.json";
            myProcess.Start();
        }

        private void merchantsDeleteAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-delete-post", UseShellExecute = true });
        }

        private void merchantsDeleteRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorDelete.json"));

            SecureVendorStatusRequestDTO request = JsonConvert.DeserializeObject<SecureVendorStatusRequestDTO>(data.ToString());

            try
            {
                ApiResponse<Object> response = VendorAPIProcessor.Delete(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/vendors/delete");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsDeleteStatusBox.Text = response.StatusCode + "";

                if (response.RawContent.Equals(""))
                    merchantsDeleteResultsTextBox.Text = "Deleted Vendor";
                else
                    merchantsDeleteResultsTextBox.Text = "Error Deleting Vendor";

                //var root = JToken.Parse(response.RawContent);
                //DisplayTreeView(merchantsSuspendTreeView, root, "Suspend");
            }
            catch (ApiException ex)
            {
                merchantsDeleteResultsTextBox.Text = ex.Message;
                merchantsDeleteStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Delete: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsDeleteResetButton_Click(object sender, EventArgs e)
        {
            merchantsDeleteStatusBox.Text = "";
            merchantsDeleteResultsTextBox.Text = "";
        }

        private void merchantsTimelineGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorTimeline.json";
            myProcess.Start();
        }

        private void merchantsTimelineAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-timeline-post", UseShellExecute = true });
        }

        private void merchantsTimelineRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorTimeline.json"));

            SecureVendorTimelineRequestDTO request = JsonConvert.DeserializeObject<SecureVendorTimelineRequestDTO>(data.ToString());

            try
            {
                ApiResponse<List<VendorTimelineResponseListInner>> response = VendorAPIProcessor.Timeline(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/timeline");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsTimelineStatusBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                merchantsTimelineResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(merchantsTimelineTreeView, root, "Timeline");
            }
            catch (ApiException ex)
            {
                merchantsTimelineResultsTextBox.Text = ex.Message;
                merchantsTimelineStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Timeline: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsTimelineResetButton_Click(object sender, EventArgs e)
        {
            merchantsTimelineStatusBox.Text = "";
            merchantsTimelineResultsTextBox.Text = "";
            merchantsTimelineTreeView.Nodes.Clear();
        }

        private void merchantsEditGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureMerchantsVendorEdit.json";
            myProcess.Start();
        }

        private void merchantsEditAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/vendorapi-secure-merchants-vendors-edit-post", UseShellExecute = true });
        }

        private void merchantsEditRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureMerchantsVendorEdit.json"));

            SecureVendorUpdateRequestDTO request = JsonConvert.DeserializeObject<SecureVendorUpdateRequestDTO>(data.ToString());

            try
            {
                ApiResponse<SecureVendorResponseDTO> response = VendorAPIProcessor.Edit(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/merchants/edit");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                merchantsEditStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                merchantsEditResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(merchantsEditTreeView, root, "Edit");
            }
            catch (ApiException ex)
            {
                merchantsEditResultsTextBox.Text = ex.Message;
                merchantsEditStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling MerchantsVendor.Edit: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void merchantsEditResetButton_Click(object sender, EventArgs e)
        {
            merchantsEditStatusBox.Text = "";
            merchantsEditResultsTextBox.Text = "";
            merchantsEditTreeView.Nodes.Clear();
        }
    }
}
