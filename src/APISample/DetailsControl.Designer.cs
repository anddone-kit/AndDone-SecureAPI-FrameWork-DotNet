namespace APISample
{
    partial class DetailsControl
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
            paymentDetailsTabControl = new System.Windows.Forms.TabControl();
            detailsIdTab = new System.Windows.Forms.TabPage();
            payDetailTreeView = new System.Windows.Forms.TreeView();
            label2 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            payDetailsGoToFileButton = new System.Windows.Forms.Button();
            detailsByIdDependLabel = new System.Windows.Forms.Label();
            detailsByIdResultsTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            detailsByIdStatusBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            paymentDetailsResetButton = new System.Windows.Forms.Button();
            paymentDetailsByIdButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            detailsTokenTab = new System.Windows.Forms.TabPage();
            payDetailTokenTree = new System.Windows.Forms.TreeView();
            label9 = new System.Windows.Forms.Label();
            payDetailTokenResponseText = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            payDetailTokenStatusTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            payDetailTokenClearButton = new System.Windows.Forms.Button();
            payDetailTokenRunButton = new System.Windows.Forms.Button();
            payDetailTokenDepLabel = new System.Windows.Forms.Label();
            payDetailTokenAPIButton = new System.Windows.Forms.LinkLabel();
            payDetailsTokenGotToFileButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            paymentDetailsTabControl.SuspendLayout();
            detailsIdTab.SuspendLayout();
            detailsTokenTab.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(172, 26);
            label5.TabIndex = 12;
            label5.Text = "Payment Details";
            // 
            // paymentDetailsTabControl
            // 
            paymentDetailsTabControl.Controls.Add(detailsIdTab);
            paymentDetailsTabControl.Controls.Add(detailsTokenTab);
            paymentDetailsTabControl.Location = new System.Drawing.Point(100, 100);
            paymentDetailsTabControl.Name = "paymentDetailsTabControl";
            paymentDetailsTabControl.SelectedIndex = 0;
            paymentDetailsTabControl.Size = new System.Drawing.Size(750, 540);
            paymentDetailsTabControl.TabIndex = 13;
            // 
            // detailsIdTab
            // 
            detailsIdTab.Controls.Add(payDetailTreeView);
            detailsIdTab.Controls.Add(label2);
            detailsIdTab.Controls.Add(linkLabel1);
            detailsIdTab.Controls.Add(payDetailsGoToFileButton);
            detailsIdTab.Controls.Add(detailsByIdDependLabel);
            detailsIdTab.Controls.Add(detailsByIdResultsTextBox);
            detailsIdTab.Controls.Add(label4);
            detailsIdTab.Controls.Add(detailsByIdStatusBox);
            detailsIdTab.Controls.Add(label3);
            detailsIdTab.Controls.Add(paymentDetailsResetButton);
            detailsIdTab.Controls.Add(paymentDetailsByIdButton);
            detailsIdTab.Controls.Add(label1);
            detailsIdTab.Location = new System.Drawing.Point(4, 24);
            detailsIdTab.Name = "detailsIdTab";
            detailsIdTab.Padding = new System.Windows.Forms.Padding(3);
            detailsIdTab.Size = new System.Drawing.Size(742, 512);
            detailsIdTab.TabIndex = 0;
            detailsIdTab.Text = "By Id";
            detailsIdTab.UseVisualStyleBackColor = true;
            // 
            // payDetailTreeView
            // 
            payDetailTreeView.Location = new System.Drawing.Point(405, 220);
            payDetailTreeView.Name = "payDetailTreeView";
            payDetailTreeView.Size = new System.Drawing.Size(315, 220);
            payDetailTreeView.TabIndex = 34;
            payDetailTreeView.AfterSelect += payDetailTreeView_AfterSelect;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(400, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 19);
            label2.TabIndex = 33;
            label2.Text = "Tree View";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel1.Location = new System.Drawing.Point(630, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(89, 19);
            linkLabel1.TabIndex = 32;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "API Endpoint";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // payDetailsGoToFileButton
            // 
            payDetailsGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payDetailsGoToFileButton.Name = "payDetailsGoToFileButton";
            payDetailsGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payDetailsGoToFileButton.TabIndex = 31;
            payDetailsGoToFileButton.Text = "Go to File";
            payDetailsGoToFileButton.UseVisualStyleBackColor = true;
            payDetailsGoToFileButton.Click += payDetailsGoToFileButton_Click;
            // 
            // detailsByIdDependLabel
            // 
            detailsByIdDependLabel.AutoSize = true;
            detailsByIdDependLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            detailsByIdDependLabel.Location = new System.Drawing.Point(15, 50);
            detailsByIdDependLabel.Name = "detailsByIdDependLabel";
            detailsByIdDependLabel.Size = new System.Drawing.Size(45, 19);
            detailsByIdDependLabel.TabIndex = 29;
            detailsByIdDependLabel.Text = "label2";
            // 
            // detailsByIdResultsTextBox
            // 
            detailsByIdResultsTextBox.Location = new System.Drawing.Point(15, 220);
            detailsByIdResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            detailsByIdResultsTextBox.Multiline = true;
            detailsByIdResultsTextBox.Name = "detailsByIdResultsTextBox";
            detailsByIdResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            detailsByIdResultsTextBox.Size = new System.Drawing.Size(340, 220);
            detailsByIdResultsTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(15, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 19);
            label4.TabIndex = 27;
            label4.Text = "Raw JSON";
            // 
            // detailsByIdStatusBox
            // 
            detailsByIdStatusBox.Enabled = false;
            detailsByIdStatusBox.Location = new System.Drawing.Point(125, 160);
            detailsByIdStatusBox.Name = "detailsByIdStatusBox";
            detailsByIdStatusBox.Size = new System.Drawing.Size(75, 23);
            detailsByIdStatusBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(15, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 19);
            label3.TabIndex = 25;
            label3.Text = "Response Code";
            // 
            // paymentDetailsResetButton
            // 
            paymentDetailsResetButton.Location = new System.Drawing.Point(120, 90);
            paymentDetailsResetButton.Margin = new System.Windows.Forms.Padding(4);
            paymentDetailsResetButton.Name = "paymentDetailsResetButton";
            paymentDetailsResetButton.Size = new System.Drawing.Size(94, 26);
            paymentDetailsResetButton.TabIndex = 24;
            paymentDetailsResetButton.Text = "Clear";
            paymentDetailsResetButton.UseVisualStyleBackColor = true;
            paymentDetailsResetButton.Click += paymentDetailsResetButton_Click;
            // 
            // paymentDetailsByIdButton
            // 
            paymentDetailsByIdButton.Location = new System.Drawing.Point(15, 90);
            paymentDetailsByIdButton.Name = "paymentDetailsByIdButton";
            paymentDetailsByIdButton.Size = new System.Drawing.Size(94, 26);
            paymentDetailsByIdButton.TabIndex = 20;
            paymentDetailsByIdButton.Text = "Run";
            paymentDetailsByIdButton.UseVisualStyleBackColor = true;
            paymentDetailsByIdButton.Click += paymentDetailsByIdButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(15, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(348, 19);
            label1.TabIndex = 19;
            label1.Text = "Payload File:  Requests\\SecurePaymentsDetailsById.json";
            // 
            // detailsTokenTab
            // 
            detailsTokenTab.Controls.Add(payDetailTokenTree);
            detailsTokenTab.Controls.Add(label9);
            detailsTokenTab.Controls.Add(payDetailTokenResponseText);
            detailsTokenTab.Controls.Add(label8);
            detailsTokenTab.Controls.Add(payDetailTokenStatusTextBox);
            detailsTokenTab.Controls.Add(label7);
            detailsTokenTab.Controls.Add(payDetailTokenClearButton);
            detailsTokenTab.Controls.Add(payDetailTokenRunButton);
            detailsTokenTab.Controls.Add(payDetailTokenDepLabel);
            detailsTokenTab.Controls.Add(payDetailTokenAPIButton);
            detailsTokenTab.Controls.Add(payDetailsTokenGotToFileButton);
            detailsTokenTab.Controls.Add(label6);
            detailsTokenTab.Location = new System.Drawing.Point(4, 24);
            detailsTokenTab.Name = "detailsTokenTab";
            detailsTokenTab.Padding = new System.Windows.Forms.Padding(3);
            detailsTokenTab.Size = new System.Drawing.Size(742, 512);
            detailsTokenTab.TabIndex = 1;
            detailsTokenTab.Text = "By Token";
            detailsTokenTab.UseVisualStyleBackColor = true;
            // 
            // payDetailTokenTree
            // 
            payDetailTokenTree.Location = new System.Drawing.Point(405, 220);
            payDetailTokenTree.Name = "payDetailTokenTree";
            payDetailTokenTree.Size = new System.Drawing.Size(315, 220);
            payDetailTokenTree.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(400, 190);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 19);
            label9.TabIndex = 41;
            label9.Text = "Tree View";
            // 
            // payDetailTokenResponseText
            // 
            payDetailTokenResponseText.Location = new System.Drawing.Point(15, 220);
            payDetailTokenResponseText.Margin = new System.Windows.Forms.Padding(2);
            payDetailTokenResponseText.Multiline = true;
            payDetailTokenResponseText.Name = "payDetailTokenResponseText";
            payDetailTokenResponseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payDetailTokenResponseText.Size = new System.Drawing.Size(340, 220);
            payDetailTokenResponseText.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(15, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 19);
            label8.TabIndex = 39;
            label8.Text = "Raw JSON";
            // 
            // payDetailTokenStatusTextBox
            // 
            payDetailTokenStatusTextBox.Enabled = false;
            payDetailTokenStatusTextBox.Location = new System.Drawing.Point(125, 160);
            payDetailTokenStatusTextBox.Name = "payDetailTokenStatusTextBox";
            payDetailTokenStatusTextBox.Size = new System.Drawing.Size(75, 23);
            payDetailTokenStatusTextBox.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(15, 160);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 19);
            label7.TabIndex = 37;
            label7.Text = "Response Code";
            // 
            // payDetailTokenClearButton
            // 
            payDetailTokenClearButton.AutoSize = true;
            payDetailTokenClearButton.Location = new System.Drawing.Point(120, 90);
            payDetailTokenClearButton.Margin = new System.Windows.Forms.Padding(4);
            payDetailTokenClearButton.Name = "payDetailTokenClearButton";
            payDetailTokenClearButton.Size = new System.Drawing.Size(94, 26);
            payDetailTokenClearButton.TabIndex = 36;
            payDetailTokenClearButton.Text = "Clear";
            payDetailTokenClearButton.UseVisualStyleBackColor = true;
            payDetailTokenClearButton.Click += payDetailTokenClearButton_Click;
            // 
            // payDetailTokenRunButton
            // 
            payDetailTokenRunButton.Location = new System.Drawing.Point(15, 90);
            payDetailTokenRunButton.Name = "payDetailTokenRunButton";
            payDetailTokenRunButton.Size = new System.Drawing.Size(94, 26);
            payDetailTokenRunButton.TabIndex = 35;
            payDetailTokenRunButton.Text = "Run";
            payDetailTokenRunButton.UseVisualStyleBackColor = true;
            payDetailTokenRunButton.Click += payDetailTokenRunButton_Click;
            // 
            // payDetailTokenDepLabel
            // 
            payDetailTokenDepLabel.AutoSize = true;
            payDetailTokenDepLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            payDetailTokenDepLabel.Location = new System.Drawing.Point(15, 50);
            payDetailTokenDepLabel.Name = "payDetailTokenDepLabel";
            payDetailTokenDepLabel.Size = new System.Drawing.Size(45, 19);
            payDetailTokenDepLabel.TabIndex = 34;
            payDetailTokenDepLabel.Text = "label2";
            // 
            // payDetailTokenAPIButton
            // 
            payDetailTokenAPIButton.AutoSize = true;
            payDetailTokenAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            payDetailTokenAPIButton.Location = new System.Drawing.Point(630, 20);
            payDetailTokenAPIButton.Name = "payDetailTokenAPIButton";
            payDetailTokenAPIButton.Size = new System.Drawing.Size(89, 19);
            payDetailTokenAPIButton.TabIndex = 33;
            payDetailTokenAPIButton.TabStop = true;
            payDetailTokenAPIButton.Text = "API Endpoint";
            payDetailTokenAPIButton.LinkClicked += payDetailTokenAPIButton_LinkClicked;
            // 
            // payDetailsTokenGotToFileButton
            // 
            payDetailsTokenGotToFileButton.Location = new System.Drawing.Point(390, 20);
            payDetailsTokenGotToFileButton.Name = "payDetailsTokenGotToFileButton";
            payDetailsTokenGotToFileButton.Size = new System.Drawing.Size(75, 23);
            payDetailsTokenGotToFileButton.TabIndex = 32;
            payDetailsTokenGotToFileButton.Text = "Go to File";
            payDetailsTokenGotToFileButton.UseVisualStyleBackColor = true;
            payDetailsTokenGotToFileButton.Click += payDetailsTokenGotToFileButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(372, 19);
            label6.TabIndex = 20;
            label6.Text = "Payload File:  Requests\\SecurePaymentsDetailsByToken.json";
            // 
            // DetailsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(paymentDetailsTabControl);
            Controls.Add(label5);
            Name = "DetailsControl";
            Size = new System.Drawing.Size(910, 650);
            paymentDetailsTabControl.ResumeLayout(false);
            detailsIdTab.ResumeLayout(false);
            detailsIdTab.PerformLayout();
            detailsTokenTab.ResumeLayout(false);
            detailsTokenTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl paymentDetailsTabControl;
        private System.Windows.Forms.TabPage detailsIdTab;
        private System.Windows.Forms.TabPage detailsTokenTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paymentDetailsByIdButton;
        private System.Windows.Forms.Button paymentDetailsResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox detailsByIdStatusBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox detailsByIdResultsTextBox;
        private System.Windows.Forms.Label detailsByIdDependLabel;
        private System.Windows.Forms.Button payDetailsGoToFileButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView payDetailTreeView;
        private System.Windows.Forms.Button payDetailsTokenGotToFileButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label payDetailTokenDepLabel;
        private System.Windows.Forms.LinkLabel payDetailTokenAPIButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button payDetailTokenClearButton;
        private System.Windows.Forms.Button payDetailTokenRunButton;
        private System.Windows.Forms.TreeView payDetailTokenTree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox payDetailTokenResponseText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox payDetailTokenStatusTextBox;
    }
}
