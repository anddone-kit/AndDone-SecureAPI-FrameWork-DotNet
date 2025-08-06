namespace APISample.Requests.View
{
    partial class PaymentLinksViewDialog
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
            PaymentLinksViewDialogCloseButton = new System.Windows.Forms.Button();
            paymentLinksRequestRawTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // PaymentLinksViewDialogCloseButton
            // 
            PaymentLinksViewDialogCloseButton.Location = new System.Drawing.Point(658, 444);
            PaymentLinksViewDialogCloseButton.Name = "PaymentLinksViewDialogCloseButton";
            PaymentLinksViewDialogCloseButton.Size = new System.Drawing.Size(75, 23);
            PaymentLinksViewDialogCloseButton.TabIndex = 0;
            PaymentLinksViewDialogCloseButton.Text = "Close";
            PaymentLinksViewDialogCloseButton.UseVisualStyleBackColor = true;
            PaymentLinksViewDialogCloseButton.Click += PaymentLinksViewDialogCloseButton_Click;
            // 
            // paymentLinksRequestRawTextBox
            // 
            paymentLinksRequestRawTextBox.Location = new System.Drawing.Point(35, 78);
            paymentLinksRequestRawTextBox.Multiline = true;
            paymentLinksRequestRawTextBox.Name = "paymentLinksRequestRawTextBox";
            paymentLinksRequestRawTextBox.ReadOnly = true;
            paymentLinksRequestRawTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            paymentLinksRequestRawTextBox.Size = new System.Drawing.Size(698, 348);
            paymentLinksRequestRawTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(35, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 19);
            label1.TabIndex = 2;
            label1.Text = "JSON";
            // 
            // PaymentLinksViewDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 504);
            Controls.Add(label1);
            Controls.Add(paymentLinksRequestRawTextBox);
            Controls.Add(PaymentLinksViewDialogCloseButton);
            Name = "PaymentLinksViewDialog";
            Text = "Payment Link Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button PaymentLinksViewDialogCloseButton;
        private System.Windows.Forms.TextBox paymentLinksRequestRawTextBox;
        private System.Windows.Forms.Label label1;
    }
}