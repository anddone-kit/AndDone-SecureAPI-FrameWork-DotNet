using APISample.Settings;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Org.OpenAPITools.Api;
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
using APISample.APIProcessor;

namespace APISample
{
    public partial class BatchesControl : UserControl
    {
        ConfigSettings _settings;
        public BatchesControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void batchGetBatchesAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-batches-post", UseShellExecute = true });
        }

        private void batchGetBatchesClearButton_Click(object sender, EventArgs e)
        {
            batchGetBatchesStatusTextBox.Text = "";
            batchGetBatchesResponseTextBox.Text = "";
            batchGetBatchesTree.Nodes.Clear();
        }

        private void batchGetBatchesRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\BatchesGetBatches.json"));
            var startRow = (int)data["StartRow"];

            try
            {
                ApiResponse<PaymentBatchResponse> response = BatchesAPIProcessor.Get(startRow, _settings);
                Console.WriteLine("API: /secure/batches");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                batchGetBatchesStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                batchGetBatchesResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(batchGetBatchesTree, root, "Batches");
            }
            catch (ApiException ex)
            {
                batchGetBatchesResponseTextBox.Text = ex.Message;
                batchGetBatchesStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Batches.Get: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void batchGetBatchesGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\BatchesGetBatches.json";
            myProcess.Start();
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

        private void BatchTranactionsCancelGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\BatchesTransactionsCancel.json";
            myProcess.Start();
        }

        private void batchesTransactionsCancelAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-batches-transactions-cancel-post", UseShellExecute = true });
        }

        private void batchTransactionCancelClearButton_Click(object sender, EventArgs e)
        {
            batchTransactionCancelStatusTextBox.Text = "";
            batchTransactionCancelResponseTextBox.Text = "";
            batchTransactionCancelTree.Nodes.Clear();
        }

        private void batchTransactionsCancelRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\BatchesTransactionsCancel.json"));

            PaymentBatchCancellationRequest request = JsonConvert.DeserializeObject<PaymentBatchCancellationRequest>(data.ToString());

            try
            {
                ApiResponse<Object> response = BatchesAPIProcessor.TransactionCancel(request, _settings);
                Console.WriteLine("API: /secure/batches/transactions/cancel");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                batchTransactionCancelStatusTextBox.Text = response.StatusCode + "";

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    batchTransactionCancelResponseTextBox.Text = "Batch Cancel Success";
                else
                {
                    var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                    var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);
                    batchTransactionCancelResponseTextBox.Text = formatted;
                }
            }
            catch (ApiException ex)
            {
                batchTransactionCancelResponseTextBox.Text = ex.Message;
                batchTransactionCancelStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Batches.TransactionsCancel: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void batchExecuteGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\BatchesExecute.json";
            myProcess.Start();
        }

        private void batchExecuteAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-batches-execute-post", UseShellExecute = true });
        }

        private void batchExecuteClearButton_Click(object sender, EventArgs e)
        {
            batchExecuteStatusTextBox.Text = "";
            batchExecuteResponseTextBox.Text = "";
            batchExecuteTree.Nodes.Clear();
        }

        private void batchExecuteRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\BatchesExecute.json"));

            SecureBatchExecuteRequest request = JsonConvert.DeserializeObject<SecureBatchExecuteRequest>(data.ToString());

            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;

            var apiInstance = new SecurePaymentBatchingApi(config);

            try
            {
                ApiResponse<Object> response = BatchesAPIProcessor.Execute(request, _settings);
                Console.WriteLine("API: /secure/batches/execute");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                batchExecuteStatusTextBox.Text = response.StatusCode + "";

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    batchExecuteResponseTextBox.Text = "Batch Execute Success";
                else
                {
                    var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                    var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);
                    batchTransactionCancelResponseTextBox.Text = formatted;
                }

            }
            catch (ApiException ex)
            {
                batchExecuteResponseTextBox.Text = ex.Message;
                batchExecuteStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Batches.Execute: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void batchTimelinesGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\BatchesTimelines.json";
            myProcess.Start();
        }

        private void batchTimelinesAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-batches-timelines-post", UseShellExecute = true });
        }

        private void batchTimelinesClearButton_Click(object sender, EventArgs e)
        {
            batchTimelinesStatusTextBox.Text = "";
            batchTimelinesResponseTextBox.Text = "";
            batchTimelinesTree.Nodes.Clear();
        }

        private void batchTimelinesRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\BatchesTimelines.json"));

            SecurePaymentBatchDetailsRequest request = JsonConvert.DeserializeObject<SecurePaymentBatchDetailsRequest>(data.ToString());

            try
            {
                ApiResponse<List<PaymentBatchEventLogResponse>> response = BatchesAPIProcessor.Timelines(request, _settings);
                Console.WriteLine("API: /secure/batches/timelines");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                batchTimelinesStatusTextBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                batchTimelinesResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(batchTimelinesTree, root, "Timelines");
            }

            catch (ApiException ex)
            {
                batchTimelinesResponseTextBox.Text = ex.Message;
                batchTimelinesStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Batches.Timelines: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void batchDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\BatchesDetails.json";
            myProcess.Start();
        }

        private void batchDetailsAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-batches-details-post", UseShellExecute = true });
        }

        private void batchDetailsClearButton_Click(object sender, EventArgs e)
        {
            batchDetailsStatusTextBox.Text = "";
            batchDetailsResponseTextBox.Text = "";
            batchDetailsTree.Nodes.Clear();
        }

        private void batchDetailsRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\BatchesDetails.json"));

            SecurePaymentBatchDetailsRequest request = JsonConvert.DeserializeObject<SecurePaymentBatchDetailsRequest>(data.ToString());

            try
            {
                ApiResponse<List<PaymentBatchDetailsResponse>> response = BatchesAPIProcessor.Details(request, _settings);
                Console.WriteLine("API: /secure/batches/details");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                batchDetailsStatusTextBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                batchDetailsResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(batchDetailsTree, root, "Details");
            }
            catch (ApiException ex)
            {
                batchDetailsResponseTextBox.Text = ex.Message;
                batchDetailsStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Batches.Details: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
