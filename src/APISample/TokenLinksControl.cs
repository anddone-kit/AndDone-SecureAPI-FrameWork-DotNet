using APISample.Settings;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
using APISample.APIProcessor;

namespace APISample
{
    public partial class TokenLinksControl : UserControl
    {
        string tokenLinkCreateUrl = "";
        public TokenLinksControl()
        {
            InitializeComponent();

            tokenLinkDetailDependLable.Text = "Dependency: Use the 'tokenLinkId' returned from Token Links->Create. Token must be processed";
            tokenLinkUpdateDependLabel.Text = "Dependency: Use the 'tokenLinkId' returned from Token Links->Create";
            tokenLinkExpireDependLabel.Text = "Dependency: Use the 'tokenLinkId' returned from Token Links->Create. Token cannot be proceessed.";
            tokenLinkCreateDependLabel.Text = "Note: Click to process link before viewing details.";

            tokenLinkCreateDependLabel.Visible = false;
            tokenLinkCreateUrlLink.Visible = false;
        }

        private void tokenLinkCreateGotToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokenLinkCreate.json";
            myProcess.Start();
        }

        private void tokenLinkCreateAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokenlinks-post", UseShellExecute = true });
        }

        private void tokenLinkCreateClearButton_Click(object sender, EventArgs e)
        {
            tokenLinkCreateResponseTextBox.Text = "";
            tokenLinkCreateStatusTextBox.Text = "";
            tokenLinkCreateTree.Nodes.Clear();
            tokenLinkCreateDependLabel.Visible = false;
            tokenLinkCreateUrlLink.Visible = false;
        }

        private void tokenLinkCreateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureTokenLinkCreate.json"));

            TokenLinkSecureRequest request = JsonConvert.DeserializeObject<TokenLinkSecureRequest>(data.ToString());

            try
            {
                ApiResponse<SecureTokenLinkResponse> response = TokenLinksAPIProcessor.Create(request);
                Console.WriteLine("API: /secure/tokenlinks");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokenLinkCreateStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                string url = (string)jObj["url"];
                tokenLinkCreateUrl = url;

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    tokenLinkCreateDependLabel.Visible = true;
                    tokenLinkCreateUrlLink.Visible = true;
                }

                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                tokenLinkCreateResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(tokenLinkCreateTree, root, "TokenLink");
            }
            catch (ApiException ex)
            {
                tokenLinkCreateResponseTextBox.Text = ex.Message;
                tokenLinkCreateStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling TokenLinks.Create: " + ex.Message);
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

        private void tokenLinkDetailGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokenLinkDetail.json";
            myProcess.Start();
        }

        private void tokenLinkDetailAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokenlinks-details-post", UseShellExecute = true });
        }

        private void tokenLinkClearButton_Click(object sender, EventArgs e)
        {
            tokenLinkDetailResponseTextBox.Text = "";
            tokenLinkDetailResponseStatusTextBox.Text = "";
            tokenLinkDetailTree.Nodes.Clear();
        }

        private void tokenLinkRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureTokenLinkDetail.json"));

            SecureTokenLinkRequest request = JsonConvert.DeserializeObject<SecureTokenLinkRequest>(data.ToString());

            try
            {
                ApiResponse<SecureTokenLinkByIdResponse> response = TokenLinksAPIProcessor.Details(request);
                Console.WriteLine("API: /secure/tokenlinks/details");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokenLinkDetailResponseStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                tokenLinkDetailResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(tokenLinkDetailTree, root, "TokenLinkDetail");
            }
            catch (ApiException ex)
            {
                tokenLinkDetailResponseTextBox.Text = ex.Message;
                tokenLinkDetailResponseStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling TokenLinks.Detail: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void tokenLinkCreateUrlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @tokenLinkCreateUrl, UseShellExecute = true });
        }

        private void tokenLinkUpdateGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokenLinkUpdate.json";
            myProcess.Start();
        }

        private void tokenLinkUpdateApiButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokenlinks-put", UseShellExecute = true });
        }

        private void tokenLinkUpdateClearButton_Click(object sender, EventArgs e)
        {
            tokenLinkUpdateResponseTextBox.Text = "";
            tokenLinkUpdateStatusResponseTextBox.Text = "";
            tokenLinkUpdateTree.Nodes.Clear();
        }

        private void tokenLinkUpdateRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureTokenLinkUpdate.json"));

            SecureTokenLinkUpdateRequest request = JsonConvert.DeserializeObject<SecureTokenLinkUpdateRequest>(data.ToString());

            try
            {
                ApiResponse<Object> response = TokenLinksAPIProcessor.Update(request);
                Console.WriteLine("API: /secure/tokenlinks");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokenLinkUpdateStatusResponseTextBox.Text = response.StatusCode + "";

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    tokenLinkUpdateResponseTextBox.Text = "Token Link Updated";
                else
                {
                    var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                    var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);
                    tokenLinkUpdateResponseTextBox.Text = formatted;
                }

                //var root = JToken.Parse(response.RawContent);
                //DisplayTreeView(tokenLinkUpdateTree, root, "TokenLinkUpdate");
            }
            catch (ApiException ex)
            {
                tokenLinkUpdateResponseTextBox.Text = ex.Message;
                tokenLinkUpdateStatusResponseTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling TokenLinks.Update: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void tokenLinkExpireGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokenLinkExpire.json";
            myProcess.Start();
        }

        private void tokenLinkExpireApiButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokenlinks-expirations-post", UseShellExecute = true });
        }

        private void tokenLinkExpireClearButton_Click(object sender, EventArgs e)
        {
            tokenLinkExpireResponseTextBox.Text = "";
            tokenLinkExpireResponseStatusTextBox.Text = "";
            tokenLinkExpireTree.Nodes.Clear();
        }

        private void tokenLinkExpireRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureTokenLinkExpire.json"));

            SecureTokenLinkRequest request = JsonConvert.DeserializeObject<SecureTokenLinkRequest>(data.ToString());

            try
            {
                ApiResponse<SecureTokenLinkExpiredResponse> response = TokenLinksAPIProcessor.Expire(request);
                Console.WriteLine("API: /secure/tokenlinks/expirations");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokenLinkExpireResponseStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                tokenLinkExpireResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(tokenLinkExpireTree, root, "TokenLinkExpire");
            }
            catch (ApiException ex)
            {
                tokenLinkExpireResponseTextBox.Text = ex.Message;
                tokenLinkExpireResponseStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling TokenLinks.Expire: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void tokenLinkDeleteGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureTokenLinkList.json";
            myProcess.Start();
        }

        private void tokenLinkDeleteAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-tokenlinks-list-post", UseShellExecute = true });
        }

        private void tokenLinkListClearButton_Click(object sender, EventArgs e)
        {
            tokenLinkListResponseTextBox.Text = "";
            tokenLinkListResponseStatusTextBox.Text = "";
            tokenLinkListTree.Nodes.Clear();
        }

        private void tokenLinkListRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                ApiResponse<TokenLinkResponse> response = TokenLinksAPIProcessor.List();
                Console.WriteLine("API: /secure/tokenlinks/list");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                tokenLinkListResponseStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                tokenLinkListResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(tokenLinkListTree, root, "TokenLinkList");
            }
            catch (ApiException ex)
            {
                tokenLinkListResponseTextBox.Text = ex.Message;
                tokenLinkListResponseStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling TokenLinks.List: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
