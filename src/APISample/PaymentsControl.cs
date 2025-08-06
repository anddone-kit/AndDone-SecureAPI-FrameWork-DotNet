using APISample.APIProcessor;
using APISample.Settings;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APISample
{
    public partial class PaymentsControl : UserControl
    {
        ConfigSettings _settings;
        public PaymentsControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();

        }

        private void createPaymentButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePayments.json"));
            PaymentRequest request = JsonConvert.DeserializeObject<PaymentRequest>(data.ToString());

            try
            {
                ApiResponse<TransactionDetailResponse> response = PaymentAPIProcessor.Create(request, _settings);
                Console.WriteLine("API: /secure/payments");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);
                createPaymentStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                createPaymentResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(root, "Payment");
            }
            catch (ApiException ex)
            {
                //var jObj = Newtonsoft.Json.Linq.JObject.Parse(ex.Message);
                //var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                createPaymentResultsTextBox.Text = ex.Message;
                createPaymentStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentLinks.CreatePaymentLinks: " + ex.Message);
                Console.WriteLine("Exception when calling Payments.Create: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            payCreateTreeView.BeginUpdate();
            try
            {
                payCreateTreeView.Nodes.Clear();
                var tNode = payCreateTreeView.Nodes[payCreateTreeView.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;
                AddNode(root, tNode);

                //createPaymentRespJson.ExpandAll();
            }
            finally
            {
                payCreateTreeView.EndUpdate();
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

        private void paymentDetailsByIdButton_Click(object sender, EventArgs e)
        {

        }

        private void createPaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void createPaynentsViewButton_Click(object sender, EventArgs e)
        {

        }

        private void createPaymentResetButton_Click(object sender, EventArgs e)
        {
            createPaymentStatusBox.Text = "";
            createPaymentResultsTextBox.Text = "";
            payCreateTreeView.Nodes.Clear();
        }

        private void paymentDetailsResetButton_Click(object sender, EventArgs e)
        {
        }

        private void paymentSearchButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentsSearch.json"));
            var startRow = (int)data["StartRow"];
            var startDate = (string)data["StartDate"];
            var endDate = (string)data["EndDate"];

            try
            {

                ApiResponse<MerchantTransactionEntityResponse> response = PaymentAPIProcessor.Search(startDate, endDate,
                    startRow, _settings);
                Console.WriteLine("API: /secure/payments/search");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);
                searchPaymentStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                paymentsSearchResultsTextBox.Text = formatted;
                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(root, "Payments");
            }


            catch (ApiException ex)
            {
                var jObj = Newtonsoft.Json.Linq.JObject.Parse(ex.Message);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                paymentsSearchResultsTextBox.Text = formatted;
                searchPaymentStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Payments.Search: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void payCreateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePayments.json";
            myProcess.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-payments-post", UseShellExecute = true });
        }

        private void payDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentsSearch.json";
            myProcess.Start();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-payments-search-post", UseShellExecute = true });
        }

        private void paymentSearchResetButton_Click(object sender, EventArgs e)
        {
            searchPaymentStatusBox.Text = "";
            paymentsSearchResultsTextBox.Text = "";
            searchPayTreeView.Nodes.Clear();
        }

        private void payExportGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentsExport.json";
            myProcess.Start();
        }

        private void payExportAPILink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-payments-export-post", UseShellExecute = true });
        }

        private void payExportClearButton_Click(object sender, EventArgs e)
        {
            payExportStatusBox.Text = "";
            payExportResultsTextBox.Text = "";
            //payExportTreeView.Nodes.Clear();
        }

        private void payExportRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentsExport.json"));
            var startRow = (int)data["StartRow"];
            var startDate = (string)data["StartDate"];
            var endDate = (string)data["EndDate"];

            try
            {
                ApiResponse<Object> response = PaymentAPIProcessor.Export(startDate, endDate, startRow, _settings);
                Console.WriteLine("API: /secure/payments/export");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);
                payExportStatusBox.Text = response.StatusCode + "";
                if (response.RawContent != null && response.RawContent.Equals(""))
                {
                    payExportResultsTextBox.Text = "No data found";
                }
                else
                    payExportResultsTextBox.Text = response.RawContent;
            }
            catch (ApiException ex)
            {
                var jObj = Newtonsoft.Json.Linq.JObject.Parse(ex.Message);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payExportResultsTextBox.Text = formatted;
                payExportStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Payments.Export: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
