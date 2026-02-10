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
    public partial class ReportsControl : UserControl
    {
        ConfigSettings _settings;
        public ReportsControl()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration Configuration = builder.Build();
            _settings = Configuration.GetSection("Settings").Get<ConfigSettings>();
        }

        private void reportsDownloadGotToFileButton_Click(object sender, EventArgs e)
        {
            using Process myProcess = new Process();
            myProcess.StartInfo.FileName = "notepad.exe";
            myProcess.StartInfo.Arguments = Application.StartupPath + "Requests\\SecureReportsDownload.json";
            myProcess.Start();
        }

        private void reportsDownloadAPIButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://docs.dev.anddone.com/explorer/#/e/secure-reports-downloads-post", UseShellExecute = true });
        }

        private void reportsDownloadClearButton_Click(object sender, EventArgs e)
        {
            reportsDownloadStatusTextBox.Text = "";
            reportsDownloadResponseText.Text = "";
        }

        private void reportsDownloadRunButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecureReportsDownload.json"));
            ReportDownloadRequest request = JsonConvert.DeserializeObject<ReportDownloadRequest>(data.ToString());

            try
            {
                ApiResponse<Object> response = ReportsAPIProcessor.Download(request, _settings);
                Console.WriteLine("API: /secure/reports/download");
                Console.WriteLine("Status Code: " + response.StatusCode);
                Console.WriteLine("Response Body: " + response.RawContent);

                reportsDownloadStatusTextBox.Text = response.StatusCode + "";
                reportsDownloadResponseText.Text = response.RawContent;
            }
            catch (ApiException ex)
            {
                reportsDownloadResponseText.Text = ex.Message;
                reportsDownloadStatusTextBox.Text = ex.ErrorCode + "";
                Console.WriteLine("Exception when calling Reports.Download: " + ex.Message);
                Console.WriteLine("Status Code: " + ex.ErrorCode);
                Console.WriteLine(ex.StackTrace);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
