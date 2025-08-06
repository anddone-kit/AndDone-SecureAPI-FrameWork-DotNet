namespace APISample
{
    partial class PaymentsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new System.Windows.Forms.Label();
            createPaymentButton = new System.Windows.Forms.Button();
            createPaymentResultsTextBox = new System.Windows.Forms.TextBox();
            paymentsTabControl = new System.Windows.Forms.TabControl();
            paymentsCreateTab = new System.Windows.Forms.TabPage();
            payCreateTreeView = new System.Windows.Forms.TreeView();
            label1 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            payCreateGoToFileButton = new System.Windows.Forms.Button();
            createPaymentResetButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            createPaymentStatusBox = new System.Windows.Forms.TextBox();
            createPaymentRespLabel = new System.Windows.Forms.Label();
            createPaymentLabel = new System.Windows.Forms.Label();
            paymentsSearchTab = new System.Windows.Forms.TabPage();
            searchPayTreeView = new System.Windows.Forms.TreeView();
            label3 = new System.Windows.Forms.Label();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            paySearchGoToFileButton = new System.Windows.Forms.Button();
            paymentsSearchResultsTextBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            searchPaymentStatusBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            paymentSearchResetButton = new System.Windows.Forms.Button();
            paymentSearchButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            paymentsExportTab = new System.Windows.Forms.TabPage();
            payExportResultsTextBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            payExportStatusBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            payExportClearButton = new System.Windows.Forms.Button();
            payExportRunButton = new System.Windows.Forms.Button();
            payExportAPILink = new System.Windows.Forms.LinkLabel();
            payExportGoToFileButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            paymentsTabControl.SuspendLayout();
            paymentsCreateTab.SuspendLayout();
            paymentsSearchTab.SuspendLayout();
            paymentsExportTab.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(110, 26);
            label5.TabIndex = 11;
            label5.Text = "Payments";
            // 
            // createPaymentButton
            // 
            createPaymentButton.Location = new System.Drawing.Point(15, 90);
            createPaymentButton.Margin = new System.Windows.Forms.Padding(4);
            createPaymentButton.Name = "createPaymentButton";
            createPaymentButton.Size = new System.Drawing.Size(94, 26);
            createPaymentButton.TabIndex = 12;
            createPaymentButton.Text = "Run";
            createPaymentButton.UseVisualStyleBackColor = true;
            createPaymentButton.Click += createPaymentButton_Click;
            // 
            // createPaymentResultsTextBox
            // 
            createPaymentResultsTextBox.Location = new System.Drawing.Point(15, 220);
            createPaymentResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            createPaymentResultsTextBox.Multiline = true;
            createPaymentResultsTextBox.Name = "createPaymentResultsTextBox";
            createPaymentResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            createPaymentResultsTextBox.Size = new System.Drawing.Size(340, 220);
            createPaymentResultsTextBox.TabIndex = 13;
            // 
            // paymentsTabControl
            // 
            paymentsTabControl.Controls.Add(paymentsCreateTab);
            paymentsTabControl.Controls.Add(paymentsSearchTab);
            paymentsTabControl.Controls.Add(paymentsExportTab);
            paymentsTabControl.Location = new System.Drawing.Point(100, 100);
            paymentsTabControl.Name = "paymentsTabControl";
            paymentsTabControl.SelectedIndex = 0;
            paymentsTabControl.Size = new System.Drawing.Size(750, 540);
            paymentsTabControl.TabIndex = 19;
            // 
            // paymentsCreateTab
            // 
            paymentsCreateTab.Controls.Add(payCreateTreeView);
            paymentsCreateTab.Controls.Add(label1);
            paymentsCreateTab.Controls.Add(linkLabel1);
            paymentsCreateTab.Controls.Add(payCreateGoToFileButton);
            paymentsCreateTab.Controls.Add(createPaymentResetButton);
            paymentsCreateTab.Controls.Add(label2);
            paymentsCreateTab.Controls.Add(createPaymentStatusBox);
            paymentsCreateTab.Controls.Add(createPaymentRespLabel);
            paymentsCreateTab.Controls.Add(createPaymentLabel);
            paymentsCreateTab.Controls.Add(createPaymentResultsTextBox);
            paymentsCreateTab.Controls.Add(createPaymentButton);
            paymentsCreateTab.Location = new System.Drawing.Point(4, 24);
            paymentsCreateTab.Name = "paymentsCreateTab";
            paymentsCreateTab.Padding = new System.Windows.Forms.Padding(3);
            paymentsCreateTab.Size = new System.Drawing.Size(742, 512);
            paymentsCreateTab.TabIndex = 0;
            paymentsCreateTab.Text = "Create";
            paymentsCreateTab.UseVisualStyleBackColor = true;
            // 
            // payCreateTreeView
            // 
            payCreateTreeView.Location = new System.Drawing.Point(405, 220);
            payCreateTreeView.Name = "payCreateTreeView";
            payCreateTreeView.Size = new System.Drawing.Size(315, 220);
            payCreateTreeView.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(400, 190);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 19);
            label1.TabIndex = 34;
            label1.Text = "Tree View";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel1.Location = new System.Drawing.Point(630, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(89, 19);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "API Endpoint";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // payCreateGoToFileButton
            // 
            payCreateGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payCreateGoToFileButton.Name = "payCreateGoToFileButton";
            payCreateGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payCreateGoToFileButton.TabIndex = 32;
            payCreateGoToFileButton.Text = "Go to File";
            payCreateGoToFileButton.UseVisualStyleBackColor = true;
            payCreateGoToFileButton.Click += payCreateGoToFileButton_Click;
            // 
            // createPaymentResetButton
            // 
            createPaymentResetButton.Location = new System.Drawing.Point(120, 90);
            createPaymentResetButton.Margin = new System.Windows.Forms.Padding(4);
            createPaymentResetButton.Name = "createPaymentResetButton";
            createPaymentResetButton.Size = new System.Drawing.Size(94, 26);
            createPaymentResetButton.TabIndex = 21;
            createPaymentResetButton.Text = "Clear";
            createPaymentResetButton.UseVisualStyleBackColor = true;
            createPaymentResetButton.Click += createPaymentResetButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 19);
            label2.TabIndex = 20;
            label2.Text = "Raw JSON";
            // 
            // createPaymentStatusBox
            // 
            createPaymentStatusBox.Enabled = false;
            createPaymentStatusBox.Location = new System.Drawing.Point(125, 160);
            createPaymentStatusBox.Name = "createPaymentStatusBox";
            createPaymentStatusBox.Size = new System.Drawing.Size(75, 23);
            createPaymentStatusBox.TabIndex = 19;
            // 
            // createPaymentRespLabel
            // 
            createPaymentRespLabel.AutoSize = true;
            createPaymentRespLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            createPaymentRespLabel.Location = new System.Drawing.Point(15, 160);
            createPaymentRespLabel.Name = "createPaymentRespLabel";
            createPaymentRespLabel.Size = new System.Drawing.Size(103, 19);
            createPaymentRespLabel.TabIndex = 18;
            createPaymentRespLabel.Text = "Response Code";
            // 
            // createPaymentLabel
            // 
            createPaymentLabel.AutoSize = true;
            createPaymentLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            createPaymentLabel.Location = new System.Drawing.Point(15, 20);
            createPaymentLabel.Name = "createPaymentLabel";
            createPaymentLabel.Size = new System.Drawing.Size(274, 19);
            createPaymentLabel.TabIndex = 17;
            createPaymentLabel.Text = "Payload File:  Requests\\SecurePayment.json";
            // 
            // paymentsSearchTab
            // 
            paymentsSearchTab.Controls.Add(searchPayTreeView);
            paymentsSearchTab.Controls.Add(label3);
            paymentsSearchTab.Controls.Add(linkLabel2);
            paymentsSearchTab.Controls.Add(paySearchGoToFileButton);
            paymentsSearchTab.Controls.Add(paymentsSearchResultsTextBox);
            paymentsSearchTab.Controls.Add(label8);
            paymentsSearchTab.Controls.Add(searchPaymentStatusBox);
            paymentsSearchTab.Controls.Add(label7);
            paymentsSearchTab.Controls.Add(paymentSearchResetButton);
            paymentsSearchTab.Controls.Add(paymentSearchButton);
            paymentsSearchTab.Controls.Add(label6);
            paymentsSearchTab.Location = new System.Drawing.Point(4, 24);
            paymentsSearchTab.Name = "paymentsSearchTab";
            paymentsSearchTab.Size = new System.Drawing.Size(742, 512);
            paymentsSearchTab.TabIndex = 3;
            paymentsSearchTab.Text = "Search";
            paymentsSearchTab.UseVisualStyleBackColor = true;
            // 
            // searchPayTreeView
            // 
            searchPayTreeView.Location = new System.Drawing.Point(405, 220);
            searchPayTreeView.Name = "searchPayTreeView";
            searchPayTreeView.Size = new System.Drawing.Size(315, 220);
            searchPayTreeView.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(400, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 19);
            label3.TabIndex = 34;
            label3.Text = "Tree View";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel2.Location = new System.Drawing.Point(630, 20);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(89, 19);
            linkLabel2.TabIndex = 33;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "API Endpoint";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // paySearchGoToFileButton
            // 
            paySearchGoToFileButton.Location = new System.Drawing.Point(390, 20);
            paySearchGoToFileButton.Name = "paySearchGoToFileButton";
            paySearchGoToFileButton.Size = new System.Drawing.Size(75, 23);
            paySearchGoToFileButton.TabIndex = 32;
            paySearchGoToFileButton.Text = "Go to File";
            paySearchGoToFileButton.UseVisualStyleBackColor = true;
            paySearchGoToFileButton.Click += payDetailsGoToFileButton_Click;
            // 
            // paymentsSearchResultsTextBox
            // 
            paymentsSearchResultsTextBox.Location = new System.Drawing.Point(15, 220);
            paymentsSearchResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            paymentsSearchResultsTextBox.Multiline = true;
            paymentsSearchResultsTextBox.Name = "paymentsSearchResultsTextBox";
            paymentsSearchResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            paymentsSearchResultsTextBox.Size = new System.Drawing.Size(340, 220);
            paymentsSearchResultsTextBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(15, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 19);
            label8.TabIndex = 27;
            label8.Text = "Raw JSON";
            // 
            // searchPaymentStatusBox
            // 
            searchPaymentStatusBox.Enabled = false;
            searchPaymentStatusBox.Location = new System.Drawing.Point(125, 160);
            searchPaymentStatusBox.Name = "searchPaymentStatusBox";
            searchPaymentStatusBox.Size = new System.Drawing.Size(75, 23);
            searchPaymentStatusBox.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(15, 160);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 19);
            label7.TabIndex = 25;
            label7.Text = "Response Code";
            // 
            // paymentSearchResetButton
            // 
            paymentSearchResetButton.Location = new System.Drawing.Point(120, 90);
            paymentSearchResetButton.Margin = new System.Windows.Forms.Padding(4);
            paymentSearchResetButton.Name = "paymentSearchResetButton";
            paymentSearchResetButton.Size = new System.Drawing.Size(94, 26);
            paymentSearchResetButton.TabIndex = 24;
            paymentSearchResetButton.Text = "Clear";
            paymentSearchResetButton.UseVisualStyleBackColor = true;
            paymentSearchResetButton.Click += paymentSearchResetButton_Click;
            // 
            // paymentSearchButton
            // 
            paymentSearchButton.Location = new System.Drawing.Point(15, 90);
            paymentSearchButton.Name = "paymentSearchButton";
            paymentSearchButton.Size = new System.Drawing.Size(94, 26);
            paymentSearchButton.TabIndex = 20;
            paymentSearchButton.Text = "Run";
            paymentSearchButton.UseVisualStyleBackColor = true;
            paymentSearchButton.Click += paymentSearchButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(320, 19);
            label6.TabIndex = 19;
            label6.Text = "Payload File:  Requests\\SecurePaymentsSearch.json";
            // 
            // paymentsExportTab
            // 
            paymentsExportTab.Controls.Add(payExportResultsTextBox);
            paymentsExportTab.Controls.Add(label10);
            paymentsExportTab.Controls.Add(payExportStatusBox);
            paymentsExportTab.Controls.Add(label9);
            paymentsExportTab.Controls.Add(payExportClearButton);
            paymentsExportTab.Controls.Add(payExportRunButton);
            paymentsExportTab.Controls.Add(payExportAPILink);
            paymentsExportTab.Controls.Add(payExportGoToFileButton);
            paymentsExportTab.Controls.Add(label4);
            paymentsExportTab.Location = new System.Drawing.Point(4, 24);
            paymentsExportTab.Name = "paymentsExportTab";
            paymentsExportTab.Size = new System.Drawing.Size(742, 512);
            paymentsExportTab.TabIndex = 4;
            paymentsExportTab.Text = "Export";
            paymentsExportTab.UseVisualStyleBackColor = true;
            // 
            // payExportResultsTextBox
            // 
            payExportResultsTextBox.Location = new System.Drawing.Point(15, 220);
            payExportResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            payExportResultsTextBox.Multiline = true;
            payExportResultsTextBox.Name = "payExportResultsTextBox";
            payExportResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payExportResultsTextBox.Size = new System.Drawing.Size(704, 220);
            payExportResultsTextBox.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            label10.Location = new System.Drawing.Point(15, 190);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(63, 19);
            label10.TabIndex = 39;
            label10.Text = "Raw CSV";
            // 
            // payExportStatusBox
            // 
            payExportStatusBox.Enabled = false;
            payExportStatusBox.Location = new System.Drawing.Point(125, 160);
            payExportStatusBox.Name = "payExportStatusBox";
            payExportStatusBox.Size = new System.Drawing.Size(75, 23);
            payExportStatusBox.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(15, 160);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(103, 19);
            label9.TabIndex = 37;
            label9.Text = "Response Code";
            // 
            // payExportClearButton
            // 
            payExportClearButton.Location = new System.Drawing.Point(120, 90);
            payExportClearButton.Margin = new System.Windows.Forms.Padding(4);
            payExportClearButton.Name = "payExportClearButton";
            payExportClearButton.Size = new System.Drawing.Size(94, 26);
            payExportClearButton.TabIndex = 36;
            payExportClearButton.Text = "Clear";
            payExportClearButton.UseVisualStyleBackColor = true;
            payExportClearButton.Click += payExportClearButton_Click;
            // 
            // payExportRunButton
            // 
            payExportRunButton.Location = new System.Drawing.Point(15, 90);
            payExportRunButton.Name = "payExportRunButton";
            payExportRunButton.Size = new System.Drawing.Size(94, 26);
            payExportRunButton.TabIndex = 35;
            payExportRunButton.Text = "Run";
            payExportRunButton.UseVisualStyleBackColor = true;
            payExportRunButton.Click += payExportRunButton_Click;
            // 
            // payExportAPILink
            // 
            payExportAPILink.AutoSize = true;
            payExportAPILink.Font = new System.Drawing.Font("Segoe UI", 10F);
            payExportAPILink.Location = new System.Drawing.Point(630, 20);
            payExportAPILink.Name = "payExportAPILink";
            payExportAPILink.Size = new System.Drawing.Size(89, 19);
            payExportAPILink.TabIndex = 34;
            payExportAPILink.TabStop = true;
            payExportAPILink.Text = "API Endpoint";
            payExportAPILink.LinkClicked += payExportAPILink_LinkClicked;
            // 
            // payExportGoToFileButton
            // 
            payExportGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payExportGoToFileButton.Name = "payExportGoToFileButton";
            payExportGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payExportGoToFileButton.TabIndex = 33;
            payExportGoToFileButton.Text = "Go to File";
            payExportGoToFileButton.UseVisualStyleBackColor = true;
            payExportGoToFileButton.Click += payExportGoToFileButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(15, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(319, 19);
            label4.TabIndex = 20;
            label4.Text = "Payload File:  Requests\\SecurePaymentsExport.json";
            // 
            // PaymentsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(paymentsTabControl);
            Controls.Add(label5);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "PaymentsControl";
            Size = new System.Drawing.Size(910, 650);
            paymentsTabControl.ResumeLayout(false);
            paymentsCreateTab.ResumeLayout(false);
            paymentsCreateTab.PerformLayout();
            paymentsSearchTab.ResumeLayout(false);
            paymentsSearchTab.PerformLayout();
            paymentsExportTab.ResumeLayout(false);
            paymentsExportTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createPaymentButton;
        private System.Windows.Forms.TextBox createPaymentResultsTextBox;
        private System.Windows.Forms.TabControl paymentsTabControl;
        private System.Windows.Forms.TabPage paymentsCreateTab;
        private System.Windows.Forms.TabPage paymentsSearchTab;
        private System.Windows.Forms.Label createPaymentLabel;
        private System.Windows.Forms.Label createPaymentRespLabel;
        private System.Windows.Forms.TextBox createPaymentStatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createPaymentResetButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button paymentSearchResetButton;
        private System.Windows.Forms.Button paymentSearchButton;
        private System.Windows.Forms.TextBox searchPaymentStatusBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paymentsSearchResultsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button payCreateGoToFileButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TreeView payCreateTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paySearchGoToFileButton;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TreeView searchPayTreeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage paymentsExportTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox payExportStatusBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button payExportClearButton;
        private System.Windows.Forms.Button payExportRunButton;
        private System.Windows.Forms.LinkLabel payExportAPILink;
        private System.Windows.Forms.Button payExportGoToFileButton;
        private System.Windows.Forms.TextBox payExportResultsTextBox;
    }
}
