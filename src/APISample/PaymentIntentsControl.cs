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
    public partial class PaymentIntentsControl : UserControl
    {
        ConfigSettings _settings;
        public PaymentIntentsControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void payIntentCreateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecurePaymentIntentsCreate.json";
            myProcess.Start();
        }

        private void payIntentCreateAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-paymentintents-post", UseShellExecute = true });
        }

        private void payIntentCreateClearButton_Click(object sender, EventArgs e)
        {
            payIntentCreateResponseTextBox.Text = "";
            payIntentCreateStatusBox.Text = "";
            payIntentCreateTree.Nodes.Clear();
        }

        private void payIntentCreateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentIntentsCreate.json"));

            PaymentIntentRequest request = JsonConvert.DeserializeObject<PaymentIntentRequest>(data.ToString());

            try
            {
                ApiResponse<PaymentIntentResponse> response = PaymentIntentsAPIProcessor.Create(request, _settings);
                Console.WriteLine("API: /secure/paymentintents");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                payIntentCreateStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payIntentCreateResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payIntentCreateTree, root, "PaymentIntentCreate");
            }
            catch (ApiException ex)
            {
                payIntentCreateResponseTextBox.Text = ex.Message;
                payIntentCreateStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentIntents.Create: " + ex.Message);
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

        private void payIntentExpAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-paymentintents-expirations-post", UseShellExecute = true });
        }

        private void payIntentExpClearButton_Click(object sender, EventArgs e)
        {
            payIntentExpResponseText.Text = "";
            payIntentExpStatusTextBox.Text = "";
            payIntentExpTree.Nodes.Clear();
            payIntentExpTokenTextBox.Text = "";
        }

        private void payIntentExpRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                ApiResponse<PaymentIntentExpiresResponse> response = PaymentIntentsAPIProcessor.Expiration(
                    payIntentExpTokenTextBox.Text, _settings);
                Console.WriteLine("API: /secure/paymentintents/expirations?id={paymentToken}");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                payIntentExpStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                payIntentExpResponseText.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(payIntentExpTree, root, "PaymentIntentExpiration");
            }


            catch (ApiException ex)
            {
                payIntentExpResponseText.Text = ex.Message;
                payIntentExpStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PaymentIntents.Expirations: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

    }
}
