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
    public partial class TokensControl : UserControl
    {
        ConfigSettings _settings;
        public TokensControl()
        {
            InitializeComponent();

            label9.Text = "Dependency: Use the 'tokenLinkId' returned from Token Links->Create. Token must be processed";
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void tokensDeactivateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokensDeactivate.json";
            myProcess.Start();
        }

        private void tokensDeactivateAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokens-activations-delete", UseShellExecute = true });
        }

        private void tokensDeactivateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureTokensDeactivate.json"));
            TokenRequest request = JsonConvert.DeserializeObject<TokenRequest>(data.ToString());

            try
            {
                ApiResponse<Object> response = TokensAPIProcessor.Deaactivate(request, _settings);
                Console.WriteLine("API: /secure/tokens/activations");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokensDeactivateStatusBox.Text = response.StatusCode + "";

                if (response.RawContent.Equals(""))
                    tokensDeactivateResultsTextBox.Text = "Token Deactivated";
                else
                    tokensDeactivateResultsTextBox.Text = "Error Deactivating Token";
            }
            catch (ApiException ex)
            {
                tokensDeactivateResultsTextBox.Text = ex.Message;
                tokensDeactivateStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Tokens.Deactivate: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void tokensDeactivateResetButton_Click(object sender, EventArgs e)
        {
            tokensDeactivateStatusBox.Text = "";
            tokensDeactivateResultsTextBox.Text = "";
            tokensDeactivateTreeView.Nodes.Clear();
        }

        private void tokensDetailsGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokensDetails.json";
            myProcess.Start();
        }

        private void tokensDetailsAPILabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokens-details-post", UseShellExecute = true });
        }

        private void tokensDetailsRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureTokensDetails.json"));

            SecureTokenLinkRequest request = JsonConvert.DeserializeObject<SecureTokenLinkRequest>(data.ToString());

            try
            {
                ApiResponse<SecureTokenLinkByIdResponse> response = TokenLinksAPIProcessor.Details(request, _settings);
                Console.WriteLine("API: /secure/tokenlinks/details");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokensDetailsStatusBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                tokensDetailsResultsTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(tokensDetailsTreeView, root, "Details");
            }
            catch (ApiException ex)
            {
                tokensDetailsResultsTextBox.Text = ex.Message;
                tokensDetailsStatusBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling TokenLinks.Detail: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void tokensDetailsResetButton_Click(object sender, EventArgs e)
        {
            tokensDetailsStatusBox.Text = "";
            tokensDetailsResultsTextBox.Text = "";
            tokensDetailsTreeView.Nodes.Clear();
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
    }
}
