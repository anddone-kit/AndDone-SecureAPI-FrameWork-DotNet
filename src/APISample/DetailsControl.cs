using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APISample.Settings;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using APISample.APIProcessor;

namespace APISample
{
    public partial class DetailsControl : UserControl
    {
        ConfigSettings _settings;
        public DetailsControl()
        {
            InitializeComponent();

            detailsByIdDependLabel.Text = "Dependency: Use the 'transactionId' returned from Payments->Create";
            payDetailTokenDepLabel.Text = "Dependency: Use the 'paymentToken' returned from Payment Intents->Create";
            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void paymentDetailsByIdButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentsDetailsById.json"));
            SecurePaymentDetailsRequest request = JsonConvert.DeserializeObject<SecurePaymentDetailsRequest>(data.ToString());

            try
            {
                ApiResponse<TransactionPaymentResponse> response = PaymentDetailsAPIProcessor.ById(request, _settings);
                Console.WriteLine("API: /secure/paymentsdetails - Id");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);
                detailsByIdStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                detailsByIdResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payDetailTreeView, root, "Payment Details");
            }
            catch (ApiException ex)
            {
                detailsByIdResultsTextBox.Text = ex.Message;
                detailsByIdStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentDetails.ById: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void paymentDetailsResetButton_Click(object sender, EventArgs e)
        {
            detailsByIdResultsTextBox.Text = "";
            detailsByIdStatusBox.Text = "";
            payDetailTreeView.Nodes.Clear();
        }

        private void payDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentsDetailsById.json";
            myProcess.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-paymentsdetails-post", UseShellExecute = true });
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void payDetailTreeView_DoubleClick(object sender, TreeViewEventArgs e)
        {
            Clipboard.SetText(payDetailTreeView.SelectedNode.Text);
        }
        private void payDetailTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void payDetailsTokenGotToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentsDetailsByToken.json";
            myProcess.Start();
        }

        private void payDetailTokenAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-paymentsdetails-post", UseShellExecute = true });
        }

        private void payDetailTokenClearButton_Click(object sender, EventArgs e)
        {
            payDetailTokenStatusTextBox.Text = "";
            payDetailTokenResponseText.Text = "";
            payDetailTokenTree.Nodes.Clear();
        }

        private void payDetailTokenRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentsDetailsByToken.json"));
            SecurePaymentDetailsRequest request = JsonConvert.DeserializeObject<SecurePaymentDetailsRequest>(data.ToString());

            try
            {
                ApiResponse<TransactionPaymentResponse> response = PaymentDetailsAPIProcessor.ByToken(request, _settings);
                Console.WriteLine("API: /secure/paymentsdetails - Token");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);
                payDetailTokenStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payDetailTokenResponseText.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payDetailTokenTree, root, "Payment Details");
            }
            catch (ApiException ex)
            {
                payDetailTokenResponseText.Text = ex.Message;
                payDetailTokenStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Details.ByToken: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
