using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APISample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        private void configurationButton_Click(object sender, EventArgs e)
        {
            HideAll();
            configurationControl1.Show();
        }

        private void cancellationsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            cancellationsControl1.Show();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            paymentsControl1.Show();
        }

        private void paymentLinksButton_Click(object sender, EventArgs e)
        {
            HideAll();
            paymentLinksControl1.Show();

        }

        private void paymentDetailsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            detailsControl1.Show();
        }

        private void epfButton_Click(object sender, EventArgs e)
        {
            HideAll();
            epfControl2.Show();
        }

        private void epfLiteButton_Click(object sender, EventArgs e)
        {
            HideAll();
            epfLiteControl1.Show();
        }

        private void HideAll()
        {
            cancellationsControl1.Hide();
            epfControl2.Hide();
            epfLiteControl1.Hide();
            paymentLinksControl1.Hide();
            paymentsControl1.Hide();
            detailsControl1.Hide();
            configurationControl1.Hide();
            merchantsControl1.Hide();
            paymentIntentsControl1.Hide();
            refundsControl1.Hide();
            reportsControl1.Hide();
            tokenLinksControl1.Hide();
            batchesControl1.Hide();
            outboundPaymentControl1.Hide();
            tokensControl1.Hide();
        }

        private void merchantsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            merchantsControl1.Show();
        }

        private void paymentIntentsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            paymentIntentsControl1.Show();
        }

        private void refundsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            refundsControl1.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            HideAll();
            reportsControl1.Show();
        }

        private void tokenLinksButton_Click(object sender, EventArgs e)
        {
            HideAll();
            tokenLinksControl1.Show();
        }

        private void batchesButton_Click(object sender, EventArgs e)
        {
            HideAll();
            batchesControl1.Show();
        }

        private void bankAccountButton_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void outboundPaymentButton_Click(object sender, EventArgs e)
        {
            HideAll();
            outboundPaymentControl1.Show();
        }

        private void tokensButton_Click(object sender, EventArgs e)
        {
            HideAll();
            tokensControl1.Show();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
