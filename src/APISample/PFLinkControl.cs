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
    public partial class PFLinkControl : UserControl
    {
        ConfigSettings _settings;
        public PFLinkControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void pfLinkQuotePaymentLinkGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\PFLinkQuotePaymentLink.json";
            myProcess.Start();
        }

        private void pfLinkQuotePaymentLinkAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-epflite-quotes-paymentlinks-post", UseShellExecute = true });
        }

        private void pfLinkQuotePaymentLinkClearButton_Click(object sender, EventArgs e)
        {
            pfLinkQuotePaymentLinkStatusTextBox.Text = "";
            pfLinkQuotePaymentLinkResponseTextBox.Text = "";
            pfLinkQuotePaymentLinkTree.Nodes.Clear();
        }

        private void pfLinkQuotePaymentLinkRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\PFLinkQuotePaymentLink.json"));

            PFLitePaymentLinkRequest request = JsonConvert.DeserializeObject<PFLitePaymentLinkRequest>(data.ToString());

            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;

            var apiInstance = new SecurePremiumFinanceLiteApi(config);

            try
            {
                ApiResponse<PaymentLinkResponse> response = apiInstance.SecureEpfliteQuotesPaymentlinksPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                Console.WriteLine("API: /secure/epflite/quotes/paymentlinks");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                pfLinkQuotePaymentLinkStatusTextBox.Text = response.StatusCode + "";

                //var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                //var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                pfLinkQuotePaymentLinkResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(pfLinkQuotePaymentLinkTree, root, "QuotePaymentLink");
            }


            catch (ApiException ex)
            {
                pfLinkQuotePaymentLinkResponseTextBox.Text = ex.Message;
                pfLinkQuotePaymentLinkStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PFLink.QuotePaymentLink: " + ex.Message);
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

        private void pfLinkGenerateQuoteGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\PFLinkGenerateQuote.json";
            myProcess.Start();
        }

        private void pfLinkGenreateQuoteAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-epflite-quotes-generate-post", UseShellExecute = true });
        }

        private void pfLinkGenerateQuoteClearButton_Click(object sender, EventArgs e)
        {
            pfLinkGenerateQuoteStatusTextBox.Text = "";
            pfLinkGenerateQuoteResponseTextBox.Text = "";
            pfLinkGenerateQuoteTree.Nodes.Clear();
        }

        private void pfLinkGenerateQuoteRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\PFLinkGenerateQuote.json"));

            PFLiteSecureQuoteRequest request = JsonConvert.DeserializeObject<PFLiteSecureQuoteRequest>(data.ToString());

            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;

            var apiInstance = new SecurePremiumFinanceLiteApi(config);

            try
            {
                ApiResponse<PFLiteGenerateQuoteResponse> response = apiInstance.SecureEpfliteQuotesGeneratePostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                Console.WriteLine("API: /secure/epflite/quotes/generate");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                pfLinkGenerateQuoteStatusTextBox.Text = response.StatusCode + "";

                //var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                //var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                pfLinkGenerateQuoteResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(pfLinkGenerateQuoteTree, root, "GenerateQuote");
            }


            catch (ApiException ex)
            {
                pfLinkGenerateQuoteResponseTextBox.Text = ex.Message;
                pfLinkGenerateQuoteStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PFLink.GenerateQuote: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void pfLinkGetQuotesGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\PFLinkGetQuotes.json";
            myProcess.Start();
        }

        private void pfLinkGetQuoteAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/explorer/e/secure-epflite-quotes-link-post", UseShellExecute = true });
        }

        private void pfLinkGetQuotesClearButton_Click(object sender, EventArgs e)
        {
            pfLinkGetQuotesStatusTextBox.Text = "";
            pfLinkGetQuotesResponseTextBox.Text = "";
            pfLinkGetQuotesTree.Nodes.Clear();
        }

        private void pfLinkGetQuotesRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\PFLinkGetQuotes.json"));

            PFLiteGetQuoteRequest request = JsonConvert.DeserializeObject<PFLiteGetQuoteRequest>(data.ToString());

            Configuration config = new Configuration();
            config.BasePath = _settings.BasePath;

            var apiInstance = new SecurePremiumFinanceLiteApi(config);

            try
            {
                ApiResponse<List<PFLiteQuoteByPaymentLinkResponse>> response = apiInstance.SecureEpfliteQuotesLinkPostWithHttpInfo(
                    _settings.xApiKey, _settings.xAppKey, _settings.xVersion, _settings.Origin, request);
                Console.WriteLine("API: /secure/epflite/quotes/link");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                pfLinkGetQuotesStatusTextBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                //var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                //var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                pfLinkGetQuotesResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(pfLinkGetQuotesTree, root, "GetQuotes");
            }


            catch (ApiException ex)
            {
                pfLinkGetQuotesResponseTextBox.Text = ex.Message;
                pfLinkGetQuotesStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling PFLink.GetQuotes: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void pfLinkGenerateQuoteTab_Click(object sender, EventArgs e)
        {

        }

    }
}
