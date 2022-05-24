namespace textapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextImportBtn = new System.Windows.Forms.Button();
            this.TransferStackBtn = new System.Windows.Forms.Button();
            this.FilePathTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextImportBtn
            // 
            this.TextImportBtn.Location = new System.Drawing.Point(12, 12);
            this.TextImportBtn.Name = "TextImportBtn";
            this.TextImportBtn.Size = new System.Drawing.Size(184, 49);
            this.TextImportBtn.TabIndex = 0;
            this.TextImportBtn.Text = "Metin Yükle ";
            this.TextImportBtn.UseVisualStyleBackColor = true;
            this.TextImportBtn.Click += new System.EventHandler(this.TextImportBtn_Click);
            // 
            // TransferStackBtn
            // 
            this.TransferStackBtn.Enabled = false;
            this.TransferStackBtn.Location = new System.Drawing.Point(12, 67);
            this.TransferStackBtn.Name = "TransferStackBtn";
            this.TransferStackBtn.Size = new System.Drawing.Size(184, 49);
            this.TransferStackBtn.TabIndex = 1;
            this.TransferStackBtn.Text = "Stack\'e Oku";
            this.TransferStackBtn.UseVisualStyleBackColor = true;
            this.TransferStackBtn.Click += new System.EventHandler(this.TransferStackBtn_Click);
            // 
            // FilePathTxtBox
            // 
            this.FilePathTxtBox.Location = new System.Drawing.Point(219, 26);
            this.FilePathTxtBox.Name = "FilePathTxtBox";
            this.FilePathTxtBox.ReadOnly = true;
            this.FilePathTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FilePathTxtBox.Size = new System.Drawing.Size(219, 23);
            this.FilePathTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 129);
            this.Controls.Add(this.FilePathTxtBox);
            this.Controls.Add(this.TransferStackBtn);
            this.Controls.Add(this.TextImportBtn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metin yükle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TextImportBtn;
        private Button TransferStackBtn;
        private TextBox FilePathTxtBox;
    }
}