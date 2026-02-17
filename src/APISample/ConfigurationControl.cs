using AndDoneSecureClientLibrary.Api;
using APISample.Settings;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
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

namespace APISample
{
    public partial class ConfigurationControl : UserControl
    {
        private static ConfigSettings _settings;
        public ConfigurationControl()
        {
            InitializeComponent();
        }
        public ConfigurationControl(IOptions<ConfigSettings> settings)
        {
            _settings = settings.Value;
        }

        private void endPointURLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurationControl_Load(object sender, EventArgs e)
        {
            ConfigSettings2 settingsFile = JsonConvert.DeserializeObject<ConfigSettings2>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\appsettings.json"));

            configurationInstructionsLabel.Text = "To change these settings, modify the 'appsettings.json' file in the root install directory.";
            endpointURLValue.Text = _settings.BasePath;
            endpointURLValue2.Text = _settings.BasePath2;
            apiKeyValue.Text = _settings.xApiKey;
            appKeyValue.Text = _settings.xAppKey;
            apiVersionValue.Text = _settings.xVersion.ToString();
            originValue.Text = _settings.Origin;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
