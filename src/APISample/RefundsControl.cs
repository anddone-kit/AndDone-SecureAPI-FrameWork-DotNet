using APISample.APIProcessor;
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

namespace APISample
{
    public partial class RefundsControl : UserControl
    {
        public RefundsControl()
        {
            InitializeComponent();
        }

        private void refundEligibleGotToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureRefundsEligibility.json";
            myProcess.Start();
        }

        private void refundEligibleAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-refunds-eligibility-post", UseShellExecute = true });
        }

        private void refundEligibleRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureRefundsEligibility.json"));
            TransactionRefundEligibilityRequest request = JsonConvert.DeserializeObject<TransactionRefundEligibilityRequest>(data.ToString());

            try
            {
                ApiResponse<RefundEligibility> response = RefundsAPIProcessor.Eligibility(request);
                Console.WriteLine("API: /secure/refunds/eligibility");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                refundEligibleStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                refundEligibleResponseText.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(refundEligibleTree, root, "RefundEligibility");
            }
            catch (ApiException ex)
            {
                refundEligibleResponseText.Text = ex.Message;
                refundEligibleStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Refunds.Eligibility: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void refundEligibleClearButton_Click(object sender, EventArgs e)
        {
            refundEligibleStatusTextBox.Text = "";
            refundEligibleResponseText.Text = "";
            refundEligibleTree.Nodes.Clear();
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

        private void refundRequestGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureRefundRequest.json";
            myProcess.Start();
        }

        private void refundRequestAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-refunds-post", UseShellExecute = true });
        }

        private void refundRequestClearButton_Click(object sender, EventArgs e)
        {
            refundRequestStatusTextBox.Text = "";
            refundRequestResponseTextBox.Text = "";
            refundRequestTree.Nodes.Clear();
        }

        private void refundRequestRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureRefundRequest.json"));
            SecureTransactionRefundRequest request = JsonConvert.DeserializeObject<SecureTransactionRefundRequest>(data.ToString());

            try
            {
                ApiResponse<SecureTransactionDetailDTO> response = RefundsAPIProcessor.Request(request);
                Console.WriteLine("API: /secure/refunds");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                refundRequestStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                refundRequestResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(refundRequestTree, root, "RefundRequest");
            }
            catch (ApiException ex)
            {
                refundRequestResponseTextBox.Text = ex.Message;
                refundRequestStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Refunds.Request: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
