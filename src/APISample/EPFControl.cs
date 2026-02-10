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
using System.Text.RegularExpressions;
using APISample.APIProcessor;

namespace APISample
{
    public partial class EPFControl : UserControl
    {
        ConfigSettings _settings;
        string quoteLinkUrl = "";
        public EPFControl()
        {
            InitializeComponent();

            EPFQuoteLinkLabel.Text = "Note: Quote must be generated first.";
            EPFQuoteLinkLabel.Visible = false;
            EPFQuoteUrlLink.Visible = false;

            pdflLinkText.Text = "Note: Please retrive PFA first.";
            pdflLinkText.Visible = false;
            pdfButton.Visible = false;

            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void epfGenQuoteGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuotesGenerate.json";
            myProcess.Start();
        }

        private void epfGenQuoteAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quotes-generate-post", UseShellExecute = true });
        }

        private void epfGenQuoteClearButton_Click(object sender, EventArgs e)
        {
            epfGenQuoteStatusTextBox.Text = "";
            epfGenQuoteResponseTextBox.Text = "";
            epfGenQuoteTree.Nodes.Clear();
            EPFQuoteLinkLabel.Visible = false;
            EPFQuoteUrlLink.Visible = false;
        }

        private void epfGenQuoteRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuotesGenerate.json"));

            QuoteRequest request = JsonConvert.DeserializeObject<QuoteRequest>(data.ToString());

            try
            {
                ApiResponse<List<PFGenerateQuoteResponse>> response = EPFAPIProcessor.Generate(request, _settings);
                Console.WriteLine("API: /secure/epf/quotes/generate");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfGenQuoteStatusTextBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);

                quoteLinkUrl = "https://paymentwidget.uat.anddone.com/?token=" + request.PaymentIntentId;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    EPFQuoteLinkLabel.Visible = true;
                    EPFQuoteUrlLink.Visible = true;
                }

                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                epfGenQuoteResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfGenQuoteTree, root, "EPFQuote");
            }
            catch (ApiException ex)
            {
                epfGenQuoteResponseTextBox.Text = ex.Message;
                epfGenQuoteStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.GenerateQuote: " + ex.Message);
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

        private void epfGetByIntentGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuotesByIntent.json";
            myProcess.Start();
        }

        private void epfGetByIntentAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quotes-intent-post", UseShellExecute = true });
        }

        private void epfGetByIntentClearButton_Click(object sender, EventArgs e)
        {
            epfGetByIntentStatusTextBox.Text = "";
            epfGetByIntentResponseTextBox.Text = "";
            epfGetByIntentTree.Nodes.Clear();
        }

        private void epfGetByIntentRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuotesByIntent.json"));

            GetQuoteRequest request = JsonConvert.DeserializeObject<GetQuoteRequest>(data.ToString());

            try
            {
                ApiResponse<List<QuoteResponse>> response = EPFAPIProcessor.GetByIntent(request, _settings); 
                Console.WriteLine("API: /secure/epf/quotes/intent");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfGetByIntentStatusTextBox.Text = response.StatusCode + "";

                var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                epfGetByIntentResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfGetByIntentTree, root, "EPFQuote");
            }


            catch (ApiException ex)
            {
                epfGetByIntentResponseTextBox.Text = ex.Message;
                epfGetByIntentStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.GetQuoteByIntent: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void epfGetKeyGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuotesByKey.json";
            myProcess.Start();
        }

        private void epfGetKeyAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quotes-post", UseShellExecute = true });
        }

        private void epfGetKeyClearButton_Click(object sender, EventArgs e)
        {
            epfGetKeyStatusTextBox.Text = "";
            epfGetKeyResponseTextBox.Text = "";
            epfGetKeyTree.Nodes.Clear();
        }

        private void epfGetKeyRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuotesByKey.json"));

            GetQuoteKeyRequest request = JsonConvert.DeserializeObject<GetQuoteKeyRequest>(data.ToString());

            try
            {
                ApiResponse<QuoteResponse> response = EPFAPIProcessor.GetByKey(request, _settings); 
                Console.WriteLine("API: /secure/epf/quotes");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfGetKeyStatusTextBox.Text = response.StatusCode + "";

                //var jArr = Newtonsoft.Json.Linq.JArray.Parse(response.RawContent);
                //var formatted = jArr.ToString(Newtonsoft.Json.Formatting.Indented);

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                epfGetKeyResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfGetKeyTree, root, "EPFQuote");
            }
            catch (ApiException ex)
            {
                epfGetKeyResponseTextBox.Text = ex.Message;
                epfGetKeyStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.GetQuoteByKey: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void epfEndorseGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFEndorsements.json";
            myProcess.Start();
        }

        private void epfEndorseAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-endorsements-post", UseShellExecute = true });
        }

        private void epfEndorseClearButton_Click(object sender, EventArgs e)
        {
            epfEndorseStatusTextBox.Text = "";
            epfEndorseResponseTextBox.Text = "";
            epfEndorseTree.Nodes.Clear();
        }

        private void epfEndorseRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFEndorsements.json"));

            PFCheckEndorsementsRequest request = JsonConvert.DeserializeObject<PFCheckEndorsementsRequest>(data.ToString());

            try
            {
                ApiResponse<PFCheckEndorsementsResponse> response = EPFAPIProcessor.EndorsementEligibility(request, _settings); 
                Console.WriteLine("API: /secure/epf/quotes");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfEndorseStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                epfEndorseResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfGetKeyTree, root, "EPFQuote");
            }


            catch (ApiException ex)
            {
                epfEndorseResponseTextBox.Text = ex.Message;
                epfEndorseStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.GetQuoteByKey: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void epfRetrievePFAGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFRetrievePFA.json";
            myProcess.Start();
        }

        private void epfRetrievePFAAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-retrievepfa-post", UseShellExecute = true });
        }

        private void epfRetrievePFAClearButton_Click(object sender, EventArgs e)
        {
            epfRetrievePFAStatusTextBox.Text = "";
            epfRetrievePFAResponseTextBox.Text = "";
            epfRetrievePFATree.Nodes.Clear();
            pdflLinkText.Visible = false;
            pdfButton.Visible = false;
            System.IO.File.Delete("PFA\\PFA.pdf");
        }

        private void epfRetrievePFARunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFRetrievePFA.json"));

            PFRetrievePFARequestDTO request = JsonConvert.DeserializeObject<PFRetrievePFARequestDTO>(data.ToString());

            try
            {
                ApiResponse<string> response = EPFAPIProcessor.RetrievePFA(request, _settings);
                Console.WriteLine("API: /secure/epf/retrievepfa");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfRetrievePFAStatusTextBox.Text = response.StatusCode + "";

                string pdfstr = response.RawContent.Substring(1);
                string pdfstr2 = pdfstr.Remove(pdfstr.Length - 1);

                byte[] buff = Convert.FromBase64String(pdfstr2);

                bool exists = System.IO.Directory.Exists("PFA");

                if (!exists)
                    System.IO.Directory.CreateDirectory("PFA");
                System.IO.File.WriteAllBytes("PFA\\PFA.pdf", buff);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    pdflLinkText.Visible = true;
                    pdfButton.Visible = true;
                }

                epfRetrievePFAResponseTextBox.Text = response.RawContent;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfRetrievePFATree, root, "EPFPFA");
            }


            catch (ApiException ex)
            {
                epfRetrievePFAResponseTextBox.Text = ex.Message;
                epfRetrievePFAStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.GetQuoteByKey: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void EPFQuoteUrlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @quoteLinkUrl, UseShellExecute = true });
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo = new ProcessStartInfo("PFA\\PFA.pdf") { UseShellExecute = true }; myProcess.Start();
        }

        private void epfUpdateIntentGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFUpdateIntent.json";
            myProcess.Start();
        }

        private void epfUpdateIntentAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-updateintent-put", UseShellExecute = true });
        }

        private void epfUpdateIntentClearButton_Click(object sender, EventArgs e)
        {
            epfUpdateIntentStatusTextBox.Text = "";
            epfUpdateIntentResponseTextBox.Text = "";
            epfUpdateIntentTree.Nodes.Clear();
        }

        private void epfUpdateIntentRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFUpdateIntent.json"));

            PFPolicyUpdateRequestDTO request = JsonConvert.DeserializeObject<PFPolicyUpdateRequestDTO>(data.ToString());

            try
            {
                ApiResponse<PFPolicyUpdateResponse> response = EPFAPIProcessor.UpdateIntent(request, _settings);
                Console.WriteLine("API: /secure/epf/updateintent");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfUpdateIntentStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                epfUpdateIntentResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfUpdateIntentTree, root, "EPFUpdateIntent");
            }


            catch (ApiException ex)
            {
                epfUpdateIntentResponseTextBox.Text = ex.Message;
                epfUpdateIntentStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.UpdateIntent: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;

        }

        private void epfQuoteEndorseGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuoteEndorsement.json";
            myProcess.Start();
        }

        private void eofQuoteEndorseAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quote-endorsement-post", UseShellExecute = true });
        }

        private void epfQuoteEndorseClearButton_Click(object sender, EventArgs e)
        {
            epfQuoteEndorseStatusTextBox.Text = "";
            epfQuoteEndorseResponseTextBox.Text = "";
            epfQuoteEndorseTree.Nodes.Clear();
        }

        private void epfQuoteEndorseRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuoteEndorsement.json"));

            PFEndorsementRequest request = JsonConvert.DeserializeObject<PFEndorsementRequest>(data.ToString());

            try
            {
                ApiResponse<PFEndorsementResponse> response = EPFAPIProcessor.QuoteEndorsement(request, _settings);
                Console.WriteLine("API: /secure/epf/quote/endorsement");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfQuoteEndorseStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                epfQuoteEndorseResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfQuoteEndorseTree, root, "EPFQuoteEndorsement");
            }


            catch (ApiException ex)
            {
                epfQuoteEndorseResponseTextBox.Text = ex.Message;
                epfQuoteEndorseStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.QuoteEndorsement: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void epfQuoteESignGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuoteESign.json";
            myProcess.Start();
        }

        private void epfQuoteESignAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quotes-captureesign-put", UseShellExecute = true });
        }

        private void epfQuoteESignClearButton_Click(object sender, EventArgs e)
        {
            epfQuoteESignStatusTextBox.Text = "";
            epfQuoteESignResponseTextBox.Text = "";
            epfQuoteESignTree.Nodes.Clear();
        }

        private void epfQuoteESignRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuoteESign.json"));

            PFQuoteEsignRequest request = JsonConvert.DeserializeObject<PFQuoteEsignRequest>(data.ToString());

            try
            {
                ApiResponse<Object> response = EPFAPIProcessor.QuoteESign(request, _settings);
                Console.WriteLine("API: /secure/epf/quotes/captureesign");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfQuoteESignStatusTextBox.Text = response.StatusCode + "";

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    epfQuoteESignResponseTextBox.Text = "Success";
                else
                    epfQuoteESignResponseTextBox.Text = "Failed";

            }
            catch (ApiException ex)
            {
                epfQuoteESignResponseTextBox.Text = ex.Message;
                epfQuoteESignStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.QuoteESign: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void epfQuoteBookingGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuoteBooking.json";
            myProcess.Start();
        }

        private void epfQuoteBookingAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quotes-booking-put", UseShellExecute = true });
        }

        private void epfQuoteBookingClearButton_Click(object sender, EventArgs e)
        {
            epfQuoteBookingStatusTextBox.Text = "";
            epfQuoteBookingResponseTextBox.Text = "";
            epfQuoteBookingTree.Nodes.Clear();
        }

        private void epfQuoteBookingRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuoteBooking.json"));

            PFQuoteBookingRequest request = JsonConvert.DeserializeObject<PFQuoteBookingRequest>(data.ToString());

            try
            {
                ApiResponse<PFUpdatePFAResponse> response = EPFAPIProcessor.QuoteBooking(request, _settings);
                Console.WriteLine("API: /secure/epf/quotes/booking");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfQuoteBookingStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                epfQuoteBookingResponseTextBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfQuoteBookingTree, root, "EPFQuoteBooking");
            }
            catch (ApiException ex)
            {
                epfQuoteBookingResponseTextBox.Text = ex.Message;
                epfQuoteBookingStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling EPF.QuoteBooking: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }

        private void epfQuoteEndorseBookGoToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\EPFQuoteEndorseBooking.json";
            myProcess.Start();
        }

        private void epfQuoteEndorseBookingAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-epf-quote-endorsement-booking-put", UseShellExecute = true });
        }

        private void epfQuoteEndorseBookingClearButton_Click(object sender, EventArgs e)
        {
            epfQuoteEndorseBookingStatusTextBox.Text = "";
            epfQuoteEndorseBookingResponseStatusBox.Text = "";
            epfQuoteEndorseBookingTree.Nodes.Clear();
        }

        private void epfQuoteEndorseBookingRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\EPFQuoteEndorseBooking.json"));

            SecurePFQuoteBookingRequest request = JsonConvert.DeserializeObject<SecurePFQuoteBookingRequest>(data.ToString());

            try
            {
                ApiResponse<PFUpdatePFAResponse> response = EPFAPIProcessor.QuoteEndorsementBooking(request, _settings);
                Console.WriteLine("API: /secure/epf/quote/endorsement/booking");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                epfQuoteEndorseBookingStatusTextBox.Text = response.StatusCode + "";

                var jObj = Newtonsoft.Json.Linq.JObject.Parse(response.RawContent);
                var formatted = jObj.ToString(Newtonsoft.Json.Formatting.Indented);

                epfQuoteEndorseBookingResponseStatusBox.Text = formatted;

                var root = JToken.Parse(response.RawContent);
                DisplayTreeView(epfQuoteEndorseBookingTree, root, "EPFQuoteEndorseBooking");
            }
            catch (ApiException ex)
            {
                epfQuoteEndorseBookingStatusTextBox.Text = ex.ErrorCode + "";
                epfQuoteEndorseBookingResponseStatusBox.Text = ex.Message;
                Console.WriteLine("Exception when calling EPF.QuoteEndorseBooking: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
