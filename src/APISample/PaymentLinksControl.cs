using APISample.APIProcessor;
using APISample.Requests.View;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APISample
{
    public partial class PaymentLinksControl : UserControl
    {
        ConfigSettings _settings;
        public PaymentLinksControl()
        {
            InitializeComponent();

            payLinkDetailDependLable.Text = "Dependency: Use the 'id' returned from Payment Links->Create";
            payLinkExpDependLabel.Text = "Dependency: Use the 'id' returned from Payment Links->Create";
            payLinkUpdateDependLabel.Text = "Dependency: Enter the 'id' from Payment Links->Create";
            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void paymentLinksCreateButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentLinkCreate.json"));

            PaymentLinkRequest request = JsonConvert.DeserializeObject<PaymentLinkRequest>(data.ToString());

            try
            {
                ApiResponse<PaymentLinkResponse> response = PaymentLinksAPIProcessor.Create(request, _settings);
                Console.WriteLine("API: /secure/paymentlinks");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                paymentLinksCreateStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                paymentLinksCreateResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(createPaymentLinksTree, root, "PaymentLink");
            }
            catch (ApiException ex)
            {
                paymentLinksCreateResponseTextBox.Text = ex.Message;
                paymentLinksCreateStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentLinks.Create: " + ex.Message);
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

        private void paymentLinkCreateResetButton_Click(object sender, EventArgs e)
        {
            paymentLinksCreateResponseTextBox.Text = "";
            paymentLinksCreateStatusTextBox.Text = "";
            createPaymentLinksTree.Nodes.Clear();
        }

        private void paymentLinksViewDialog_Apply(object sender, EventArgs e)
        {

        }

        private void paymentLinksCreateView_Click(object sender, EventArgs e)
        {
            PaymentLinksViewDialog dialog = new PaymentLinksViewDialog();
            dialog.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void payCreateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentLinkCreate.json";
            myProcess.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-paymentlinks-post", UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentLinkDetail.json";
            myProcess.Start();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-paymentlinks-details-post", UseShellExecute = true });
        }

        private void payLinkDetailRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentLinkDetail.json"));

            SecurePaymentLinkRequest request = JsonConvert.DeserializeObject<SecurePaymentLinkRequest>(data.ToString());

            try
            {
                ApiResponse<PaymentLinkResponse> response = PaymentLinksAPIProcessor.Details(request, _settings);
                Console.WriteLine("API: /secure/paymentlinks/details");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                payLinkDetailStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payLinkDetailsResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payLinkDetailTreeView, root, "PaymentLinksDetails");
            }
            catch (ApiException ex)
            {
                payLinkDetailsResponseTextBox.Text = ex.Message;
                payLinkDetailStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentLinks.Details: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void payLinkDetailClearButton_Click(object sender, EventArgs e)
        {
            payLinkDetailsResponseTextBox.Text = "";
            payLinkDetailStatusBox.Text = "";
            payLinkDetailTreeView.Nodes.Clear();
        }

        private void payLinkUpdateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentLinkUpdate.json";
            myProcess.Start();
        }

        private void payLinkUpdateAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-paymentlinks--id-put", UseShellExecute = true });
        }

        private void payLinkUpdateClearButton_Click(object sender, EventArgs e)
        {
            payLinkUpdateResponseTextBox.Text = "";
            payLinkUpdateStatusBox.Text = "";
            payLinkUpdateTree.Nodes.Clear();
            payLinkUpdateIdTextBox.Text = "";
        }

        private void payLinkUpdateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentLinkUpdate.json"));

            SecureUpdatePaymentLinkRequest request = JsonConvert.DeserializeObject<SecureUpdatePaymentLinkRequest>(data.ToString());

            try
            {
                ApiResponse<PaymentLinkResponse> response = PaymentLinksAPIProcessor.Update(request, 
                    payLinkUpdateIdTextBox.Text, _settings);
                Console.WriteLine("API: /secure/paymentlinks/{id}");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                payLinkUpdateStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payLinkUpdateResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payLinkUpdateTree, root, "PaymentLinksUpdate");
            }
            catch (ApiException ex)
            {
                payLinkUpdateResponseTextBox.Text = ex.Message;
                payLinkUpdateStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentLinks.Update: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void payLinkExpGotToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentLinkExpiration.json";
            myProcess.Start();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-paymentlinks-expirations-post", UseShellExecute = true });
        }

        private void payLinkExpRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentLinkExpiration.json"));

            SecurePaymentLinkRequest request = JsonConvert.DeserializeObject<SecurePaymentLinkRequest>(data.ToString());

            try
            {
                ApiResponse<PaymentLinkExpiresResponse> response = PaymentLinksAPIProcessor.Exprirations(request, _settings);
                Console.WriteLine("API: /secure/paymentlinks/expirations");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                payLinkExpStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payLinkExpResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payLinkExpTree, root, "PaymentLinksExpiration");
            }
            catch (ApiException ex)
            {
                payLinkExpResponseTextBox.Text = ex.Message;
                payLinkExpStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentLinks.Expirations: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void payLinkExpClearButton_Click(object sender, EventArgs e)
        {
            payLinkExpResponseTextBox.Text = "";
            payLinkExpStatusBox.Text = "";
        }
    }
}
