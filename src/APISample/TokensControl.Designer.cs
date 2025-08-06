namespace APISample
{
    partial class TokensControl
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
            tokensTabControl = new System.Windows.Forms.TabControl();
            tokensDeactivateTab = new System.Windows.Forms.TabPage();
            tokensDeactivateTreeView = new System.Windows.Forms.TreeView();
            label3 = new System.Windows.Forms.Label();
            tokensDeactivateResultsTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tokensDeactivateStatusBox = new System.Windows.Forms.TextBox();
            createPaymentRespLabel = new System.Windows.Forms.Label();
            tokensDeactivateResetButton = new System.Windows.Forms.Button();
            tokensDeactivateRunButton = new System.Windows.Forms.Button();
            tokensDeactivateAPILabel = new System.Windows.Forms.LinkLabel();
            tokensDeactivateGoToFileButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tokensDetailsTab = new System.Windows.Forms.TabPage();
            tokensDetailsTreeView = new System.Windows.Forms.TreeView();
            label8 = new System.Windows.Forms.Label();
            tokensDetailsResultsTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            tokensDetailsStatusBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            tokensDetailsResetButton = new System.Windows.Forms.Button();
            tokensDetailsRunButton = new System.Windows.Forms.Button();
            tokensDetailsAPILabel = new System.Windows.Forms.LinkLabel();
            tokensDetailsGoToFileButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            tokensTabControl.SuspendLayout();
            tokensDeactivateTab.SuspendLayout();
            tokensDetailsTab.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 26);
            label5.TabIndex = 13;
            label5.Text = "Tokens";
            // 
            // tokensTabControl
            // 
            tokensTabControl.Controls.Add(tokensDeactivateTab);
            tokensTabControl.Controls.Add(tokensDetailsTab);
            tokensTabControl.Location = new System.Drawing.Point(100, 100);
            tokensTabControl.Name = "tokensTabControl";
            tokensTabControl.SelectedIndex = 0;
            tokensTabControl.Size = new System.Drawing.Size(750, 540);
            tokensTabControl.TabIndex = 14;
            // 
            // tokensDeactivateTab
            // 
            tokensDeactivateTab.Controls.Add(tokensDeactivateTreeView);
            tokensDeactivateTab.Controls.Add(label3);
            tokensDeactivateTab.Controls.Add(tokensDeactivateResultsTextBox);
            tokensDeactivateTab.Controls.Add(label2);
            tokensDeactivateTab.Controls.Add(tokensDeactivateStatusBox);
            tokensDeactivateTab.Controls.Add(createPaymentRespLabel);
            tokensDeactivateTab.Controls.Add(tokensDeactivateResetButton);
            tokensDeactivateTab.Controls.Add(tokensDeactivateRunButton);
            tokensDeactivateTab.Controls.Add(tokensDeactivateAPILabel);
            tokensDeactivateTab.Controls.Add(tokensDeactivateGoToFileButton);
            tokensDeactivateTab.Controls.Add(label1);
            tokensDeactivateTab.Location = new System.Drawing.Point(4, 24);
            tokensDeactivateTab.Name = "tokensDeactivateTab";
            tokensDeactivateTab.Padding = new System.Windows.Forms.Padding(3);
            tokensDeactivateTab.Size = new System.Drawing.Size(742, 512);
            tokensDeactivateTab.TabIndex = 0;
            tokensDeactivateTab.Text = "Deactivate";
            tokensDeactivateTab.UseVisualStyleBackColor = true;
            // 
            // tokensDeactivateTreeView
            // 
            tokensDeactivateTreeView.Location = new System.Drawing.Point(405, 220);
            tokensDeactivateTreeView.Name = "tokensDeactivateTreeView";
            tokensDeactivateTreeView.Size = new System.Drawing.Size(315, 220);
            tokensDeactivateTreeView.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(400, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 19);
            label3.TabIndex = 42;
            label3.Text = "Tree View";
            // 
            // tokensDeactivateResultsTextBox
            // 
            tokensDeactivateResultsTextBox.Location = new System.Drawing.Point(15, 220);
            tokensDeactivateResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            tokensDeactivateResultsTextBox.Multiline = true;
            tokensDeactivateResultsTextBox.Name = "tokensDeactivateResultsTextBox";
            tokensDeactivateResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tokensDeactivateResultsTextBox.Size = new System.Drawing.Size(340, 220);
            tokensDeactivateResultsTextBox.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 19);
            label2.TabIndex = 40;
            label2.Text = "Raw JSON";
            // 
            // tokensDeactivateStatusBox
            // 
            tokensDeactivateStatusBox.Enabled = false;
            tokensDeactivateStatusBox.Location = new System.Drawing.Point(125, 160);
            tokensDeactivateStatusBox.Name = "tokensDeactivateStatusBox";
            tokensDeactivateStatusBox.Size = new System.Drawing.Size(75, 23);
            tokensDeactivateStatusBox.TabIndex = 39;
            // 
            // createPaymentRespLabel
            // 
            createPaymentRespLabel.AutoSize = true;
            createPaymentRespLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            createPaymentRespLabel.Location = new System.Drawing.Point(15, 160);
            createPaymentRespLabel.Name = "createPaymentRespLabel";
            createPaymentRespLabel.Size = new System.Drawing.Size(103, 19);
            createPaymentRespLabel.TabIndex = 38;
            createPaymentRespLabel.Text = "Response Code";
            // 
            // tokensDeactivateResetButton
            // 
            tokensDeactivateResetButton.Location = new System.Drawing.Point(120, 90);
            tokensDeactivateResetButton.Margin = new System.Windows.Forms.Padding(4);
            tokensDeactivateResetButton.Name = "tokensDeactivateResetButton";
            tokensDeactivateResetButton.Size = new System.Drawing.Size(94, 26);
            tokensDeactivateResetButton.TabIndex = 37;
            tokensDeactivateResetButton.Text = "Clear";
            tokensDeactivateResetButton.UseVisualStyleBackColor = true;
            tokensDeactivateResetButton.Click += tokensDeactivateResetButton_Click;
            // 
            // tokensDeactivateRunButton
            // 
            tokensDeactivateRunButton.Location = new System.Drawing.Point(15, 90);
            tokensDeactivateRunButton.Margin = new System.Windows.Forms.Padding(4);
            tokensDeactivateRunButton.Name = "tokensDeactivateRunButton";
            tokensDeactivateRunButton.Size = new System.Drawing.Size(94, 26);
            tokensDeactivateRunButton.TabIndex = 36;
            tokensDeactivateRunButton.Text = "Run";
            tokensDeactivateRunButton.UseVisualStyleBackColor = true;
            tokensDeactivateRunButton.Click += tokensDeactivateRunButton_Click;
            // 
            // tokensDeactivateAPILabel
            // 
            tokensDeactivateAPILabel.AutoSize = true;
            tokensDeactivateAPILabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            tokensDeactivateAPILabel.Location = new System.Drawing.Point(630, 20);
            tokensDeactivateAPILabel.Name = "tokensDeactivateAPILabel";
            tokensDeactivateAPILabel.Size = new System.Drawing.Size(89, 19);
            tokensDeactivateAPILabel.TabIndex = 35;
            tokensDeactivateAPILabel.TabStop = true;
            tokensDeactivateAPILabel.Text = "API Endpoint";
            tokensDeactivateAPILabel.LinkClicked += tokensDeactivateAPILabel_LinkClicked;
            // 
            // tokensDeactivateGoToFileButton
            // 
            tokensDeactivateGoToFileButton.Location = new System.Drawing.Point(390, 20);
            tokensDeactivateGoToFileButton.Name = "tokensDeactivateGoToFileButton";
            tokensDeactivateGoToFileButton.Size = new System.Drawing.Size(75, 23);
            tokensDeactivateGoToFileButton.TabIndex = 34;
            tokensDeactivateGoToFileButton.Text = "Go to File";
            tokensDeactivateGoToFileButton.UseVisualStyleBackColor = true;
            tokensDeactivateGoToFileButton.Click += tokensDeactivateGoToFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(15, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(326, 19);
            label1.TabIndex = 21;
            label1.Text = "Payload File:  Requests\\SecureTokensDeactivate.json";
            // 
            // tokensDetailsTab
            // 
            tokensDetailsTab.Controls.Add(label9);
            tokensDetailsTab.Controls.Add(tokensDetailsTreeView);
            tokensDetailsTab.Controls.Add(label8);
            tokensDetailsTab.Controls.Add(tokensDetailsResultsTextBox);
            tokensDetailsTab.Controls.Add(label7);
            tokensDetailsTab.Controls.Add(tokensDetailsStatusBox);
            tokensDetailsTab.Controls.Add(label6);
            tokensDetailsTab.Controls.Add(tokensDetailsResetButton);
            tokensDetailsTab.Controls.Add(tokensDetailsRunButton);
            tokensDetailsTab.Controls.Add(tokensDetailsAPILabel);
            tokensDetailsTab.Controls.Add(tokensDetailsGoToFileButton);
            tokensDetailsTab.Controls.Add(label4);
            tokensDetailsTab.Location = new System.Drawing.Point(4, 24);
            tokensDetailsTab.Name = "tokensDetailsTab";
            tokensDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            tokensDetailsTab.Size = new System.Drawing.Size(742, 512);
            tokensDetailsTab.TabIndex = 1;
            tokensDetailsTab.Text = "Details";
            tokensDetailsTab.UseVisualStyleBackColor = true;
            // 
            // tokensDetailsTreeView
            // 
            tokensDetailsTreeView.Location = new System.Drawing.Point(405, 220);
            tokensDetailsTreeView.Name = "tokensDetailsTreeView";
            tokensDetailsTreeView.Size = new System.Drawing.Size(315, 220);
            tokensDetailsTreeView.TabIndex = 43;
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
            // tokensDetailsResultsTextBox
            // 
            tokensDetailsResultsTextBox.Location = new System.Drawing.Point(15, 220);
            tokensDetailsResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            tokensDetailsResultsTextBox.Multiline = true;
            tokensDetailsResultsTextBox.Name = "tokensDetailsResultsTextBox";
            tokensDetailsResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tokensDetailsResultsTextBox.Size = new System.Drawing.Size(340, 220);
            tokensDetailsResultsTextBox.TabIndex = 41;
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
            // tokensDetailsStatusBox
            // 
            tokensDetailsStatusBox.Enabled = false;
            tokensDetailsStatusBox.Location = new System.Drawing.Point(125, 160);
            tokensDetailsStatusBox.Name = "tokensDetailsStatusBox";
            tokensDetailsStatusBox.Size = new System.Drawing.Size(75, 23);
            tokensDetailsStatusBox.TabIndex = 39;
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
            // tokensDetailsResetButton
            // 
            tokensDetailsResetButton.Location = new System.Drawing.Point(120, 90);
            tokensDetailsResetButton.Margin = new System.Windows.Forms.Padding(4);
            tokensDetailsResetButton.Name = "tokensDetailsResetButton";
            tokensDetailsResetButton.Size = new System.Drawing.Size(94, 26);
            tokensDetailsResetButton.TabIndex = 37;
            tokensDetailsResetButton.Text = "Clear";
            tokensDetailsResetButton.UseVisualStyleBackColor = true;
            tokensDetailsResetButton.Click += tokensDetailsResetButton_Click;
            // 
            // tokensDetailsRunButton
            // 
            tokensDetailsRunButton.Location = new System.Drawing.Point(15, 90);
            tokensDetailsRunButton.Margin = new System.Windows.Forms.Padding(4);
            tokensDetailsRunButton.Name = "tokensDetailsRunButton";
            tokensDetailsRunButton.Size = new System.Drawing.Size(94, 26);
            tokensDetailsRunButton.TabIndex = 36;
            tokensDetailsRunButton.Text = "Run";
            tokensDetailsRunButton.UseVisualStyleBackColor = true;
            tokensDetailsRunButton.Click += tokensDetailsRunButton_Click;
            // 
            // tokensDetailsAPILabel
            // 
            tokensDetailsAPILabel.AutoSize = true;
            tokensDetailsAPILabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            tokensDetailsAPILabel.Location = new System.Drawing.Point(630, 20);
            tokensDetailsAPILabel.Name = "tokensDetailsAPILabel";
            tokensDetailsAPILabel.Size = new System.Drawing.Size(89, 19);
            tokensDetailsAPILabel.TabIndex = 35;
            tokensDetailsAPILabel.TabStop = true;
            tokensDetailsAPILabel.Text = "API Endpoint";
            tokensDetailsAPILabel.LinkClicked += tokensDetailsAPILabel_LinkClicked;
            // 
            // tokensDetailsGoToFileButton
            // 
            tokensDetailsGoToFileButton.Location = new System.Drawing.Point(390, 20);
            tokensDetailsGoToFileButton.Name = "tokensDetailsGoToFileButton";
            tokensDetailsGoToFileButton.Size = new System.Drawing.Size(75, 23);
            tokensDetailsGoToFileButton.TabIndex = 34;
            tokensDetailsGoToFileButton.Text = "Go to File";
            tokensDetailsGoToFileButton.UseVisualStyleBackColor = true;
            tokensDetailsGoToFileButton.Click += tokensDetailsGoToFileButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(15, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(316, 19);
            label4.TabIndex = 21;
            label4.Text = "Payload File:  Requests\\SecureTokenLinkDetail.json";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(15, 50);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(38, 15);
            label9.TabIndex = 45;
            label9.Text = "label9";
            // 
            // TokensControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tokensTabControl);
            Controls.Add(label5);
            Location = new System.Drawing.Point(130, 10);
            Name = "TokensControl";
            Size = new System.Drawing.Size(980, 591);
            tokensTabControl.ResumeLayout(false);
            tokensDeactivateTab.ResumeLayout(false);
            tokensDeactivateTab.PerformLayout();
            tokensDetailsTab.ResumeLayout(false);
            tokensDetailsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tokensTabControl;
        private System.Windows.Forms.TabPage tokensDeactivateTab;
        private System.Windows.Forms.TabPage tokensDetailsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tokensDeactivateGoToFileButton;
        private System.Windows.Forms.LinkLabel tokensDeactivateAPILabel;
        private System.Windows.Forms.Button tokensDeactivateRunButton;
        private System.Windows.Forms.Button tokensDeactivateResetButton;
        private System.Windows.Forms.Label createPaymentRespLabel;
        private System.Windows.Forms.TextBox tokensDeactivateStatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tokensDeactivateResultsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tokensDeactivateTreeView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tokensDetailsGoToFileButton;
        private System.Windows.Forms.LinkLabel tokensDetailsAPILabel;
        private System.Windows.Forms.Button tokensDetailsRunButton;
        private System.Windows.Forms.Button tokensDetailsResetButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tokensDetailsStatusBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tokensDetailsResultsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView tokensDetailsTreeView;
        private System.Windows.Forms.Label label9;
    }
}
