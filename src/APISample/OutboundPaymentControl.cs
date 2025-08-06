using APISample.APIProcessor;
using APISample.Settings;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
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
    public partial class OutboundPaymentControl : UserControl
    {
        ConfigSettings _settings;
        public OutboundPaymentControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void outboundPaymentsCancelGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureOutboundPaymentsCancel.json";
            myProcess.Start();
        }

        private void outboundPaymentsCancelAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/vendorapi-secure-outboundpayments-cancel-post", UseShellExecute = true });
        }

        private void outboundPaymentsCancelRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureOutboundPaymentsCancel.json"));

            CancelPaymentRequestDTO request = JsonConvert.DeserializeObject<CancelPaymentRequestDTO>(data.ToString());

            try
            {
                ApiResponse<Object> response = OutboundPaymentsAPIProcessor.Cancel(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/outboundpayments/cancel");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                outboundPaymentsCancelStatusBox.Text = response.StatusCode + "";

                if (response.RawContent.Equals(""))
                    outboundPaymentsCancelResultsTextBox.Text = "Payment Cancelled";
                else
                    outboundPaymentsCancelResultsTextBox.Text = "Error Cancelling Payment";
            }
            catch (ApiException ex)
            {
                outboundPaymentsCancelResultsTextBox.Text = ex.Message;
                outboundPaymentsCancelStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling OutboundPayments.Cancel: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void outboundPaymentsCancelResetButton_Click(object sender, EventArgs e)
        {
            outboundPaymentsCancelStatusBox.Text = "";
            outboundPaymentsCancelResultsTextBox.Text = "";
            outboundPaymentsCancelTreeView.Nodes.Clear();
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

        private void outboundPaymentsSearchGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureOutboundPaymentsSearch.json";
            myProcess.Start();
        }

        private void outboundPaymentsSearchAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/vendorapi-secure-outboundpayments-search-post", UseShellExecute = true });
        }

        private void outboundPaymentsSearchRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureOutboundPaymentsSearch.json"));
            var paymentId = (string)data["paymentId"];

            try
            {
                ApiResponse<PagePaymentListResponseDTO> response = OutboundPaymentsAPIProcessor.Search(paymentId, _settings);
                Console.WriteLine("API: /vendorapi/secure/outboundpayments/search");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                outboundPaymentsSearchStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                outboundPaymentsSearchResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(outboundPaymentsSearchTreeView, root, "Search");
            }
            catch (ApiException ex)
            {
                outboundPaymentsSearchResultsTextBox.Text = ex.Message;
                outboundPaymentsSearchStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling OutboundPayments.Search: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void outboundPaymentsSearchResetButton_Click(object sender, EventArgs e)
        {
            outboundPaymentsSearchStatusBox.Text = "";
            outboundPaymentsSearchResultsTextBox.Text = "";
            outboundPaymentsSearchTreeView.Nodes.Clear();
        }

        private void outboundPaymentsDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureOutboundPaymentsDetails.json";
            myProcess.Start();
        }

        private void outboundPaymentsDetailsAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/vendorapi-secure-outboundpayments-detail-post", UseShellExecute = true });
        }

        private void outboundPaymentsDetailsRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureOutboundPaymentsDetails.json"));

            PaymentRequestDetailDTO request = JsonConvert.DeserializeObject<PaymentRequestDetailDTO>(data.ToString());

            try
            {
                ApiResponse<PaymentDetailResponseDTO> response = OutboundPaymentsAPIProcessor.Details(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/outboundpayments/detail");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                outboundPaymentsDetailsStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                outboundPaymentsDetailsResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(outboundPaymentsDetailsTreeView, root, "Details");
            }
            catch (ApiException ex)
            {
                outboundPaymentsDetailsResultsTextBox.Text = ex.Message;
                outboundPaymentsDetailsStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling OutboundPayments.Details: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void outboundPaymentsDetailsResetButton_Click(object sender, EventArgs e)
        {
            outboundPaymentsDetailsStatusBox.Text = "";
            outboundPaymentsDetailsResultsTextBox.Text = "";
            outboundPaymentsDetailsTreeView.Nodes.Clear();
        }

        private void outboundPaymentsCreateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureOutboundPaymentsCreate.json";
            myProcess.Start();
        }

        private void outboundPaymentsCreateAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/vendorapi-secure-outboundpayments-post", UseShellExecute = true });
        }

        private void outboundPaymentsCreateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureOutboundPaymentsCreate.json"));

            PaymentRequestDto request = JsonConvert.DeserializeObject<PaymentRequestDto>(data.ToString());

            try
            {
                ApiResponse<PaymentResponseDto> response = OutboundPaymentsAPIProcessor.Create(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/outboundpayments");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                outboundPaymentsCreateStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                outboundPaymentsCreateResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(outboundPaymentsCreateTreeView, root, "Create");
            }
            catch (ApiException ex)
            {
                outboundPaymentsCreateResultsTextBox.Text = ex.Message;
                outboundPaymentsCreateStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling OutboundPayments.Create: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void outboundPaymentsCreateResetButton_Click(object sender, EventArgs e)
        {
            outboundPaymentsCreateStatusBox.Text = "";
            outboundPaymentsCreateResultsTextBox.Text = "";
            outboundPaymentsCreateTreeView.Nodes.Clear();
        }

        private void outboundPaymentsTimelinesGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureOutboundPaymentsTimelines.json";
            myProcess.Start();
        }

        private void outboundPaymentsTimelinesAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/vendorapi-secure-outboundPayments-timelines-post", UseShellExecute = true });
        }

        private void outboundPaymentsTimelinesRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureOutboundPaymentsTimelines.json"));

            PaymentTimeLineRequestDto request = JsonConvert.DeserializeObject<PaymentTimeLineRequestDto>(data.ToString());

            try
            {
                ApiResponse<List<OutboundPaymentTimelineResponseDTOInner>> response = OutboundPaymentsAPIProcessor.Timelines(request, _settings);
                Console.WriteLine("API: /vendorapi/secure/outboundpayments/timelines");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                outboundPaymentsTimelinesStatusBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                outboundPaymentsTimelinesResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(outboundPaymentsTimelineTreeView, root, "Timeline");
            }
            catch (ApiException ex)
            {
                outboundPaymentsTimelinesResultsTextBox.Text = ex.Message;
                outboundPaymentsTimelinesStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling OutboundPayments.Timelines: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void outboundPaymentsTimelinesResetButton_Click(object sender, EventArgs e)
        {
            outboundPaymentsTimelinesStatusBox.Text = "";
            outboundPaymentsTimelinesResultsTextBox.Text = "";
            outboundPaymentsTimelineTreeView.Nodes.Clear();
        }
    }
}
