namespace APISample
{
    partial class ReportsControl
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
            reportsTabControl = new System.Windows.Forms.TabControl();
            reportsDownloadTab = new System.Windows.Forms.TabPage();
            reportsDownloadResponseText = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            reportsDownloadStatusTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            reportsDownloadClearButton = new System.Windows.Forms.Button();
            reportsDownloadRunButton = new System.Windows.Forms.Button();
            reportsDownloadAPIButton = new System.Windows.Forms.LinkLabel();
            reportsDownloadGotToFileButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            reportsTabControl.SuspendLayout();
            reportsDownloadTab.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 26);
            label5.TabIndex = 12;
            label5.Text = "Reports";
            // 
            // reportsTabControl
            // 
            reportsTabControl.Controls.Add(reportsDownloadTab);
            reportsTabControl.Location = new System.Drawing.Point(100, 100);
            reportsTabControl.Name = "reportsTabControl";
            reportsTabControl.SelectedIndex = 0;
            reportsTabControl.Size = new System.Drawing.Size(750, 540);
            reportsTabControl.TabIndex = 13;
            // 
            // reportsDownloadTab
            // 
            reportsDownloadTab.Controls.Add(reportsDownloadResponseText);
            reportsDownloadTab.Controls.Add(label8);
            reportsDownloadTab.Controls.Add(reportsDownloadStatusTextBox);
            reportsDownloadTab.Controls.Add(label7);
            reportsDownloadTab.Controls.Add(reportsDownloadClearButton);
            reportsDownloadTab.Controls.Add(reportsDownloadRunButton);
            reportsDownloadTab.Controls.Add(reportsDownloadAPIButton);
            reportsDownloadTab.Controls.Add(reportsDownloadGotToFileButton);
            reportsDownloadTab.Controls.Add(label6);
            reportsDownloadTab.Location = new System.Drawing.Point(4, 24);
            reportsDownloadTab.Name = "reportsDownloadTab";
            reportsDownloadTab.Padding = new System.Windows.Forms.Padding(3);
            reportsDownloadTab.Size = new System.Drawing.Size(742, 512);
            reportsDownloadTab.TabIndex = 0;
            reportsDownloadTab.Text = "Download";
            reportsDownloadTab.UseVisualStyleBackColor = true;
            // 
            // reportsDownloadResponseText
            // 
            reportsDownloadResponseText.Location = new System.Drawing.Point(15, 220);
            reportsDownloadResponseText.Margin = new System.Windows.Forms.Padding(2);
            reportsDownloadResponseText.Multiline = true;
            reportsDownloadResponseText.Name = "reportsDownloadResponseText";
            reportsDownloadResponseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            reportsDownloadResponseText.Size = new System.Drawing.Size(704, 220);
            reportsDownloadResponseText.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(15, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 19);
            label8.TabIndex = 41;
            label8.Text = "CSV Data";
            // 
            // reportsDownloadStatusTextBox
            // 
            reportsDownloadStatusTextBox.Enabled = false;
            reportsDownloadStatusTextBox.Location = new System.Drawing.Point(125, 160);
            reportsDownloadStatusTextBox.Name = "reportsDownloadStatusTextBox";
            reportsDownloadStatusTextBox.Size = new System.Drawing.Size(75, 23);
            reportsDownloadStatusTextBox.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(15, 160);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 19);
            label7.TabIndex = 39;
            label7.Text = "Response Code";
            // 
            // reportsDownloadClearButton
            // 
            reportsDownloadClearButton.AutoSize = true;
            reportsDownloadClearButton.Location = new System.Drawing.Point(120, 90);
            reportsDownloadClearButton.Margin = new System.Windows.Forms.Padding(4);
            reportsDownloadClearButton.Name = "reportsDownloadClearButton";
            reportsDownloadClearButton.Size = new System.Drawing.Size(94, 26);
            reportsDownloadClearButton.TabIndex = 38;
            reportsDownloadClearButton.Text = "Clear";
            reportsDownloadClearButton.UseVisualStyleBackColor = true;
            reportsDownloadClearButton.Click += reportsDownloadClearButton_Click;
            // 
            // reportsDownloadRunButton
            // 
            reportsDownloadRunButton.Location = new System.Drawing.Point(15, 90);
            reportsDownloadRunButton.Name = "reportsDownloadRunButton";
            reportsDownloadRunButton.Size = new System.Drawing.Size(94, 26);
            reportsDownloadRunButton.TabIndex = 37;
            reportsDownloadRunButton.Text = "Run";
            reportsDownloadRunButton.UseVisualStyleBackColor = true;
            reportsDownloadRunButton.Click += reportsDownloadRunButton_Click;
            // 
            // reportsDownloadAPIButton
            // 
            reportsDownloadAPIButton.AutoSize = true;
            reportsDownloadAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            reportsDownloadAPIButton.Location = new System.Drawing.Point(630, 20);
            reportsDownloadAPIButton.Name = "reportsDownloadAPIButton";
            reportsDownloadAPIButton.Size = new System.Drawing.Size(89, 19);
            reportsDownloadAPIButton.TabIndex = 35;
            reportsDownloadAPIButton.TabStop = true;
            reportsDownloadAPIButton.Text = "API Endpoint";
            reportsDownloadAPIButton.LinkClicked += reportsDownloadAPIButton_LinkClicked;
            // 
            // reportsDownloadGotToFileButton
            // 
            reportsDownloadGotToFileButton.Location = new System.Drawing.Point(390, 20);
            reportsDownloadGotToFileButton.Name = "reportsDownloadGotToFileButton";
            reportsDownloadGotToFileButton.Size = new System.Drawing.Size(75, 23);
            reportsDownloadGotToFileButton.TabIndex = 34;
            reportsDownloadGotToFileButton.Text = "Go to File";
            reportsDownloadGotToFileButton.UseVisualStyleBackColor = true;
            reportsDownloadGotToFileButton.Click += reportsDownloadGotToFileButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(329, 19);
            label6.TabIndex = 22;
            label6.Text = "Payload File:  Requests\\SecureReportsDownload.json";
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(reportsTabControl);
            Controls.Add(label5);
            Location = new System.Drawing.Point(130, 10);
            Name = "ReportsControl";
            Size = new System.Drawing.Size(980, 591);
            reportsTabControl.ResumeLayout(false);
            reportsDownloadTab.ResumeLayout(false);
            reportsDownloadTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl reportsTabControl;
        private System.Windows.Forms.TabPage reportsDownloadTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reportsDownloadGotToFileButton;
        private System.Windows.Forms.LinkLabel reportsDownloadAPIButton;
        private System.Windows.Forms.Button reportsDownloadRunButton;
        private System.Windows.Forms.Button reportsDownloadClearButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reportsDownloadStatusTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox reportsDownloadResponseText;
    }
}
