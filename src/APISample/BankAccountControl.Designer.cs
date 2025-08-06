namespace APISample
{
    partial class BankAccountControl
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
            bankAccountTabControl = new System.Windows.Forms.TabControl();
            bankAccountDetailsTab = new System.Windows.Forms.TabPage();
            bankAccountsDetailsTreeView = new System.Windows.Forms.TreeView();
            label3 = new System.Windows.Forms.Label();
            bankAccountsDetailsResultsTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            bankAccountsDetailsStatusBox = new System.Windows.Forms.TextBox();
            createPaymentRespLabel = new System.Windows.Forms.Label();
            bankAccountsDetailsResetButton = new System.Windows.Forms.Button();
            bankAccountsDetailsRunButton = new System.Windows.Forms.Button();
            bankAccountAPILabel = new System.Windows.Forms.LinkLabel();
            bankAccountDetailsGoToFileButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            bankAccountVerificationTab = new System.Windows.Forms.TabPage();
            bankAccountsVerifyTreeView = new System.Windows.Forms.TreeView();
            label8 = new System.Windows.Forms.Label();
            bankAccountsVerifyResponseTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            bankAccountsVerifyStatusBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            bankAccountsVerifyResetButton = new System.Windows.Forms.Button();
            bankAccountsVerifyRunButton = new System.Windows.Forms.Button();
            bankAccountsVerifyAPILabel = new System.Windows.Forms.LinkLabel();
            bankAccountsVerifyGoToFileButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            bankAccountTabControl.SuspendLayout();
            bankAccountDetailsTab.SuspendLayout();
            bankAccountVerificationTab.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(158, 26);
            label5.TabIndex = 13;
            label5.Text = "Bank Accounts";
            // 
            // bankAccountTabControl
            // 
            bankAccountTabControl.Controls.Add(bankAccountDetailsTab);
            bankAccountTabControl.Controls.Add(bankAccountVerificationTab);
            bankAccountTabControl.Location = new System.Drawing.Point(100, 100);
            bankAccountTabControl.Name = "bankAccountTabControl";
            bankAccountTabControl.SelectedIndex = 0;
            bankAccountTabControl.Size = new System.Drawing.Size(750, 540);
            bankAccountTabControl.TabIndex = 14;
            // 
            // bankAccountDetailsTab
            // 
            bankAccountDetailsTab.Controls.Add(bankAccountsDetailsTreeView);
            bankAccountDetailsTab.Controls.Add(label3);
            bankAccountDetailsTab.Controls.Add(bankAccountsDetailsResultsTextBox);
            bankAccountDetailsTab.Controls.Add(label2);
            bankAccountDetailsTab.Controls.Add(bankAccountsDetailsStatusBox);
            bankAccountDetailsTab.Controls.Add(createPaymentRespLabel);
            bankAccountDetailsTab.Controls.Add(bankAccountsDetailsResetButton);
            bankAccountDetailsTab.Controls.Add(bankAccountsDetailsRunButton);
            bankAccountDetailsTab.Controls.Add(bankAccountAPILabel);
            bankAccountDetailsTab.Controls.Add(bankAccountDetailsGoToFileButton);
            bankAccountDetailsTab.Controls.Add(label1);
            bankAccountDetailsTab.Location = new System.Drawing.Point(4, 24);
            bankAccountDetailsTab.Name = "bankAccountDetailsTab";
            bankAccountDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            bankAccountDetailsTab.Size = new System.Drawing.Size(742, 512);
            bankAccountDetailsTab.TabIndex = 0;
            bankAccountDetailsTab.Text = "Details";
            bankAccountDetailsTab.UseVisualStyleBackColor = true;
            // 
            // bankAccountsDetailsTreeView
            // 
            bankAccountsDetailsTreeView.Location = new System.Drawing.Point(405, 220);
            bankAccountsDetailsTreeView.Name = "bankAccountsDetailsTreeView";
            bankAccountsDetailsTreeView.Size = new System.Drawing.Size(315, 220);
            bankAccountsDetailsTreeView.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(400, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 19);
            label3.TabIndex = 41;
            label3.Text = "Tree View";
            // 
            // bankAccountsDetailsResultsTextBox
            // 
            bankAccountsDetailsResultsTextBox.Location = new System.Drawing.Point(15, 220);
            bankAccountsDetailsResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            bankAccountsDetailsResultsTextBox.Multiline = true;
            bankAccountsDetailsResultsTextBox.Name = "bankAccountsDetailsResultsTextBox";
            bankAccountsDetailsResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            bankAccountsDetailsResultsTextBox.Size = new System.Drawing.Size(340, 220);
            bankAccountsDetailsResultsTextBox.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 19);
            label2.TabIndex = 39;
            label2.Text = "Raw JSON";
            // 
            // bankAccountsDetailsStatusBox
            // 
            bankAccountsDetailsStatusBox.Enabled = false;
            bankAccountsDetailsStatusBox.Location = new System.Drawing.Point(125, 160);
            bankAccountsDetailsStatusBox.Name = "bankAccountsDetailsStatusBox";
            bankAccountsDetailsStatusBox.Size = new System.Drawing.Size(75, 23);
            bankAccountsDetailsStatusBox.TabIndex = 38;
            // 
            // createPaymentRespLabel
            // 
            createPaymentRespLabel.AutoSize = true;
            createPaymentRespLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            createPaymentRespLabel.Location = new System.Drawing.Point(15, 160);
            createPaymentRespLabel.Name = "createPaymentRespLabel";
            createPaymentRespLabel.Size = new System.Drawing.Size(103, 19);
            createPaymentRespLabel.TabIndex = 37;
            createPaymentRespLabel.Text = "Response Code";
            // 
            // bankAccountsDetailsResetButton
            // 
            bankAccountsDetailsResetButton.Location = new System.Drawing.Point(120, 90);
            bankAccountsDetailsResetButton.Margin = new System.Windows.Forms.Padding(4);
            bankAccountsDetailsResetButton.Name = "bankAccountsDetailsResetButton";
            bankAccountsDetailsResetButton.Size = new System.Drawing.Size(94, 26);
            bankAccountsDetailsResetButton.TabIndex = 36;
            bankAccountsDetailsResetButton.Text = "Clear";
            bankAccountsDetailsResetButton.UseVisualStyleBackColor = true;
            bankAccountsDetailsResetButton.Click += bankAccountsDetailsResetButton_Click;
            // 
            // bankAccountsDetailsRunButton
            // 
            bankAccountsDetailsRunButton.Location = new System.Drawing.Point(15, 90);
            bankAccountsDetailsRunButton.Margin = new System.Windows.Forms.Padding(4);
            bankAccountsDetailsRunButton.Name = "bankAccountsDetailsRunButton";
            bankAccountsDetailsRunButton.Size = new System.Drawing.Size(94, 26);
            bankAccountsDetailsRunButton.TabIndex = 35;
            bankAccountsDetailsRunButton.Text = "Run";
            bankAccountsDetailsRunButton.UseVisualStyleBackColor = true;
            bankAccountsDetailsRunButton.Click += bankAccountsDetailsRunButton_Click;
            // 
            // bankAccountAPILabel
            // 
            bankAccountAPILabel.AutoSize = true;
            bankAccountAPILabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            bankAccountAPILabel.Location = new System.Drawing.Point(630, 20);
            bankAccountAPILabel.Name = "bankAccountAPILabel";
            bankAccountAPILabel.Size = new System.Drawing.Size(89, 19);
            bankAccountAPILabel.TabIndex = 34;
            bankAccountAPILabel.TabStop = true;
            bankAccountAPILabel.Text = "API Endpoint";
            bankAccountAPILabel.LinkClicked += bankAccountAPILabel_LinkClicked;
            // 
            // bankAccountDetailsGoToFileButton
            // 
            bankAccountDetailsGoToFileButton.Location = new System.Drawing.Point(390, 20);
            bankAccountDetailsGoToFileButton.Name = "bankAccountDetailsGoToFileButton";
            bankAccountDetailsGoToFileButton.Size = new System.Drawing.Size(75, 23);
            bankAccountDetailsGoToFileButton.TabIndex = 33;
            bankAccountDetailsGoToFileButton.Text = "Go to File";
            bankAccountDetailsGoToFileButton.UseVisualStyleBackColor = true;
            bankAccountDetailsGoToFileButton.Click += bankAccountDetailsGoToFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(15, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(347, 19);
            label1.TabIndex = 20;
            label1.Text = "Payload File:  Requests\\SecureBankAccountsDetails.json";
            // 
            // bankAccountVerificationTab
            // 
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyTreeView);
            bankAccountVerificationTab.Controls.Add(label8);
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyResponseTextBox);
            bankAccountVerificationTab.Controls.Add(label7);
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyStatusBox);
            bankAccountVerificationTab.Controls.Add(label6);
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyResetButton);
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyRunButton);
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyAPILabel);
            bankAccountVerificationTab.Controls.Add(bankAccountsVerifyGoToFileButton);
            bankAccountVerificationTab.Controls.Add(label4);
            bankAccountVerificationTab.Location = new System.Drawing.Point(4, 24);
            bankAccountVerificationTab.Name = "bankAccountVerificationTab";
            bankAccountVerificationTab.Padding = new System.Windows.Forms.Padding(3);
            bankAccountVerificationTab.Size = new System.Drawing.Size(742, 512);
            bankAccountVerificationTab.TabIndex = 1;
            bankAccountVerificationTab.Text = "Verification";
            bankAccountVerificationTab.UseVisualStyleBackColor = true;
            // 
            // bankAccountsVerifyTreeView
            // 
            bankAccountsVerifyTreeView.Location = new System.Drawing.Point(405, 220);
            bankAccountsVerifyTreeView.Name = "bankAccountsVerifyTreeView";
            bankAccountsVerifyTreeView.Size = new System.Drawing.Size(315, 220);
            bankAccountsVerifyTreeView.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(400, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 19);
            label8.TabIndex = 42;
            label8.Text = "Tree View";
            // 
            // bankAccountsVerifyResponseTextBox
            // 
            bankAccountsVerifyResponseTextBox.Location = new System.Drawing.Point(15, 220);
            bankAccountsVerifyResponseTextBox.Margin = new System.Windows.Forms.Padding(2);
            bankAccountsVerifyResponseTextBox.Multiline = true;
            bankAccountsVerifyResponseTextBox.Name = "bankAccountsVerifyResponseTextBox";
            bankAccountsVerifyResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            bankAccountsVerifyResponseTextBox.Size = new System.Drawing.Size(340, 220);
            bankAccountsVerifyResponseTextBox.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(15, 190);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 19);
            label7.TabIndex = 40;
            label7.Text = "Raw JSON";
            // 
            // bankAccountsVerifyStatusBox
            // 
            bankAccountsVerifyStatusBox.Enabled = false;
            bankAccountsVerifyStatusBox.Location = new System.Drawing.Point(125, 160);
            bankAccountsVerifyStatusBox.Name = "bankAccountsVerifyStatusBox";
            bankAccountsVerifyStatusBox.Size = new System.Drawing.Size(75, 23);
            bankAccountsVerifyStatusBox.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 160);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 19);
            label6.TabIndex = 38;
            label6.Text = "Response Code";
            // 
            // bankAccountsVerifyResetButton
            // 
            bankAccountsVerifyResetButton.Location = new System.Drawing.Point(120, 90);
            bankAccountsVerifyResetButton.Margin = new System.Windows.Forms.Padding(4);
            bankAccountsVerifyResetButton.Name = "bankAccountsVerifyResetButton";
            bankAccountsVerifyResetButton.Size = new System.Drawing.Size(94, 26);
            bankAccountsVerifyResetButton.TabIndex = 37;
            bankAccountsVerifyResetButton.Text = "Clear";
            bankAccountsVerifyResetButton.UseVisualStyleBackColor = true;
            bankAccountsVerifyResetButton.Click += bankAccountsVerifyResetButton_Click;
            // 
            // bankAccountsVerifyRunButton
            // 
            bankAccountsVerifyRunButton.Location = new System.Drawing.Point(15, 90);
            bankAccountsVerifyRunButton.Margin = new System.Windows.Forms.Padding(4);
            bankAccountsVerifyRunButton.Name = "bankAccountsVerifyRunButton";
            bankAccountsVerifyRunButton.Size = new System.Drawing.Size(94, 26);
            bankAccountsVerifyRunButton.TabIndex = 36;
            bankAccountsVerifyRunButton.Text = "Run";
            bankAccountsVerifyRunButton.UseVisualStyleBackColor = true;
            bankAccountsVerifyRunButton.Click += bankAccountsVerifyRunButton_Click;
            // 
            // bankAccountsVerifyAPILabel
            // 
            bankAccountsVerifyAPILabel.AutoSize = true;
            bankAccountsVerifyAPILabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            bankAccountsVerifyAPILabel.Location = new System.Drawing.Point(630, 20);
            bankAccountsVerifyAPILabel.Name = "bankAccountsVerifyAPILabel";
            bankAccountsVerifyAPILabel.Size = new System.Drawing.Size(89, 19);
            bankAccountsVerifyAPILabel.TabIndex = 35;
            bankAccountsVerifyAPILabel.TabStop = true;
            bankAccountsVerifyAPILabel.Text = "API Endpoint";
            bankAccountsVerifyAPILabel.LinkClicked += bankAccountsVerifyAPILabel_LinkClicked;
            // 
            // bankAccountsVerifyGoToFileButton
            // 
            bankAccountsVerifyGoToFileButton.Location = new System.Drawing.Point(390, 20);
            bankAccountsVerifyGoToFileButton.Name = "bankAccountsVerifyGoToFileButton";
            bankAccountsVerifyGoToFileButton.Size = new System.Drawing.Size(75, 23);
            bankAccountsVerifyGoToFileButton.TabIndex = 34;
            bankAccountsVerifyGoToFileButton.Text = "Go to File";
            bankAccountsVerifyGoToFileButton.UseVisualStyleBackColor = true;
            bankAccountsVerifyGoToFileButton.Click += bankAccountsVerifyGoToFileButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(15, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(340, 19);
            label4.TabIndex = 21;
            label4.Text = "Payload File:  Requests\\SecureBankAccountsVerify.json";
            // 
            // BankAccountControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(bankAccountTabControl);
            Controls.Add(label5);
            Name = "BankAccountControl";
            Size = new System.Drawing.Size(910, 650);
            bankAccountTabControl.ResumeLayout(false);
            bankAccountDetailsTab.ResumeLayout(false);
            bankAccountDetailsTab.PerformLayout();
            bankAccountVerificationTab.ResumeLayout(false);
            bankAccountVerificationTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl bankAccountTabControl;
        private System.Windows.Forms.TabPage bankAccountDetailsTab;
        private System.Windows.Forms.TabPage bankAccountVerificationTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bankAccountDetailsGoToFileButton;
        private System.Windows.Forms.LinkLabel bankAccountAPILabel;
        private System.Windows.Forms.Button bankAccountsDetailsRunButton;
        private System.Windows.Forms.Button bankAccountsDetailsResetButton;
        private System.Windows.Forms.Label createPaymentRespLabel;
        private System.Windows.Forms.TextBox bankAccountsDetailsStatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bankAccountsDetailsResultsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView bankAccountsDetailsTreeView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel bankAccountsVerifyAPILabel;
        private System.Windows.Forms.Button bankAccountsVerifyGoToFileButton;
        private System.Windows.Forms.Button bankAccountsVerifyResetButton;
        private System.Windows.Forms.Button bankAccountsVerifyRunButton;
        private System.Windows.Forms.TextBox bankAccountsVerifyStatusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bankAccountsVerifyResponseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView bankAccountsVerifyTreeView;
    }
}
