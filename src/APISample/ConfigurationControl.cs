using APISample.Settings;
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
        public ConfigurationControl()
        {
            InitializeComponent();
        }

        private void endPointURLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigurationControl_Load(object sender, EventArgs e)
        {
            //ConfigSettings2 settingsFile = JsonConvert.DeserializeObject<ConfigSettings2>(File.ReadAllText(@"appsettings.json"));
            ConfigSettings2 settingsFile = JsonConvert.DeserializeObject<ConfigSettings2>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\appsettings.json"));

            //using (StreamReader file = File.OpenText((Directory.GetCurrentDirectory()) + "\\appsettings.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    ConfigSettings2 movie2 = (ConfigSettings2)serializer.Deserialize(file, typeof(ConfigSettings2));
            //}

            configurationInstructionsLabel.Text = "To change these settings, modify the 'appsettings.json' file in the root install directory.";
            endpointURLValue.Text = settingsFile.Settings.BasePath;
            endpointURLValue2.Text = settingsFile.Settings.BasePath2;
            apiKeyValue.Text = settingsFile.Settings.xApiKey;
            appKeyValue.Text = settingsFile.Settings.xAppKey;
            apiVersionValue.Text = settingsFile.Settings.xVersion.ToString();
            originValue.Text = settingsFile.Settings.Origin;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
