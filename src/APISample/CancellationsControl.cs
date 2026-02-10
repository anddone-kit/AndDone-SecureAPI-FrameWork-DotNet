using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;
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
    public partial class CancellationsControl : UserControl
    {
        ConfigSettings _settings;
        public CancellationsControl()
        {
            InitializeComponent();
            cancelDependLabel.Text = "Dependency: Use the 'transactionId' returned from Payments->Create";

            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void cancellationsCancelButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\CancellationsPayment.json"));
            SecureTransactionCancelRequest request = JsonConvert.DeserializeObject<SecureTransactionCancelRequest>(data.ToString());

            try
            {
                ApiResponse<SecureCancelledTransactionResponse> response = CancellationsAPIProcessor.Cancel(request, _settings);
                Console.WriteLine("API: /secure/cancellations");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);
                cancelResponseStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                cancelPaymentResultsTextBox.Text = formatted;
            }
            catch (ApiException ex)
            {
                cancelPaymentResultsTextBox.Text = ex.Message;
                cancelResponseStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Cancellations.Cancel: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void cancelResetButton_Click(object sender, EventArgs e)
        {
            cancelPaymentResultsTextBox.Text = "";
            cancelResponseStatusBox.Text = "";
        }

        private void CancellationsControl_Load(object sender, EventArgs e)
        {

        }

        private void payCreateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\CancellationsPayment.json";
            myProcess.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-cancellations-post", UseShellExecute = true });
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            cancelTreeView.BeginUpdate();
            try
            {
                cancelTreeView.Nodes.Clear();
                var tNode = cancelTreeView.Nodes[cancelTreeView.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;
                AddNode(root, tNode);

                //createPaymentRespJson.ExpandAll();
            }
            finally
            {
                cancelTreeView.EndUpdate();
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
    }
}
