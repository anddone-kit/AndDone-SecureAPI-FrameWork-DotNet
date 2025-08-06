namespace APISample
{
    partial class RefundsControl
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
            paymentIntentsControl1 = new PaymentIntentsControl();
            label5 = new System.Windows.Forms.Label();
            refundsTabControl = new System.Windows.Forms.TabControl();
            refundEligibleTab = new System.Windows.Forms.TabPage();
            refundEligibleTree = new System.Windows.Forms.TreeView();
            label9 = new System.Windows.Forms.Label();
            refundEligibleResponseText = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            refundEligibleStatusTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            refundEligibleClearButton = new System.Windows.Forms.Button();
            refundEligibleRunButton = new System.Windows.Forms.Button();
            refundEligibleAPIButton = new System.Windows.Forms.LinkLabel();
            refundEligibleGotToFileButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            refundReqeuestTab = new System.Windows.Forms.TabPage();
            refundRequestTree = new System.Windows.Forms.TreeView();
            label4 = new System.Windows.Forms.Label();
            refundRequestResponseTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            refundRequestStatusTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            refundRequestClearButton = new System.Windows.Forms.Button();
            refundRequestRunButton = new System.Windows.Forms.Button();
            refundRequestAPIButton = new System.Windows.Forms.LinkLabel();
            refundRequestGoToFileButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            refundsTabControl.SuspendLayout();
            refundEligibleTab.SuspendLayout();
            refundReqeuestTab.SuspendLayout();
            SuspendLayout();
            // 
            // paymentIntentsControl1
            // 
            paymentIntentsControl1.Location = new System.Drawing.Point(760, 325);
            paymentIntentsControl1.Name = "paymentIntentsControl1";
            paymentIntentsControl1.Size = new System.Drawing.Size(8, 8);
            paymentIntentsControl1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 26);
            label5.TabIndex = 12;
            label5.Text = "Refunds";
            // 
            // refundsTabControl
            // 
            refundsTabControl.Controls.Add(refundEligibleTab);
            refundsTabControl.Controls.Add(refundReqeuestTab);
            refundsTabControl.Location = new System.Drawing.Point(100, 100);
            refundsTabControl.Name = "refundsTabControl";
            refundsTabControl.SelectedIndex = 0;
            refundsTabControl.Size = new System.Drawing.Size(750, 540);
            refundsTabControl.TabIndex = 13;
            // 
            // refundEligibleTab
            // 
            refundEligibleTab.Controls.Add(refundEligibleTree);
            refundEligibleTab.Controls.Add(label9);
            refundEligibleTab.Controls.Add(refundEligibleResponseText);
            refundEligibleTab.Controls.Add(label8);
            refundEligibleTab.Controls.Add(refundEligibleStatusTextBox);
            refundEligibleTab.Controls.Add(label7);
            refundEligibleTab.Controls.Add(refundEligibleClearButton);
            refundEligibleTab.Controls.Add(refundEligibleRunButton);
            refundEligibleTab.Controls.Add(refundEligibleAPIButton);
            refundEligibleTab.Controls.Add(refundEligibleGotToFileButton);
            refundEligibleTab.Controls.Add(label6);
            refundEligibleTab.Location = new System.Drawing.Point(4, 24);
            refundEligibleTab.Name = "refundEligibleTab";
            refundEligibleTab.Padding = new System.Windows.Forms.Padding(3);
            refundEligibleTab.Size = new System.Drawing.Size(742, 512);
            refundEligibleTab.TabIndex = 0;
            refundEligibleTab.Text = "Eligibility";
            refundEligibleTab.UseVisualStyleBackColor = true;
            // 
            // refundEligibleTree
            // 
            refundEligibleTree.Location = new System.Drawing.Point(405, 220);
            refundEligibleTree.Name = "refundEligibleTree";
            refundEligibleTree.Size = new System.Drawing.Size(315, 220);
            refundEligibleTree.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(400, 190);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 19);
            label9.TabIndex = 42;
            label9.Text = "Tree View";
            // 
            // refundEligibleResponseText
            // 
            refundEligibleResponseText.Location = new System.Drawing.Point(15, 220);
            refundEligibleResponseText.Margin = new System.Windows.Forms.Padding(2);
            refundEligibleResponseText.Multiline = true;
            refundEligibleResponseText.Name = "refundEligibleResponseText";
            refundEligibleResponseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            refundEligibleResponseText.Size = new System.Drawing.Size(340, 220);
            refundEligibleResponseText.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(15, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 19);
            label8.TabIndex = 40;
            label8.Text = "Raw JSON";
            // 
            // refundEligibleStatusTextBox
            // 
            refundEligibleStatusTextBox.Enabled = false;
            refundEligibleStatusTextBox.Location = new System.Drawing.Point(125, 160);
            refundEligibleStatusTextBox.Name = "refundEligibleStatusTextBox";
            refundEligibleStatusTextBox.Size = new System.Drawing.Size(75, 23);
            refundEligibleStatusTextBox.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(15, 160);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 19);
            label7.TabIndex = 38;
            label7.Text = "Response Code";
            // 
            // refundEligibleClearButton
            // 
            refundEligibleClearButton.AutoSize = true;
            refundEligibleClearButton.Location = new System.Drawing.Point(120, 90);
            refundEligibleClearButton.Margin = new System.Windows.Forms.Padding(4);
            refundEligibleClearButton.Name = "refundEligibleClearButton";
            refundEligibleClearButton.Size = new System.Drawing.Size(94, 26);
            refundEligibleClearButton.TabIndex = 37;
            refundEligibleClearButton.Text = "Clear";
            refundEligibleClearButton.UseVisualStyleBackColor = true;
            refundEligibleClearButton.Click += refundEligibleClearButton_Click;
            // 
            // refundEligibleRunButton
            // 
            refundEligibleRunButton.Location = new System.Drawing.Point(15, 90);
            refundEligibleRunButton.Name = "refundEligibleRunButton";
            refundEligibleRunButton.Size = new System.Drawing.Size(94, 26);
            refundEligibleRunButton.TabIndex = 36;
            refundEligibleRunButton.Text = "Run";
            refundEligibleRunButton.UseVisualStyleBackColor = true;
            refundEligibleRunButton.Click += refundEligibleRunButton_Click;
            // 
            // refundEligibleAPIButton
            // 
            refundEligibleAPIButton.AutoSize = true;
            refundEligibleAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            refundEligibleAPIButton.Location = new System.Drawing.Point(630, 20);
            refundEligibleAPIButton.Name = "refundEligibleAPIButton";
            refundEligibleAPIButton.Size = new System.Drawing.Size(89, 19);
            refundEligibleAPIButton.TabIndex = 34;
            refundEligibleAPIButton.TabStop = true;
            refundEligibleAPIButton.Text = "API Endpoint";
            refundEligibleAPIButton.LinkClicked += refundEligibleAPIButton_LinkClicked;
            // 
            // refundEligibleGotToFileButton
            // 
            refundEligibleGotToFileButton.Location = new System.Drawing.Point(390, 20);
            refundEligibleGotToFileButton.Name = "refundEligibleGotToFileButton";
            refundEligibleGotToFileButton.Size = new System.Drawing.Size(75, 23);
            refundEligibleGotToFileButton.TabIndex = 33;
            refundEligibleGotToFileButton.Text = "Go to File";
            refundEligibleGotToFileButton.UseVisualStyleBackColor = true;
            refundEligibleGotToFileButton.Click += refundEligibleGotToFileButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(322, 19);
            label6.TabIndex = 21;
            label6.Text = "Payload File:  Requests\\SecureRefundsEligibility.json";
            // 
            // refundReqeuestTab
            // 
            refundReqeuestTab.Controls.Add(refundRequestTree);
            refundReqeuestTab.Controls.Add(label4);
            refundReqeuestTab.Controls.Add(refundRequestResponseTextBox);
            refundReqeuestTab.Controls.Add(label3);
            refundReqeuestTab.Controls.Add(refundRequestStatusTextBox);
            refundReqeuestTab.Controls.Add(label2);
            refundReqeuestTab.Controls.Add(refundRequestClearButton);
            refundReqeuestTab.Controls.Add(refundRequestRunButton);
            refundReqeuestTab.Controls.Add(refundRequestAPIButton);
            refundReqeuestTab.Controls.Add(refundRequestGoToFileButton);
            refundReqeuestTab.Controls.Add(label1);
            refundReqeuestTab.Location = new System.Drawing.Point(4, 24);
            refundReqeuestTab.Name = "refundReqeuestTab";
            refundReqeuestTab.Padding = new System.Windows.Forms.Padding(3);
            refundReqeuestTab.Size = new System.Drawing.Size(742, 512);
            refundReqeuestTab.TabIndex = 1;
            refundReqeuestTab.Text = "Request";
            refundReqeuestTab.UseVisualStyleBackColor = true;
            // 
            // refundRequestTree
            // 
            refundRequestTree.Location = new System.Drawing.Point(405, 220);
            refundRequestTree.Name = "refundRequestTree";
            refundRequestTree.Size = new System.Drawing.Size(315, 220);
            refundRequestTree.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(400, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 19);
            label4.TabIndex = 43;
            label4.Text = "Tree View";
            // 
            // refundRequestResponseTextBox
            // 
            refundRequestResponseTextBox.Location = new System.Drawing.Point(15, 220);
            refundRequestResponseTextBox.Margin = new System.Windows.Forms.Padding(2);
            refundRequestResponseTextBox.Multiline = true;
            refundRequestResponseTextBox.Name = "refundRequestResponseTextBox";
            refundRequestResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            refundRequestResponseTextBox.Size = new System.Drawing.Size(340, 220);
            refundRequestResponseTextBox.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(15, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 19);
            label3.TabIndex = 41;
            label3.Text = "Raw JSON";
            // 
            // refundRequestStatusTextBox
            // 
            refundRequestStatusTextBox.Enabled = false;
            refundRequestStatusTextBox.Location = new System.Drawing.Point(125, 160);
            refundRequestStatusTextBox.Name = "refundRequestStatusTextBox";
            refundRequestStatusTextBox.Size = new System.Drawing.Size(75, 23);
            refundRequestStatusTextBox.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 19);
            label2.TabIndex = 39;
            label2.Text = "Response Code";
            // 
            // refundRequestClearButton
            // 
            refundRequestClearButton.AutoSize = true;
            refundRequestClearButton.Location = new System.Drawing.Point(120, 90);
            refundRequestClearButton.Margin = new System.Windows.Forms.Padding(4);
            refundRequestClearButton.Name = "refundRequestClearButton";
            refundRequestClearButton.Size = new System.Drawing.Size(94, 26);
            refundRequestClearButton.TabIndex = 38;
            refundRequestClearButton.Text = "Clear";
            refundRequestClearButton.UseVisualStyleBackColor = true;
            refundRequestClearButton.Click += refundRequestClearButton_Click;
            // 
            // refundRequestRunButton
            // 
            refundRequestRunButton.Location = new System.Drawing.Point(15, 90);
            refundRequestRunButton.Name = "refundRequestRunButton";
            refundRequestRunButton.Size = new System.Drawing.Size(94, 26);
            refundRequestRunButton.TabIndex = 37;
            refundRequestRunButton.Text = "Run";
            refundRequestRunButton.UseVisualStyleBackColor = true;
            refundRequestRunButton.Click += refundRequestRunButton_Click;
            // 
            // refundRequestAPIButton
            // 
            refundRequestAPIButton.AutoSize = true;
            refundRequestAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            refundRequestAPIButton.Location = new System.Drawing.Point(630, 20);
            refundRequestAPIButton.Name = "refundRequestAPIButton";
            refundRequestAPIButton.Size = new System.Drawing.Size(89, 19);
            refundRequestAPIButton.TabIndex = 35;
            refundRequestAPIButton.TabStop = true;
            refundRequestAPIButton.Text = "API Endpoint";
            refundRequestAPIButton.LinkClicked += refundRequestAPIButton_LinkClicked;
            // 
            // refundRequestGoToFileButton
            // 
            refundRequestGoToFileButton.Location = new System.Drawing.Point(390, 20);
            refundRequestGoToFileButton.Name = "refundRequestGoToFileButton";
            refundRequestGoToFileButton.Size = new System.Drawing.Size(75, 23);
            refundRequestGoToFileButton.TabIndex = 34;
            refundRequestGoToFileButton.Text = "Go to File";
            refundRequestGoToFileButton.UseVisualStyleBackColor = true;
            refundRequestGoToFileButton.Click += refundRequestGoToFileButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(15, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(312, 19);
            label1.TabIndex = 22;
            label1.Text = "Payload File:  Requests\\SecureRefundRequest.json";
            // 
            // RefundsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(refundsTabControl);
            Controls.Add(label5);
            Controls.Add(paymentIntentsControl1);
            Location = new System.Drawing.Point(130, 10);
            Name = "RefundsControl";
            Size = new System.Drawing.Size(980, 591);
            refundsTabControl.ResumeLayout(false);
            refundEligibleTab.ResumeLayout(false);
            refundEligibleTab.PerformLayout();
            refundReqeuestTab.ResumeLayout(false);
            refundReqeuestTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PaymentIntentsControl paymentIntentsControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl refundsTabControl;
        private System.Windows.Forms.TabPage refundEligibleTab;
        private System.Windows.Forms.TabPage refundReqeuestTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refundEligibleGotToFileButton;
        private System.Windows.Forms.LinkLabel refundEligibleAPIButton;
        private System.Windows.Forms.Button refundEligibleRunButton;
        private System.Windows.Forms.Button refundEligibleClearButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox refundEligibleStatusTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox refundEligibleResponseText;
        private System.Windows.Forms.TreeView refundEligibleTree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refundRequestGoToFileButton;
        private System.Windows.Forms.LinkLabel refundRequestAPIButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refundRequestClearButton;
        private System.Windows.Forms.Button refundRequestRunButton;
        private System.Windows.Forms.TreeView refundRequestTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox refundRequestResponseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox refundRequestStatusTextBox;
    }
}
