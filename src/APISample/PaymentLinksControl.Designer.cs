namespace APISample
{
    partial class PaymentLinksControl
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
            panel1 = new System.Windows.Forms.Panel();
            paymentLinksTabControl = new System.Windows.Forms.TabControl();
            paymentLinksCreateTab = new System.Windows.Forms.TabPage();
            paymentLinkCreateResetButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            payCreateGoToFileButton = new System.Windows.Forms.Button();
            paymentLinksCreateResponseTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            paymentLinksCreateStatusTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            createPaymentLinksTree = new System.Windows.Forms.TreeView();
            paymentLinksCreateButton = new System.Windows.Forms.Button();
            paymentLinksCreateLabel = new System.Windows.Forms.Label();
            paymentLinksDetailsTab = new System.Windows.Forms.TabPage();
            payLinkDetailTreeView = new System.Windows.Forms.TreeView();
            label8 = new System.Windows.Forms.Label();
            payLinkDetailsResponseTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            payLinkDetailStatusBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            payLinkDetailDependLable = new System.Windows.Forms.Label();
            payLinkDetailClearButton = new System.Windows.Forms.Button();
            payLinkDetailRunButton = new System.Windows.Forms.Button();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            payLinkDetailGoToFileButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            paymentLinksUpdateTab = new System.Windows.Forms.TabPage();
            payLinkUpdateIdTextBox = new System.Windows.Forms.TextBox();
            payLinkUpdateDependLabel = new System.Windows.Forms.Label();
            payLinkUpdateTree = new System.Windows.Forms.TreeView();
            label12 = new System.Windows.Forms.Label();
            payLinkUpdateResponseTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            payLinkUpdateStatusBox = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            payLinkUpdateClearButton = new System.Windows.Forms.Button();
            payLinkUpdateRunButton = new System.Windows.Forms.Button();
            payLinkUpdateAPIButton = new System.Windows.Forms.LinkLabel();
            payLinkUpdateGoToFileButton = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            paymentLinksExpTab = new System.Windows.Forms.TabPage();
            payLinkExpResponseTextBox = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            payLinkExpStatusBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            payLinkExpClearButton = new System.Windows.Forms.Button();
            payLinkExpRunButton = new System.Windows.Forms.Button();
            linkLabel3 = new System.Windows.Forms.LinkLabel();
            payLinkExpDependLabel = new System.Windows.Forms.Label();
            payLinkExpGotToFileButton = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            payLinkExpTree = new System.Windows.Forms.TreeView();
            panel1.SuspendLayout();
            paymentLinksTabControl.SuspendLayout();
            paymentLinksCreateTab.SuspendLayout();
            paymentLinksDetailsTab.SuspendLayout();
            paymentLinksUpdateTab.SuspendLayout();
            paymentLinksExpTab.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(paymentLinksTabControl);
            panel1.Controls.Add(label5);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(980, 591);
            panel1.TabIndex = 0;
            // 
            // paymentLinksTabControl
            // 
            paymentLinksTabControl.Controls.Add(paymentLinksCreateTab);
            paymentLinksTabControl.Controls.Add(paymentLinksDetailsTab);
            paymentLinksTabControl.Controls.Add(paymentLinksUpdateTab);
            paymentLinksTabControl.Controls.Add(paymentLinksExpTab);
            paymentLinksTabControl.Location = new System.Drawing.Point(100, 100);
            paymentLinksTabControl.Name = "paymentLinksTabControl";
            paymentLinksTabControl.SelectedIndex = 0;
            paymentLinksTabControl.Size = new System.Drawing.Size(750, 540);
            paymentLinksTabControl.TabIndex = 13;
            // 
            // paymentLinksCreateTab
            // 
            paymentLinksCreateTab.Controls.Add(paymentLinkCreateResetButton);
            paymentLinksCreateTab.Controls.Add(label3);
            paymentLinksCreateTab.Controls.Add(linkLabel1);
            paymentLinksCreateTab.Controls.Add(payCreateGoToFileButton);
            paymentLinksCreateTab.Controls.Add(paymentLinksCreateResponseTextBox);
            paymentLinksCreateTab.Controls.Add(label2);
            paymentLinksCreateTab.Controls.Add(paymentLinksCreateStatusTextBox);
            paymentLinksCreateTab.Controls.Add(label1);
            paymentLinksCreateTab.Controls.Add(createPaymentLinksTree);
            paymentLinksCreateTab.Controls.Add(paymentLinksCreateButton);
            paymentLinksCreateTab.Controls.Add(paymentLinksCreateLabel);
            paymentLinksCreateTab.Location = new System.Drawing.Point(4, 24);
            paymentLinksCreateTab.Name = "paymentLinksCreateTab";
            paymentLinksCreateTab.Padding = new System.Windows.Forms.Padding(3);
            paymentLinksCreateTab.Size = new System.Drawing.Size(742, 512);
            paymentLinksCreateTab.TabIndex = 0;
            paymentLinksCreateTab.Text = "Create";
            paymentLinksCreateTab.UseVisualStyleBackColor = true;
            // 
            // paymentLinkCreateResetButton
            // 
            paymentLinkCreateResetButton.Location = new System.Drawing.Point(120, 90);
            paymentLinkCreateResetButton.Margin = new System.Windows.Forms.Padding(4);
            paymentLinkCreateResetButton.Name = "paymentLinkCreateResetButton";
            paymentLinkCreateResetButton.Size = new System.Drawing.Size(94, 26);
            paymentLinkCreateResetButton.TabIndex = 37;
            paymentLinkCreateResetButton.Text = "Clear";
            paymentLinkCreateResetButton.UseVisualStyleBackColor = true;
            paymentLinkCreateResetButton.Click += paymentLinkCreateResetButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(400, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 19);
            label3.TabIndex = 36;
            label3.Text = "Tree View";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel1.Location = new System.Drawing.Point(630, 20);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(89, 19);
            linkLabel1.TabIndex = 35;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "API Endpoint";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // payCreateGoToFileButton
            // 
            payCreateGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payCreateGoToFileButton.Name = "payCreateGoToFileButton";
            payCreateGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payCreateGoToFileButton.TabIndex = 34;
            payCreateGoToFileButton.Text = "Go to File";
            payCreateGoToFileButton.UseVisualStyleBackColor = true;
            payCreateGoToFileButton.Click += payCreateGoToFileButton_Click;
            // 
            // paymentLinksCreateResponseTextBox
            // 
            paymentLinksCreateResponseTextBox.Location = new System.Drawing.Point(15, 220);
            paymentLinksCreateResponseTextBox.Multiline = true;
            paymentLinksCreateResponseTextBox.Name = "paymentLinksCreateResponseTextBox";
            paymentLinksCreateResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            paymentLinksCreateResponseTextBox.Size = new System.Drawing.Size(340, 220);
            paymentLinksCreateResponseTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(15, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 19);
            label2.TabIndex = 6;
            label2.Text = "Response JSON";
            // 
            // paymentLinksCreateStatusTextBox
            // 
            paymentLinksCreateStatusTextBox.Enabled = false;
            paymentLinksCreateStatusTextBox.Location = new System.Drawing.Point(125, 160);
            paymentLinksCreateStatusTextBox.Name = "paymentLinksCreateStatusTextBox";
            paymentLinksCreateStatusTextBox.Size = new System.Drawing.Size(75, 23);
            paymentLinksCreateStatusTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(15, 160);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 19);
            label1.TabIndex = 4;
            label1.Text = "Response Code";
            // 
            // createPaymentLinksTree
            // 
            createPaymentLinksTree.Location = new System.Drawing.Point(405, 220);
            createPaymentLinksTree.Name = "createPaymentLinksTree";
            createPaymentLinksTree.Size = new System.Drawing.Size(315, 220);
            createPaymentLinksTree.TabIndex = 2;
            // 
            // paymentLinksCreateButton
            // 
            paymentLinksCreateButton.Location = new System.Drawing.Point(15, 90);
            paymentLinksCreateButton.Name = "paymentLinksCreateButton";
            paymentLinksCreateButton.Size = new System.Drawing.Size(94, 26);
            paymentLinksCreateButton.TabIndex = 1;
            paymentLinksCreateButton.Text = "Run";
            paymentLinksCreateButton.UseVisualStyleBackColor = true;
            paymentLinksCreateButton.Click += paymentLinksCreateButton_Click;
            // 
            // paymentLinksCreateLabel
            // 
            paymentLinksCreateLabel.AutoSize = true;
            paymentLinksCreateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            paymentLinksCreateLabel.Location = new System.Drawing.Point(15, 20);
            paymentLinksCreateLabel.Name = "paymentLinksCreateLabel";
            paymentLinksCreateLabel.Size = new System.Drawing.Size(335, 19);
            paymentLinksCreateLabel.TabIndex = 0;
            paymentLinksCreateLabel.Text = "Payload File: Requests\\SecurePaymentLinkCreate.json";
            // 
            // paymentLinksDetailsTab
            // 
            paymentLinksDetailsTab.Controls.Add(payLinkDetailTreeView);
            paymentLinksDetailsTab.Controls.Add(label8);
            paymentLinksDetailsTab.Controls.Add(payLinkDetailsResponseTextBox);
            paymentLinksDetailsTab.Controls.Add(label7);
            paymentLinksDetailsTab.Controls.Add(payLinkDetailStatusBox);
            paymentLinksDetailsTab.Controls.Add(label6);
            paymentLinksDetailsTab.Controls.Add(payLinkDetailDependLable);
            paymentLinksDetailsTab.Controls.Add(payLinkDetailClearButton);
            paymentLinksDetailsTab.Controls.Add(payLinkDetailRunButton);
            paymentLinksDetailsTab.Controls.Add(linkLabel2);
            paymentLinksDetailsTab.Controls.Add(payLinkDetailGoToFileButton);
            paymentLinksDetailsTab.Controls.Add(label4);
            paymentLinksDetailsTab.Location = new System.Drawing.Point(4, 24);
            paymentLinksDetailsTab.Name = "paymentLinksDetailsTab";
            paymentLinksDetailsTab.Size = new System.Drawing.Size(742, 512);
            paymentLinksDetailsTab.TabIndex = 2;
            paymentLinksDetailsTab.Text = "Details";
            paymentLinksDetailsTab.UseVisualStyleBackColor = true;
            // 
            // payLinkDetailTreeView
            // 
            payLinkDetailTreeView.Location = new System.Drawing.Point(405, 220);
            payLinkDetailTreeView.Name = "payLinkDetailTreeView";
            payLinkDetailTreeView.Size = new System.Drawing.Size(315, 220);
            payLinkDetailTreeView.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(400, 190);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 19);
            label8.TabIndex = 44;
            label8.Text = "Tree View";
            // 
            // payLinkDetailsResponseTextBox
            // 
            payLinkDetailsResponseTextBox.Location = new System.Drawing.Point(15, 220);
            payLinkDetailsResponseTextBox.Multiline = true;
            payLinkDetailsResponseTextBox.Name = "payLinkDetailsResponseTextBox";
            payLinkDetailsResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payLinkDetailsResponseTextBox.Size = new System.Drawing.Size(340, 220);
            payLinkDetailsResponseTextBox.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(15, 190);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(104, 19);
            label7.TabIndex = 42;
            label7.Text = "Response JSON";
            // 
            // payLinkDetailStatusBox
            // 
            payLinkDetailStatusBox.Enabled = false;
            payLinkDetailStatusBox.Location = new System.Drawing.Point(125, 160);
            payLinkDetailStatusBox.Name = "payLinkDetailStatusBox";
            payLinkDetailStatusBox.Size = new System.Drawing.Size(75, 23);
            payLinkDetailStatusBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            label6.Location = new System.Drawing.Point(15, 160);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 19);
            label6.TabIndex = 40;
            label6.Text = "Response Code";
            // 
            // payLinkDetailDependLable
            // 
            payLinkDetailDependLable.AutoSize = true;
            payLinkDetailDependLable.Font = new System.Drawing.Font("Segoe UI", 10F);
            payLinkDetailDependLable.Location = new System.Drawing.Point(15, 50);
            payLinkDetailDependLable.Name = "payLinkDetailDependLable";
            payLinkDetailDependLable.Size = new System.Drawing.Size(45, 19);
            payLinkDetailDependLable.TabIndex = 39;
            payLinkDetailDependLable.Text = "label6";
            // 
            // payLinkDetailClearButton
            // 
            payLinkDetailClearButton.Location = new System.Drawing.Point(120, 90);
            payLinkDetailClearButton.Margin = new System.Windows.Forms.Padding(4);
            payLinkDetailClearButton.Name = "payLinkDetailClearButton";
            payLinkDetailClearButton.Size = new System.Drawing.Size(94, 26);
            payLinkDetailClearButton.TabIndex = 38;
            payLinkDetailClearButton.Text = "Clear";
            payLinkDetailClearButton.UseVisualStyleBackColor = true;
            payLinkDetailClearButton.Click += payLinkDetailClearButton_Click;
            // 
            // payLinkDetailRunButton
            // 
            payLinkDetailRunButton.Location = new System.Drawing.Point(15, 90);
            payLinkDetailRunButton.Name = "payLinkDetailRunButton";
            payLinkDetailRunButton.Size = new System.Drawing.Size(94, 26);
            payLinkDetailRunButton.TabIndex = 37;
            payLinkDetailRunButton.Text = "Run";
            payLinkDetailRunButton.UseVisualStyleBackColor = true;
            payLinkDetailRunButton.Click += payLinkDetailRunButton_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel2.Location = new System.Drawing.Point(630, 20);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(89, 19);
            linkLabel2.TabIndex = 36;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "API Endpoint";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // payLinkDetailGoToFileButton
            // 
            payLinkDetailGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payLinkDetailGoToFileButton.Name = "payLinkDetailGoToFileButton";
            payLinkDetailGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payLinkDetailGoToFileButton.TabIndex = 35;
            payLinkDetailGoToFileButton.Text = "Go to File";
            payLinkDetailGoToFileButton.UseVisualStyleBackColor = true;
            payLinkDetailGoToFileButton.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(15, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(330, 19);
            label4.TabIndex = 1;
            label4.Text = "Payload File: Requests\\SecurePaymentLinkDetail.json";
            // 
            // paymentLinksUpdateTab
            // 
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateIdTextBox);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateDependLabel);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateTree);
            paymentLinksUpdateTab.Controls.Add(label12);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateResponseTextBox);
            paymentLinksUpdateTab.Controls.Add(label11);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateStatusBox);
            paymentLinksUpdateTab.Controls.Add(label10);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateClearButton);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateRunButton);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateAPIButton);
            paymentLinksUpdateTab.Controls.Add(payLinkUpdateGoToFileButton);
            paymentLinksUpdateTab.Controls.Add(label9);
            paymentLinksUpdateTab.Location = new System.Drawing.Point(4, 24);
            paymentLinksUpdateTab.Name = "paymentLinksUpdateTab";
            paymentLinksUpdateTab.Padding = new System.Windows.Forms.Padding(3);
            paymentLinksUpdateTab.Size = new System.Drawing.Size(742, 512);
            paymentLinksUpdateTab.TabIndex = 1;
            paymentLinksUpdateTab.Text = "Update";
            paymentLinksUpdateTab.UseVisualStyleBackColor = true;
            // 
            // payLinkUpdateIdTextBox
            // 
            payLinkUpdateIdTextBox.Location = new System.Drawing.Point(390, 50);
            payLinkUpdateIdTextBox.Name = "payLinkUpdateIdTextBox";
            payLinkUpdateIdTextBox.Size = new System.Drawing.Size(120, 23);
            payLinkUpdateIdTextBox.TabIndex = 46;
            // 
            // payLinkUpdateDependLabel
            // 
            payLinkUpdateDependLabel.AutoSize = true;
            payLinkUpdateDependLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            payLinkUpdateDependLabel.Location = new System.Drawing.Point(15, 50);
            payLinkUpdateDependLabel.Name = "payLinkUpdateDependLabel";
            payLinkUpdateDependLabel.Size = new System.Drawing.Size(351, 19);
            payLinkUpdateDependLabel.TabIndex = 45;
            payLinkUpdateDependLabel.Text = "Dependency: Enter the 'id' from Payment Links->Create";
            // 
            // payLinkUpdateTree
            // 
            payLinkUpdateTree.Location = new System.Drawing.Point(405, 220);
            payLinkUpdateTree.Name = "payLinkUpdateTree";
            payLinkUpdateTree.Size = new System.Drawing.Size(315, 220);
            payLinkUpdateTree.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            label12.Location = new System.Drawing.Point(400, 190);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(67, 19);
            label12.TabIndex = 43;
            label12.Text = "Tree View";
            // 
            // payLinkUpdateResponseTextBox
            // 
            payLinkUpdateResponseTextBox.Location = new System.Drawing.Point(15, 220);
            payLinkUpdateResponseTextBox.Multiline = true;
            payLinkUpdateResponseTextBox.Name = "payLinkUpdateResponseTextBox";
            payLinkUpdateResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payLinkUpdateResponseTextBox.Size = new System.Drawing.Size(340, 220);
            payLinkUpdateResponseTextBox.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            label11.Location = new System.Drawing.Point(15, 190);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(104, 19);
            label11.TabIndex = 41;
            label11.Text = "Response JSON";
            // 
            // payLinkUpdateStatusBox
            // 
            payLinkUpdateStatusBox.Enabled = false;
            payLinkUpdateStatusBox.Location = new System.Drawing.Point(125, 160);
            payLinkUpdateStatusBox.Name = "payLinkUpdateStatusBox";
            payLinkUpdateStatusBox.Size = new System.Drawing.Size(75, 23);
            payLinkUpdateStatusBox.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            label10.Location = new System.Drawing.Point(15, 160);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(103, 19);
            label10.TabIndex = 39;
            label10.Text = "Response Code";
            // 
            // payLinkUpdateClearButton
            // 
            payLinkUpdateClearButton.Location = new System.Drawing.Point(120, 90);
            payLinkUpdateClearButton.Margin = new System.Windows.Forms.Padding(4);
            payLinkUpdateClearButton.Name = "payLinkUpdateClearButton";
            payLinkUpdateClearButton.Size = new System.Drawing.Size(94, 26);
            payLinkUpdateClearButton.TabIndex = 38;
            payLinkUpdateClearButton.Text = "Clear";
            payLinkUpdateClearButton.UseVisualStyleBackColor = true;
            payLinkUpdateClearButton.Click += payLinkUpdateClearButton_Click;
            // 
            // payLinkUpdateRunButton
            // 
            payLinkUpdateRunButton.Location = new System.Drawing.Point(15, 90);
            payLinkUpdateRunButton.Name = "payLinkUpdateRunButton";
            payLinkUpdateRunButton.Size = new System.Drawing.Size(94, 26);
            payLinkUpdateRunButton.TabIndex = 37;
            payLinkUpdateRunButton.Text = "Run";
            payLinkUpdateRunButton.UseVisualStyleBackColor = true;
            payLinkUpdateRunButton.Click += payLinkUpdateRunButton_Click;
            // 
            // payLinkUpdateAPIButton
            // 
            payLinkUpdateAPIButton.AutoSize = true;
            payLinkUpdateAPIButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            payLinkUpdateAPIButton.Location = new System.Drawing.Point(630, 20);
            payLinkUpdateAPIButton.Name = "payLinkUpdateAPIButton";
            payLinkUpdateAPIButton.Size = new System.Drawing.Size(89, 19);
            payLinkUpdateAPIButton.TabIndex = 36;
            payLinkUpdateAPIButton.TabStop = true;
            payLinkUpdateAPIButton.Text = "API Endpoint";
            payLinkUpdateAPIButton.LinkClicked += payLinkUpdateAPIButton_LinkClicked;
            // 
            // payLinkUpdateGoToFileButton
            // 
            payLinkUpdateGoToFileButton.Location = new System.Drawing.Point(390, 20);
            payLinkUpdateGoToFileButton.Name = "payLinkUpdateGoToFileButton";
            payLinkUpdateGoToFileButton.Size = new System.Drawing.Size(75, 23);
            payLinkUpdateGoToFileButton.TabIndex = 35;
            payLinkUpdateGoToFileButton.Text = "Go to File";
            payLinkUpdateGoToFileButton.UseVisualStyleBackColor = true;
            payLinkUpdateGoToFileButton.Click += payLinkUpdateGoToFileButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(15, 20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(340, 19);
            label9.TabIndex = 1;
            label9.Text = "Payload File: Requests\\SecurePaymentLinkUpdate.json";
            // 
            // paymentLinksExpTab
            // 
            paymentLinksExpTab.Controls.Add(payLinkExpTree);
            paymentLinksExpTab.Controls.Add(label16);
            paymentLinksExpTab.Controls.Add(payLinkExpResponseTextBox);
            paymentLinksExpTab.Controls.Add(label15);
            paymentLinksExpTab.Controls.Add(payLinkExpStatusBox);
            paymentLinksExpTab.Controls.Add(label14);
            paymentLinksExpTab.Controls.Add(payLinkExpClearButton);
            paymentLinksExpTab.Controls.Add(payLinkExpRunButton);
            paymentLinksExpTab.Controls.Add(linkLabel3);
            paymentLinksExpTab.Controls.Add(payLinkExpDependLabel);
            paymentLinksExpTab.Controls.Add(payLinkExpGotToFileButton);
            paymentLinksExpTab.Controls.Add(label13);
            paymentLinksExpTab.Location = new System.Drawing.Point(4, 24);
            paymentLinksExpTab.Name = "paymentLinksExpTab";
            paymentLinksExpTab.Size = new System.Drawing.Size(742, 512);
            paymentLinksExpTab.TabIndex = 3;
            paymentLinksExpTab.Text = "Expirations";
            paymentLinksExpTab.UseVisualStyleBackColor = true;
            // 
            // payLinkExpResponseTextBox
            // 
            payLinkExpResponseTextBox.Location = new System.Drawing.Point(15, 220);
            payLinkExpResponseTextBox.Multiline = true;
            payLinkExpResponseTextBox.Name = "payLinkExpResponseTextBox";
            payLinkExpResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            payLinkExpResponseTextBox.Size = new System.Drawing.Size(340, 220);
            payLinkExpResponseTextBox.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            label15.Location = new System.Drawing.Point(15, 190);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(104, 19);
            label15.TabIndex = 46;
            label15.Text = "Response JSON";
            // 
            // payLinkExpStatusBox
            // 
            payLinkExpStatusBox.Enabled = false;
            payLinkExpStatusBox.Location = new System.Drawing.Point(125, 160);
            payLinkExpStatusBox.Name = "payLinkExpStatusBox";
            payLinkExpStatusBox.Size = new System.Drawing.Size(75, 23);
            payLinkExpStatusBox.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            label14.Location = new System.Drawing.Point(15, 160);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(103, 19);
            label14.TabIndex = 44;
            label14.Text = "Response Code";
            // 
            // payLinkExpClearButton
            // 
            payLinkExpClearButton.Location = new System.Drawing.Point(120, 90);
            payLinkExpClearButton.Margin = new System.Windows.Forms.Padding(4);
            payLinkExpClearButton.Name = "payLinkExpClearButton";
            payLinkExpClearButton.Size = new System.Drawing.Size(94, 26);
            payLinkExpClearButton.TabIndex = 43;
            payLinkExpClearButton.Text = "Clear";
            payLinkExpClearButton.UseVisualStyleBackColor = true;
            payLinkExpClearButton.Click += payLinkExpClearButton_Click;
            // 
            // payLinkExpRunButton
            // 
            payLinkExpRunButton.Location = new System.Drawing.Point(15, 90);
            payLinkExpRunButton.Name = "payLinkExpRunButton";
            payLinkExpRunButton.Size = new System.Drawing.Size(94, 26);
            payLinkExpRunButton.TabIndex = 42;
            payLinkExpRunButton.Text = "Run";
            payLinkExpRunButton.UseVisualStyleBackColor = true;
            payLinkExpRunButton.Click += payLinkExpRunButton_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkLabel3.Location = new System.Drawing.Point(630, 20);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new System.Drawing.Size(89, 19);
            linkLabel3.TabIndex = 41;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "API Endpoint";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // payLinkExpDependLabel
            // 
            payLinkExpDependLabel.AutoSize = true;
            payLinkExpDependLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            payLinkExpDependLabel.Location = new System.Drawing.Point(15, 50);
            payLinkExpDependLabel.Name = "payLinkExpDependLabel";
            payLinkExpDependLabel.Size = new System.Drawing.Size(55, 19);
            payLinkExpDependLabel.TabIndex = 40;
            payLinkExpDependLabel.Text = "depend";
            // 
            // payLinkExpGotToFileButton
            // 
            payLinkExpGotToFileButton.Location = new System.Drawing.Point(390, 20);
            payLinkExpGotToFileButton.Name = "payLinkExpGotToFileButton";
            payLinkExpGotToFileButton.Size = new System.Drawing.Size(75, 23);
            payLinkExpGotToFileButton.TabIndex = 36;
            payLinkExpGotToFileButton.Text = "Go to File";
            payLinkExpGotToFileButton.UseVisualStyleBackColor = true;
            payLinkExpGotToFileButton.Click += payLinkExpGotToFileButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            label13.Location = new System.Drawing.Point(15, 20);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(355, 19);
            label13.TabIndex = 2;
            label13.Text = "Payload File: Requests\\SecurePaymentLinkExpiration.json";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(100, 50);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(156, 26);
            label5.TabIndex = 12;
            label5.Text = "Payment Links";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            label16.Location = new System.Drawing.Point(400, 190);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(67, 19);
            label16.TabIndex = 48;
            label16.Text = "Tree View";
            // 
            // payLinkExpTree
            // 
            payLinkExpTree.Location = new System.Drawing.Point(405, 220);
            payLinkExpTree.Name = "payLinkExpTree";
            payLinkExpTree.Size = new System.Drawing.Size(315, 220);
            payLinkExpTree.TabIndex = 49;
            // 
            // PaymentLinksControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PaymentLinksControl";
            Size = new System.Drawing.Size(908, 576);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            paymentLinksTabControl.ResumeLayout(false);
            paymentLinksCreateTab.ResumeLayout(false);
            paymentLinksCreateTab.PerformLayout();
            paymentLinksDetailsTab.ResumeLayout(false);
            paymentLinksDetailsTab.PerformLayout();
            paymentLinksUpdateTab.ResumeLayout(false);
            paymentLinksUpdateTab.PerformLayout();
            paymentLinksExpTab.ResumeLayout(false);
            paymentLinksExpTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl paymentLinksTabControl;
        private System.Windows.Forms.TabPage paymentLinksCreateTab;
        private System.Windows.Forms.Label paymentLinksCreateLabel;
        private System.Windows.Forms.TabPage paymentLinksUpdateTab;
        private System.Windows.Forms.TabPage paymentLinksDetailsTab;
        private System.Windows.Forms.TabPage paymentLinksExpTab;
        private System.Windows.Forms.Button paymentLinksCreateButton;
        private System.Windows.Forms.TreeView createPaymentLinksTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paymentLinksCreateStatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paymentLinksCreateResponseTextBox;
        private System.Windows.Forms.Button payCreateGoToFileButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button paymentLinkCreateResetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button payLinkDetailGoToFileButton;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button payLinkDetailClearButton;
        private System.Windows.Forms.Button payLinkDetailRunButton;
        private System.Windows.Forms.Label payLinkDetailDependLable;
        private System.Windows.Forms.TextBox payLinkDetailsResponseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox payLinkDetailStatusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView payLinkDetailTreeView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button payLinkUpdateGoToFileButton;
        private System.Windows.Forms.LinkLabel payLinkUpdateAPIButton;
        private System.Windows.Forms.TextBox payLinkUpdateResponseTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox payLinkUpdateStatusBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button payLinkUpdateClearButton;
        private System.Windows.Forms.Button payLinkUpdateRunButton;
        private System.Windows.Forms.TreeView payLinkUpdateTree;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label payLinkUpdateDependLabel;
        private System.Windows.Forms.TextBox payLinkUpdateIdTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button payLinkExpGotToFileButton;
        private System.Windows.Forms.Label payLinkExpDependLabel;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button payLinkExpClearButton;
        private System.Windows.Forms.Button payLinkExpRunButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox payLinkExpStatusBox;
        private System.Windows.Forms.TextBox payLinkExpResponseTextBox;
        private System.Windows.Forms.TreeView payLinkExpTree;
        private System.Windows.Forms.Label label16;
    }
}
