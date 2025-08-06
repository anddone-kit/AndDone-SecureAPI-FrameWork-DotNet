using Newtonsoft.Json.Linq;
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

namespace APISample.Requests.View
{
    public partial class PaymentLinksViewDialog : Form
    {
        public PaymentLinksViewDialog()
        {
            InitializeComponent();

            JObject data = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Requests\\SecurePaymentsLink.json"));
            paymentLinksRequestRawTextBox.Text = data.ToString();

            var root = JToken.Parse(data.ToString());
            DisplayTreeView(root, "PaymentLink");

        }

        private void PaymentLinksViewDialogCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            //paymentLinksViewCreateTree.BeginUpdate();
            //try
            //{
            //    paymentLinksViewCreateTree.Nodes.Clear();
            //    var tNode = paymentLinksViewCreateTree.Nodes[paymentLinksViewCreateTree.Nodes.Add(new TreeNode(rootName))];
            //    tNode.Tag = root;
            //    AddNode(root, tNode);

            //    //createPaymentRespJson.ExpandAll();
            //}
            //finally
            //{
            //    paymentLinksViewCreateTree.EndUpdate();
            //}
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
