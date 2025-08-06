using APISample.Settings;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace APISample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel13 = new System.Windows.Forms.Panel();
            epfButton = new System.Windows.Forms.Button();
            epfLiteButton = new System.Windows.Forms.Button();
            bankAccountButton = new System.Windows.Forms.Button();
            batchesButton = new System.Windows.Forms.Button();
            cancellationsButton = new System.Windows.Forms.Button();
            merchantsButton = new System.Windows.Forms.Button();
            outboundPaymentButton = new System.Windows.Forms.Button();
            paymentIntentsButton = new System.Windows.Forms.Button();
            paymentLinksButton = new System.Windows.Forms.Button();
            paymentsButton = new System.Windows.Forms.Button();
            paymentDetailsButton = new System.Windows.Forms.Button();
            refundsButton = new System.Windows.Forms.Button();
            reportsButton = new System.Windows.Forms.Button();
            tokenLinksButton = new System.Windows.Forms.Button();
            tokensButton = new System.Windows.Forms.Button();
            configurationButton = new System.Windows.Forms.Button();
            cancellationsControl1 = new CancellationsControl();
            configurationControl1 = new ConfigurationControl();
            paymentsControl1 = new PaymentsControl();
            paymentLinksControl1 = new PaymentLinksControl();
            detailsControl1 = new DetailsControl();
            epfControl2 = new EPFControl();
            epfLiteControl1 = new PFLinkControl();
            merchantsControl1 = new MerchantsControl();
            paymentIntentsControl1 = new PaymentIntentsControl();
            refundsControl1 = new RefundsControl();
            reportsControl1 = new ReportsControl();
            tokenLinksControl1 = new TokenLinksControl();
            batchesControl1 = new BatchesControl();
            bankAccountControl1 = new BankAccountControl();
            outboundPaymentControl1 = new OutboundPaymentControl();
            tokensControl1 = new TokensControl();
            panel1 = new System.Windows.Forms.Panel();
            exitButton = new System.Windows.Forms.Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(100, 25);
            toolStrip1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(epfButton);
            flowLayoutPanel1.Controls.Add(epfLiteButton);
            flowLayoutPanel1.Controls.Add(bankAccountButton);
            flowLayoutPanel1.Controls.Add(batchesButton);
            flowLayoutPanel1.Controls.Add(cancellationsButton);
            flowLayoutPanel1.Controls.Add(merchantsButton);
            flowLayoutPanel1.Controls.Add(outboundPaymentButton);
            flowLayoutPanel1.Controls.Add(paymentIntentsButton);
            flowLayoutPanel1.Controls.Add(paymentLinksButton);
            flowLayoutPanel1.Controls.Add(paymentsButton);
            flowLayoutPanel1.Controls.Add(paymentDetailsButton);
            flowLayoutPanel1.Controls.Add(refundsButton);
            flowLayoutPanel1.Controls.Add(reportsButton);
            flowLayoutPanel1.Controls.Add(tokenLinksButton);
            flowLayoutPanel1.Controls.Add(tokensButton);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(124, 701);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.SystemColors.ControlDark;
            panel13.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel13.BackgroundImage");
            panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel13.Location = new System.Drawing.Point(4, 4);
            panel13.Margin = new System.Windows.Forms.Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new System.Drawing.Size(120, 51);
            panel13.TabIndex = 2;
            // 
            // epfButton
            // 
            epfButton.Location = new System.Drawing.Point(4, 63);
            epfButton.Margin = new System.Windows.Forms.Padding(4);
            epfButton.Name = "epfButton";
            epfButton.Size = new System.Drawing.Size(117, 26);
            epfButton.TabIndex = 3;
            epfButton.Text = "EPF";
            epfButton.UseVisualStyleBackColor = true;
            epfButton.Click += epfButton_Click;
            // 
            // epfLiteButton
            // 
            epfLiteButton.Location = new System.Drawing.Point(4, 97);
            epfLiteButton.Margin = new System.Windows.Forms.Padding(4);
            epfLiteButton.Name = "epfLiteButton";
            epfLiteButton.Size = new System.Drawing.Size(117, 26);
            epfLiteButton.TabIndex = 4;
            epfLiteButton.Text = "PF Links";
            epfLiteButton.UseVisualStyleBackColor = true;
            epfLiteButton.Click += epfLiteButton_Click;
            // 
            // bankAccountButton
            // 
            bankAccountButton.Location = new System.Drawing.Point(4, 131);
            bankAccountButton.Margin = new System.Windows.Forms.Padding(4);
            bankAccountButton.Name = "bankAccountButton";
            bankAccountButton.Size = new System.Drawing.Size(117, 26);
            bankAccountButton.TabIndex = 14;
            bankAccountButton.Text = "Bank Accounts";
            bankAccountButton.UseVisualStyleBackColor = true;
            bankAccountButton.Click += bankAccountButton_Click;
            // 
            // batchesButton
            // 
            batchesButton.Location = new System.Drawing.Point(4, 165);
            batchesButton.Margin = new System.Windows.Forms.Padding(4);
            batchesButton.Name = "batchesButton";
            batchesButton.Size = new System.Drawing.Size(117, 26);
            batchesButton.TabIndex = 13;
            batchesButton.Text = "Batches";
            batchesButton.UseVisualStyleBackColor = true;
            batchesButton.Click += batchesButton_Click;
            // 
            // cancellationsButton
            // 
            cancellationsButton.Location = new System.Drawing.Point(4, 199);
            cancellationsButton.Margin = new System.Windows.Forms.Padding(4);
            cancellationsButton.Name = "cancellationsButton";
            cancellationsButton.Size = new System.Drawing.Size(117, 26);
            cancellationsButton.TabIndex = 2;
            cancellationsButton.Text = "Cancellations";
            cancellationsButton.UseVisualStyleBackColor = true;
            cancellationsButton.Click += cancellationsButton_Click;
            // 
            // merchantsButton
            // 
            merchantsButton.Location = new System.Drawing.Point(4, 233);
            merchantsButton.Margin = new System.Windows.Forms.Padding(4);
            merchantsButton.Name = "merchantsButton";
            merchantsButton.Size = new System.Drawing.Size(117, 26);
            merchantsButton.TabIndex = 5;
            merchantsButton.Text = "Merchants";
            merchantsButton.UseVisualStyleBackColor = true;
            merchantsButton.Click += merchantsButton_Click;
            // 
            // outboundPaymentButton
            // 
            outboundPaymentButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            outboundPaymentButton.Location = new System.Drawing.Point(4, 267);
            outboundPaymentButton.Margin = new System.Windows.Forms.Padding(4);
            outboundPaymentButton.Name = "outboundPaymentButton";
            outboundPaymentButton.Size = new System.Drawing.Size(117, 26);
            outboundPaymentButton.TabIndex = 15;
            outboundPaymentButton.Text = "Outbound Payments";
            outboundPaymentButton.UseVisualStyleBackColor = true;
            outboundPaymentButton.Click += outboundPaymentButton_Click;
            // 
            // paymentIntentsButton
            // 
            paymentIntentsButton.Location = new System.Drawing.Point(4, 301);
            paymentIntentsButton.Margin = new System.Windows.Forms.Padding(4);
            paymentIntentsButton.Name = "paymentIntentsButton";
            paymentIntentsButton.Size = new System.Drawing.Size(117, 26);
            paymentIntentsButton.TabIndex = 6;
            paymentIntentsButton.Text = "Payment Intents";
            paymentIntentsButton.UseVisualStyleBackColor = true;
            paymentIntentsButton.Click += paymentIntentsButton_Click;
            // 
            // paymentLinksButton
            // 
            paymentLinksButton.Location = new System.Drawing.Point(4, 335);
            paymentLinksButton.Margin = new System.Windows.Forms.Padding(4);
            paymentLinksButton.Name = "paymentLinksButton";
            paymentLinksButton.Size = new System.Drawing.Size(117, 26);
            paymentLinksButton.TabIndex = 7;
            paymentLinksButton.Text = "Payment Links";
            paymentLinksButton.UseVisualStyleBackColor = true;
            paymentLinksButton.Click += paymentLinksButton_Click;
            // 
            // paymentsButton
            // 
            paymentsButton.Location = new System.Drawing.Point(4, 369);
            paymentsButton.Margin = new System.Windows.Forms.Padding(4);
            paymentsButton.Name = "paymentsButton";
            paymentsButton.Size = new System.Drawing.Size(117, 26);
            paymentsButton.TabIndex = 8;
            paymentsButton.Text = "Payments";
            paymentsButton.UseVisualStyleBackColor = true;
            paymentsButton.Click += paymentsButton_Click;
            // 
            // paymentDetailsButton
            // 
            paymentDetailsButton.Location = new System.Drawing.Point(4, 403);
            paymentDetailsButton.Margin = new System.Windows.Forms.Padding(4);
            paymentDetailsButton.Name = "paymentDetailsButton";
            paymentDetailsButton.Size = new System.Drawing.Size(117, 26);
            paymentDetailsButton.TabIndex = 9;
            paymentDetailsButton.Text = "Payment Details";
            paymentDetailsButton.UseVisualStyleBackColor = true;
            paymentDetailsButton.Click += paymentDetailsButton_Click;
            // 
            // refundsButton
            // 
            refundsButton.Location = new System.Drawing.Point(4, 437);
            refundsButton.Margin = new System.Windows.Forms.Padding(4);
            refundsButton.Name = "refundsButton";
            refundsButton.Size = new System.Drawing.Size(117, 26);
            refundsButton.TabIndex = 10;
            refundsButton.Text = "Refunds";
            refundsButton.UseVisualStyleBackColor = true;
            refundsButton.Click += refundsButton_Click;
            // 
            // reportsButton
            // 
            reportsButton.Location = new System.Drawing.Point(4, 471);
            reportsButton.Margin = new System.Windows.Forms.Padding(4);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new System.Drawing.Size(117, 26);
            reportsButton.TabIndex = 11;
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = true;
            reportsButton.Click += reportsButton_Click;
            // 
            // tokenLinksButton
            // 
            tokenLinksButton.Location = new System.Drawing.Point(4, 505);
            tokenLinksButton.Margin = new System.Windows.Forms.Padding(4);
            tokenLinksButton.Name = "tokenLinksButton";
            tokenLinksButton.Size = new System.Drawing.Size(117, 26);
            tokenLinksButton.TabIndex = 12;
            tokenLinksButton.Text = "Token Links";
            tokenLinksButton.UseVisualStyleBackColor = true;
            tokenLinksButton.Click += tokenLinksButton_Click;
            // 
            // tokensButton
            // 
            tokensButton.Location = new System.Drawing.Point(4, 539);
            tokensButton.Margin = new System.Windows.Forms.Padding(4);
            tokensButton.Name = "tokensButton";
            tokensButton.Size = new System.Drawing.Size(117, 26);
            tokensButton.TabIndex = 16;
            tokensButton.Text = "Tokens";
            tokensButton.UseVisualStyleBackColor = true;
            tokensButton.Click += tokensButton_Click;
            // 
            // configurationButton
            // 
            configurationButton.Location = new System.Drawing.Point(12, 39);
            configurationButton.Margin = new System.Windows.Forms.Padding(12, 4, 4, 11);
            configurationButton.Name = "configurationButton";
            configurationButton.Size = new System.Drawing.Size(98, 26);
            configurationButton.TabIndex = 2;
            configurationButton.Text = "Configuration";
            configurationButton.UseVisualStyleBackColor = true;
            configurationButton.Click += configurationButton_Click;
            // 
            // cancellationsControl1
            // 
            cancellationsControl1.Location = new System.Drawing.Point(130, 10);
            cancellationsControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            cancellationsControl1.Name = "cancellationsControl1";
            cancellationsControl1.Size = new System.Drawing.Size(980, 591);
            cancellationsControl1.TabIndex = 3;
            // 
            // configurationControl1
            // 
            configurationControl1.Location = new System.Drawing.Point(130, 10);
            configurationControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            configurationControl1.Name = "configurationControl1";
            configurationControl1.Size = new System.Drawing.Size(980, 591);
            configurationControl1.TabIndex = 2;
            // 
            // paymentsControl1
            // 
            paymentsControl1.Location = new System.Drawing.Point(130, 10);
            paymentsControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            paymentsControl1.Name = "paymentsControl1";
            paymentsControl1.Size = new System.Drawing.Size(980, 591);
            paymentsControl1.TabIndex = 4;
            // 
            // paymentLinksControl1
            // 
            paymentLinksControl1.Location = new System.Drawing.Point(130, 10);
            paymentLinksControl1.Name = "paymentLinksControl1";
            paymentLinksControl1.Size = new System.Drawing.Size(980, 591);
            paymentLinksControl1.TabIndex = 5;
            // 
            // detailsControl1
            // 
            detailsControl1.Location = new System.Drawing.Point(130, 10);
            detailsControl1.Name = "detailsControl1";
            detailsControl1.Size = new System.Drawing.Size(980, 591);
            detailsControl1.TabIndex = 6;
            // 
            // epfControl2
            // 
            epfControl2.Location = new System.Drawing.Point(130, 10);
            epfControl2.Name = "epfControl2";
            epfControl2.Size = new System.Drawing.Size(980, 591);
            epfControl2.TabIndex = 8;
            // 
            // epfLiteControl1
            // 
            epfLiteControl1.Location = new System.Drawing.Point(130, 10);
            epfLiteControl1.Name = "epfLiteControl1";
            epfLiteControl1.Size = new System.Drawing.Size(980, 591);
            epfLiteControl1.TabIndex = 9;
            // 
            // merchantsControl1
            // 
            merchantsControl1.Location = new System.Drawing.Point(130, 10);
            merchantsControl1.Name = "merchantsControl1";
            merchantsControl1.Size = new System.Drawing.Size(980, 591);
            merchantsControl1.TabIndex = 10;
            // 
            // paymentIntentsControl1
            // 
            paymentIntentsControl1.Location = new System.Drawing.Point(130, 10);
            paymentIntentsControl1.Name = "paymentIntentsControl1";
            paymentIntentsControl1.Size = new System.Drawing.Size(980, 591);
            paymentIntentsControl1.TabIndex = 11;
            // 
            // refundsControl1
            // 
            refundsControl1.Location = new System.Drawing.Point(130, 10);
            refundsControl1.Name = "refundsControl1";
            refundsControl1.Size = new System.Drawing.Size(980, 591);
            refundsControl1.TabIndex = 12;
            // 
            // reportsControl1
            // 
            reportsControl1.Location = new System.Drawing.Point(130, 10);
            reportsControl1.Name = "reportsControl1";
            reportsControl1.Size = new System.Drawing.Size(980, 591);
            reportsControl1.TabIndex = 13;
            // 
            // tokenLinksControl1
            // 
            tokenLinksControl1.Location = new System.Drawing.Point(130, 10);
            tokenLinksControl1.Name = "tokenLinksControl1";
            tokenLinksControl1.Size = new System.Drawing.Size(980, 591);
            tokenLinksControl1.TabIndex = 14;
            // 
            // batchesControl1
            // 
            batchesControl1.Location = new System.Drawing.Point(130, 10);
            batchesControl1.Name = "batchesControl1";
            batchesControl1.Size = new System.Drawing.Size(980, 591);
            batchesControl1.TabIndex = 15;
            // 
            // bankAccountControl1
            // 
            bankAccountControl1.Location = new System.Drawing.Point(130, 10);
            bankAccountControl1.Name = "bankAccountControl1";
            bankAccountControl1.Size = new System.Drawing.Size(980, 591);
            bankAccountControl1.TabIndex = 16;
            // 
            // outboundPaymentControl1
            // 
            outboundPaymentControl1.Location = new System.Drawing.Point(130, 10);
            outboundPaymentControl1.Name = "outboundPaymentControl1";
            outboundPaymentControl1.Size = new System.Drawing.Size(980, 591);
            outboundPaymentControl1.TabIndex = 17;
            // 
            // tokensControl1
            // 
            tokensControl1.Location = new System.Drawing.Point(130, 10);
            tokensControl1.Name = "tokensControl1";
            tokensControl1.Size = new System.Drawing.Size(980, 591);
            tokensControl1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(configurationButton);
            panel1.Location = new System.Drawing.Point(3, 572);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(118, 117);
            panel1.TabIndex = 17;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(12, 80);
            exitButton.Margin = new System.Windows.Forms.Padding(12, 4, 4, 11);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(98, 26);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1084, 701);
            Controls.Add(tokensControl1);
            Controls.Add(outboundPaymentControl1);
            Controls.Add(bankAccountControl1);
            Controls.Add(batchesControl1);
            Controls.Add(tokenLinksControl1);
            Controls.Add(reportsControl1);
            Controls.Add(refundsControl1);
            Controls.Add(paymentIntentsControl1);
            Controls.Add(merchantsControl1);
            Controls.Add(epfLiteControl1);
            Controls.Add(epfControl2);
            Controls.Add(detailsControl1);
            Controls.Add(paymentLinksControl1);
            Controls.Add(paymentsControl1);
            Controls.Add(cancellationsControl1);
            Controls.Add(configurationControl1);
            Controls.Add(flowLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "MainForm";
            Text = "API Explorer";
            Load += MainForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button cancellationsButton;
        private System.Windows.Forms.Button epfButton;
        private System.Windows.Forms.Button epfLiteButton;
        private System.Windows.Forms.Button merchantsButton;
        private System.Windows.Forms.Button paymentIntentsButton;
        private System.Windows.Forms.Button paymentLinksButton;
        private System.Windows.Forms.Button paymentsButton;
        private System.Windows.Forms.Button paymentDetailsButton;
        private System.Windows.Forms.Button refundsButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button tokenLinksButton;
        private System.Windows.Forms.Button configurationButton;
        private ConfigurationControl configurationControl1;
        private CancellationsControl cancellationsControl1;
        private PaymentsControl paymentsControl1;
        private PaymentLinksControl paymentLinksControl1;
        private DetailsControl detailsControl1;
        private EPFControl epfControl2;
        private PFLinkControl epfLiteControl1;
        private MerchantsControl merchantsControl1;
        private PaymentIntentsControl paymentIntentsControl1;
        private RefundsControl refundsControl1;
        private ReportsControl reportsControl1;
        private TokenLinksControl tokenLinksControl1;
        private System.Windows.Forms.Button batchesButton;
        private BatchesControl batchesControl1;
        private System.Windows.Forms.Button bankAccountButton;
        private System.Windows.Forms.Button outboundPaymentButton;
        private System.Windows.Forms.Button tokensButton;
        private BankAccountControl bankAccountControl1;
        private OutboundPaymentControl outboundPaymentControl1;
        private TokensControl tokensControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
    }
}

