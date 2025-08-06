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
    public partial class BankAccountControl : UserControl
    {
        ConfigSettings _settings;
        public BankAccountControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void bankAccountDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureBankAccountsDetails.json";
            myProcess.Start();
        }

        private void bankAccountAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-bankaccounts-details-post", UseShellExecute = true });
        }

        private void bankAccountsDetailsRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureBankAccountsDetails.json"));
            VerificationEntityRequest request = JsonConvert.DeserializeObject<VerificationEntityRequest>(data.ToString());

            try
            {
                ApiResponse<VerifyBankAccountResponse> response = BankAccountsAPIProcessor.Details(request, _settings);
                Console.WriteLine("API: /secure/bankaccounts/details");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                bankAccountsDetailsStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                bankAccountsDetailsResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(bankAccountsDetailsTreeView, root, "Details");
            }
            catch (ApiException ex)
            {
                bankAccountsDetailsResultsTextBox.Text = ex.Message;
                bankAccountsDetailsStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling BankAccounts.Details: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void bankAccountsDetailsResetButton_Click(object sender, EventArgs e)
        {
            bankAccountsDetailsStatusBox.Text = "";
            bankAccountsDetailsResultsTextBox.Text = "";
            bankAccountsDetailsTreeView.Nodes.Clear();
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

        private void bankAccountsVerifyGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureBankAccountsVerify.json";
            myProcess.Start();
        }

        private void bankAccountsVerifyAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-bankaccounts-verify-post", UseShellExecute = true });
        }

        private void bankAccountsVerifyRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureBankAccountsVerify.json"));
            VerifyBankAccountRequest request = JsonConvert.DeserializeObject<VerifyBankAccountRequest>(data.ToString());
            var accountHolderName = (string)data["accountHolderName"];
            var accountNumber = (string)data["accountNumber"];
            var routingNumber = (string)data["routingNumber"];

            try
            {
                ApiResponse<VerifyBankAccountResponse> response = BankAccountsAPIProcessor.Verify(request, _settings);
                Console.WriteLine("API: /secure/bankaccounts/verify");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                bankAccountsVerifyStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                bankAccountsVerifyResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(bankAccountsVerifyTreeView, root, "Verify");
            }
            catch (ApiException ex)
            {
                bankAccountsVerifyResponseTextBox.Text = ex.Message;
                bankAccountsVerifyStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling BankAccounts.Verify: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void bankAccountsVerifyResetButton_Click(object sender, EventArgs e)
        {
            bankAccountsVerifyStatusBox.Text = "";
            bankAccountsVerifyResponseTextBox.Text = "";
            bankAccountsVerifyTreeView.Nodes.Clear();
        }
    }
}
