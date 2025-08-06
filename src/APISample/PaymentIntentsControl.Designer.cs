namespace APISample
{
    partial class PaymentIntentsControl
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
            tabControl1 = new System.Windows.Forms.TabControl();
            payIntentCreateTab = new System.Windows.Forms.TabPage();
            payIntentCreateTree = new System.Windows.Forms.TreeView();
            label8 = new System.Windows.Forms.Label();
            payIntentCreateResponseTextBox = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            payIntentCreateStatusBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            payIntentCreateClearButton = new System.Windows.Forms.Button();
            payIntentCreateRunButton = new System.Windows.Forms.Button();
            payIntentCreateAPIButton = new System.Windows.Forms.LinkLabel();
            payIntentCreateGoToFileButton = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            payIntentExpTab = new System.Windows.Forms.TabPage();
            label2 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            payIntentExpTree = new System.Windows.Forms.TreeView();
            payIntentExpResponseText = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            payIntentExpStatusTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            payIntentExpClearButton = new System.Windows.Forms.Button();
            payIntentExpRunButton = new System.Windows.Forms.Button();
            payIntentExpTokenTextBox = new System.Windows.Forms.TextBox();
            payIntentExpAPIButton = new System.Windows.Forms.LinkLabel();
            payLinkUpdateDependLabel = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            payIntentCreateTab.SuspendLayout();
            payIntentExpTab.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(170, 26);
            label5.TabIndex = 12;
            label5.Text = "Payment Intents";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(payIntentCreateTab);
            tabControl1.Controls.Add(payIntentExpTab);
            tabControl1.Location = new System.Drawing.Point(100, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(750, 540);
            tabControl1.TabIndex = 13;
            // 
            // payIntentCreateTab
            // 
            payIntentCreateTab.Controls.Add(payIntentCreateTree);
            payIntentCreateTab.Controls.Add(label8);
            payIntentCreateTab.Controls.Add(payIntentCreateResponseTextBox);
            payIntentCreateTab.Controls.Add(label15);
            payIntentCreateTab.Controls.Add(payIntentCreateStatusBox);
            payIntentCreateTab.Controls.Add(label14);
            payIntentCreateTab.Controls.Add(payIntentCreateClearButton);
            payIntentCreateTab.Controls.Add(payIntentCreateRunButton);
            payIntentCreateTab.Controls.Add(payIntentCreateAPIButton);
            payIntentCreateTab.Controls.Add(payIntentCreateGoToFileButton);
            payIntentCreateTab.Controls.Add(label13);
            payIntentCreateTab.Location = new System.Drawing.Point(4, 24);
            payIntentCreateTab.Name = "payIntentCreateTab";
            payIntentCreateTab.Padding = new System.Windows.Forms.Padding(3);
            payIntentCreateTab.Size = new System.Drawing.Size(742, 512);
            payIntentCreateTab.TabIndex = 0;
            payIntentCreateTab.Text = "Create";
            payIntentCreateTab.UseVisualStyleBackColor = true;
            // 
            // payIntentCreateTree
            // 
            payIntentCreateTree.Location = new System.Drawing.Point(405, 220);
            payIntentCreateTree.Name = "payIntentCreateTree";
            payIntentCreateTree.Size = new System.Drawing.Size(315, 220);
            payIntentCreateTree.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(400, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 19);
            label8.TabIndex = 49;
            label8.Text = "Tree View";
            // 
            // payIntentCreateResponseTextBox
            // 
            payIntentCreateResponseTextBox.Location = new System.Drawing.Point(15, 220);
            payIntentCreateResponseTextBox.Multiline = true;
            payIntentCreateResponseTextBox.Name = "payIntentCreateResponseTextBox";
            payIntentCreateResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payIntentCreateResponseTextBox.Size = new System.Drawing.Size(340, 220);
            payIntentCreateResponseTextBox.TabIndex = 48;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            label15.Location = new System.Drawing.Point(15, 190);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(104, 19);
            label15.TabIndex = 47;
            label15.Text = "Response JSON";
            // 
            // payIntentCreateStatusBox
            // 
            payIntentCreateStatusBox.Enabled = false;
            payIntentCreateStatusBox.Location = new System.Drawing.Point(125, 160);
            payIntentCreateStatusBox.Name = "payIntentCreateStatusBox";
            payIntentCreateStatusBox.Size = new System.Drawing.Size(75, 23);
            payIntentCreateStatusBox.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            label14.Location = new System.Drawing.Point(15, 160);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(103, 19);
            label14.TabIndex = 45;
            label14.Text = "Response Code";
            // 
            // payIntentCreateClearButton
            // 
            payIntentCreateClearButton.Location = new System.Drawing.Point(120, 90);
            payIntentCreateClearButton.Margin = new System.Windows.Forms.Padding(4);
            payIntentCreateClearButton.Name = "payIntentCreateClearButton";
            payIntentCreateClearButton.Size = new System.Drawing.Size(94, 26);
            payIntentCreateClearButton.TabIndex = 44;
            payIntentCreateClearButton.Text = "Clear";
            payIntentCreateClearButton.UseVisualStyleBackColor = true;
            payIntentCreateClearButton.Click += payIntentCreateClearButton_Click;
            // 
            // payIntentCreateRunButton
            // 
            payIntentCreateRunButton.Location = new System.Drawing.Point(15, 90);
            payIntentCreateRunButton.Name = "payIntentCreateRunButton";
            payIntentCreateRunButton.Size = new System.Drawing.Size(94, 26);
            payIntentCreateRunButton.TabIndex = 43;
            payIntentCreateRunButton.Text = "Run";
            payIntentCreateRunButton.UseVisualStyleBackColor = true;
            payIntentCreateRunButton.Click += payIntentCreateRunButton_Click;
            // 
            // payIntentCreateAPIButton
            // 
            payIntentCreateAPIButton.AutoSize = true;
            payIntentCreateAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            payIntentCreateAPIButton.Location = new System.Drawing.Point(585, 20);
            payIntentCreateAPIButton.Name = "payIntentCreateAPIButton";
            payIntentCreateAPIButton.Size = new System.Drawing.Size(89, 19);
            payIntentCreateAPIButton.TabIndex = 42;
            payIntentCreateAPIButton.TabStop = true;
            payIntentCreateAPIButton.Text = "API Endpoint";
            payIntentCreateAPIButton.LinkClicked += payIntentCreateAPIButton_LinkClicked;
            // 
            // payIntentCreateGoToFileButton
            // 
            payIntentCreateGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payIntentCreateGoToFileButton.Name = "payIntentCreateGoToFileButton";
            payIntentCreateGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payIntentCreateGoToFileButton.TabIndex = 38;
            payIntentCreateGoToFileButton.Text = "Go to File";
            payIntentCreateGoToFileButton.UseVisualStyleBackColor = true;
            payIntentCreateGoToFileButton.Click += payIntentCreateGoToFileButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            label13.Location = new System.Drawing.Point(15, 20);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(353, 19);
            label13.TabIndex = 3;
            label13.Text = "Payload File: Requests\\SecurePaymentIntentsCreate.json";
            // 
            // payIntentExpTab
            // 
            payIntentExpTab.Controls.Add(label2);
            payIntentExpTab.Controls.Add(label12);
            payIntentExpTab.Controls.Add(payIntentExpTree);
            payIntentExpTab.Controls.Add(payIntentExpResponseText);
            payIntentExpTab.Controls.Add(label11);
            payIntentExpTab.Controls.Add(payIntentExpStatusTextBox);
            payIntentExpTab.Controls.Add(label1);
            payIntentExpTab.Controls.Add(payIntentExpClearButton);
            payIntentExpTab.Controls.Add(payIntentExpRunButton);
            payIntentExpTab.Controls.Add(payIntentExpTokenTextBox);
            payIntentExpTab.Controls.Add(payIntentExpAPIButton);
            payIntentExpTab.Controls.Add(payLinkUpdateDependLabel);
            payIntentExpTab.Location = new System.Drawing.Point(4, 24);
            payIntentExpTab.Name = "payIntentExpTab";
            payIntentExpTab.Padding = new System.Windows.Forms.Padding(3);
            payIntentExpTab.Size = new System.Drawing.Size(742, 512);
            payIntentExpTab.TabIndex = 1;
            payIntentExpTab.Text = "Expiration";
            payIntentExpTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(182, 19);
            label2.TabIndex = 57;
            label2.Text = "Payload File: No file required";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            label12.Location = new System.Drawing.Point(400, 190);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(67, 19);
            label12.TabIndex = 56;
            label12.Text = "Tree View";
            // 
            // payIntentExpTree
            // 
            payIntentExpTree.Location = new System.Drawing.Point(405, 220);
            payIntentExpTree.Name = "payIntentExpTree";
            payIntentExpTree.Size = new System.Drawing.Size(315, 220);
            payIntentExpTree.TabIndex = 55;
            // 
            // payIntentExpResponseText
            // 
            payIntentExpResponseText.Location = new System.Drawing.Point(15, 220);
            payIntentExpResponseText.Multiline = true;
            payIntentExpResponseText.Name = "payIntentExpResponseText";
            payIntentExpResponseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payIntentExpResponseText.Size = new System.Drawing.Size(340, 220);
            payIntentExpResponseText.TabIndex = 54;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            label11.Location = new System.Drawing.Point(15, 190);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(104, 19);
            label11.TabIndex = 53;
            label11.Text = "Response JSON";
            // 
            // payIntentExpStatusTextBox
            // 
            payIntentExpStatusTextBox.Enabled = false;
            payIntentExpStatusTextBox.Location = new System.Drawing.Point(125, 160);
            payIntentExpStatusTextBox.Name = "payIntentExpStatusTextBox";
            payIntentExpStatusTextBox.Size = new System.Drawing.Size(75, 23);
            payIntentExpStatusTextBox.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(15, 160);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 19);
            label1.TabIndex = 51;
            label1.Text = "Response Code";
            // 
            // payIntentExpClearButton
            // 
            payIntentExpClearButton.Location = new System.Drawing.Point(120, 90);
            payIntentExpClearButton.Margin = new System.Windows.Forms.Padding(4);
            payIntentExpClearButton.Name = "payIntentExpClearButton";
            payIntentExpClearButton.Size = new System.Drawing.Size(94, 26);
            payIntentExpClearButton.TabIndex = 50;
            payIntentExpClearButton.Text = "Clear";
            payIntentExpClearButton.UseVisualStyleBackColor = true;
            payIntentExpClearButton.Click += payIntentExpClearButton_Click;
            // 
            // payIntentExpRunButton
            // 
            payIntentExpRunButton.Location = new System.Drawing.Point(15, 90);
            payIntentExpRunButton.Name = "payIntentExpRunButton";
            payIntentExpRunButton.Size = new System.Drawing.Size(94, 26);
            payIntentExpRunButton.TabIndex = 49;
            payIntentExpRunButton.Text = "Run";
            payIntentExpRunButton.UseVisualStyleBackColor = true;
            payIntentExpRunButton.Click += payIntentExpRunButton_Click;
            // 
            // payIntentExpTokenTextBox
            // 
            payIntentExpTokenTextBox.Location = new System.Drawing.Point(475, 50);
            payIntentExpTokenTextBox.Name = "payIntentExpTokenTextBox";
            payIntentExpTokenTextBox.Size = new System.Drawing.Size(120, 23);
            payIntentExpTokenTextBox.TabIndex = 48;
            // 
            // payIntentExpAPIButton
            // 
            payIntentExpAPIButton.AutoSize = true;
            payIntentExpAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            payIntentExpAPIButton.Location = new System.Drawing.Point(630, 20);
            payIntentExpAPIButton.Name = "payIntentExpAPIButton";
            payIntentExpAPIButton.Size = new System.Drawing.Size(89, 19);
            payIntentExpAPIButton.TabIndex = 47;
            payIntentExpAPIButton.TabStop = true;
            payIntentExpAPIButton.Text = "API Endpoint";
            payIntentExpAPIButton.LinkClicked += payIntentExpAPIButton_LinkClicked;
            // 
            // payLinkUpdateDependLabel
            // 
            payLinkUpdateDependLabel.AutoSize = true;
            payLinkUpdateDependLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            payLinkUpdateDependLabel.Location = new System.Drawing.Point(15, 50);
            payLinkUpdateDependLabel.Name = "payLinkUpdateDependLabel";
            payLinkUpdateDependLabel.Size = new System.Drawing.Size(442, 19);
            payLinkUpdateDependLabel.TabIndex = 46;
            payLinkUpdateDependLabel.Text = "Dependency: Enter the 'paymentToken' from Payment Intents->Create";
            // 
            // PaymentIntentsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(label5);
            Location = new System.Drawing.Point(130, 10);
            Name = "PaymentIntentsControl";
            Size = new System.Drawing.Size(980, 591);
            tabControl1.ResumeLayout(false);
            payIntentCreateTab.ResumeLayout(false);
            payIntentCreateTab.PerformLayout();
            payIntentExpTab.ResumeLayout(false);
            payIntentExpTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage payIntentCreateTab;
        private System.Windows.Forms.TabPage payIntentExpTab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button payIntentCreateGoToFileButton;
        private System.Windows.Forms.LinkLabel payIntentCreateAPIButton;
        private System.Windows.Forms.Button payIntentCreateRunButton;
        private System.Windows.Forms.Button payIntentCreateClearButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox payIntentCreateStatusBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox payIntentCreateResponseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView payIntentCreateTree;
        private System.Windows.Forms.Label payLinkUpdateDependLabel;
        private System.Windows.Forms.LinkLabel payIntentExpAPIButton;
        private System.Windows.Forms.TextBox payIntentExpTokenTextBox;
        private System.Windows.Forms.Button payIntentExpRunButton;
        private System.Windows.Forms.Button payIntentExpClearButton;
        private System.Windows.Forms.TextBox payIntentExpStatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox payIntentExpResponseText;
        private System.Windows.Forms.TreeView payIntentExpTree;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}
