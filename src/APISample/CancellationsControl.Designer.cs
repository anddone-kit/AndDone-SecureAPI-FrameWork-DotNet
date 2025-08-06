namespace APISample
{
    partial class CancellationsControl
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
            cancellationsTabControl = new System.Windows.Forms.TabControl();
            cancelPaymentTab = new System.Windows.Forms.TabPage();
            cancelTreeView = new System.Windows.Forms.TreeView();
            label1 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            payCreateGoToFileButton = new System.Windows.Forms.Button();
            cancelDependLabel = new System.Windows.Forms.Label();
            cancelPaymentResultsTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cancelResponseStatusBox = new System.Windows.Forms.TextBox();
            createPaymentRespLabel = new System.Windows.Forms.Label();
            cancelResetButton = new System.Windows.Forms.Button();
            cancellationsCancelButton = new System.Windows.Forms.Button();
            createPaymentLabel = new System.Windows.Forms.Label();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            cancellationsTabControl.SuspendLayout();
            cancelPaymentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(143, 26);
            label5.TabIndex = 11;
            label5.Text = "Cancellations";
            // 
            // cancellationsTabControl
            // 
            cancellationsTabControl.Controls.Add(cancelPaymentTab);
            cancellationsTabControl.Location = new System.Drawing.Point(100, 100);
            cancellationsTabControl.Name = "cancellationsTabControl";
            cancellationsTabControl.SelectedIndex = 0;
            cancellationsTabControl.Size = new System.Drawing.Size(750, 540);
            cancellationsTabControl.TabIndex = 12;
            // 
            // cancelPaymentTab
            // 
            cancelPaymentTab.Controls.Add(cancelTreeView);
            cancelPaymentTab.Controls.Add(label1);
            cancelPaymentTab.Controls.Add(linkLabel1);
            cancelPaymentTab.Controls.Add(payCreateGoToFileButton);
            cancelPaymentTab.Controls.Add(cancelDependLabel);
            cancelPaymentTab.Controls.Add(cancelPaymentResultsTextBox);
            cancelPaymentTab.Controls.Add(label2);
            cancelPaymentTab.Controls.Add(cancelResponseStatusBox);
            cancelPaymentTab.Controls.Add(createPaymentRespLabel);
            cancelPaymentTab.Controls.Add(cancelResetButton);
            cancelPaymentTab.Controls.Add(cancellationsCancelButton);
            cancelPaymentTab.Controls.Add(createPaymentLabel);
            cancelPaymentTab.Location = new System.Drawing.Point(4, 24);
            cancelPaymentTab.Name = "cancelPaymentTab";
            cancelPaymentTab.Padding = new System.Windows.Forms.Padding(3);
            cancelPaymentTab.Size = new System.Drawing.Size(742, 512);
            cancelPaymentTab.TabIndex = 0;
            cancelPaymentTab.Text = "Cancel";
            cancelPaymentTab.UseVisualStyleBackColor = true;
            // 
            // cancelTreeView
            // 
            cancelTreeView.Location = new System.Drawing.Point(405, 220);
            cancelTreeView.Name = "cancelTreeView";
            cancelTreeView.Size = new System.Drawing.Size(315, 220);
            cancelTreeView.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(400, 190);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 19);
            label1.TabIndex = 35;
            label1.Text = "Tree View";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel1.Location = new System.Drawing.Point(630, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(89, 19);
            linkLabel1.TabIndex = 34;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "API Endpoint";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // payCreateGoToFileButton
            // 
            payCreateGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payCreateGoToFileButton.Name = "payCreateGoToFileButton";
            payCreateGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payCreateGoToFileButton.TabIndex = 33;
            payCreateGoToFileButton.Text = "Go to File";
            payCreateGoToFileButton.UseVisualStyleBackColor = true;
            payCreateGoToFileButton.Click += payCreateGoToFileButton_Click;
            // 
            // cancelDependLabel
            // 
            cancelDependLabel.AutoSize = true;
            cancelDependLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            cancelDependLabel.Location = new System.Drawing.Point(15, 50);
            cancelDependLabel.Name = "cancelDependLabel";
            cancelDependLabel.Size = new System.Drawing.Size(45, 19);
            cancelDependLabel.TabIndex = 30;
            cancelDependLabel.Text = "label2";
            // 
            // cancelPaymentResultsTextBox
            // 
            cancelPaymentResultsTextBox.Location = new System.Drawing.Point(15, 220);
            cancelPaymentResultsTextBox.Margin = new System.Windows.Forms.Padding(2);
            cancelPaymentResultsTextBox.Multiline = true;
            cancelPaymentResultsTextBox.Name = "cancelPaymentResultsTextBox";
            cancelPaymentResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            cancelPaymentResultsTextBox.Size = new System.Drawing.Size(340, 220);
            cancelPaymentResultsTextBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 19);
            label2.TabIndex = 25;
            label2.Text = "Raw JSON";
            // 
            // cancelResponseStatusBox
            // 
            cancelResponseStatusBox.Enabled = false;
            cancelResponseStatusBox.Location = new System.Drawing.Point(125, 160);
            cancelResponseStatusBox.Name = "cancelResponseStatusBox";
            cancelResponseStatusBox.Size = new System.Drawing.Size(75, 23);
            cancelResponseStatusBox.TabIndex = 24;
            // 
            // createPaymentRespLabel
            // 
            createPaymentRespLabel.AutoSize = true;
            createPaymentRespLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            createPaymentRespLabel.Location = new System.Drawing.Point(15, 160);
            createPaymentRespLabel.Name = "createPaymentRespLabel";
            createPaymentRespLabel.Size = new System.Drawing.Size(103, 19);
            createPaymentRespLabel.TabIndex = 23;
            createPaymentRespLabel.Text = "Response Code";
            // 
            // cancelResetButton
            // 
            cancelResetButton.Location = new System.Drawing.Point(120, 90);
            cancelResetButton.Margin = new System.Windows.Forms.Padding(4);
            cancelResetButton.Name = "cancelResetButton";
            cancelResetButton.Size = new System.Drawing.Size(94, 26);
            cancelResetButton.TabIndex = 22;
            cancelResetButton.Text = "Clear";
            cancelResetButton.UseVisualStyleBackColor = true;
            cancelResetButton.Click += cancelResetButton_Click;
            // 
            // cancellationsCancelButton
            // 
            cancellationsCancelButton.Location = new System.Drawing.Point(15, 90);
            cancellationsCancelButton.Margin = new System.Windows.Forms.Padding(4);
            cancellationsCancelButton.Name = "cancellationsCancelButton";
            cancellationsCancelButton.Size = new System.Drawing.Size(94, 26);
            cancellationsCancelButton.TabIndex = 19;
            cancellationsCancelButton.Text = "Run";
            cancellationsCancelButton.UseVisualStyleBackColor = true;
            cancellationsCancelButton.Click += cancellationsCancelButton_Click;
            // 
            // createPaymentLabel
            // 
            createPaymentLabel.AutoSize = true;
            createPaymentLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            createPaymentLabel.Location = new System.Drawing.Point(15, 20);
            createPaymentLabel.Name = "createPaymentLabel";
            createPaymentLabel.Size = new System.Drawing.Size(314, 19);
            createPaymentLabel.TabIndex = 18;
            createPaymentLabel.Text = "Payload File:  Requests\\CancellationsPayment.json";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CancellationsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cancellationsTabControl);
            Controls.Add(label5);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CancellationsControl";
            Size = new System.Drawing.Size(910, 650);
            Load += CancellationsControl_Load;
            cancellationsTabControl.ResumeLayout(false);
            cancelPaymentTab.ResumeLayout(false);
            cancelPaymentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl cancellationsTabControl;
        private System.Windows.Forms.TabPage cancelPaymentTab;
        private System.Windows.Forms.Label createPaymentLabel;
        private System.Windows.Forms.Button cancellationsCancelButton;
        private System.Windows.Forms.Button cancelResetButton;
        private System.Windows.Forms.Label createPaymentRespLabel;
        private System.Windows.Forms.TextBox cancelResponseStatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cancelPaymentResultsTextBox;
        private System.Windows.Forms.Label cancelDependLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button payCreateGoToFileButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TreeView cancelTreeView;
        private System.Windows.Forms.Label label1;
    }
}
