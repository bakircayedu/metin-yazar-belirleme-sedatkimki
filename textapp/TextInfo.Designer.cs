namespace textapp
{
    partial class TextInfo
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
            this.InfoTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoTxtBox
            // 
            this.InfoTxtBox.Location = new System.Drawing.Point(12, 12);
            this.InfoTxtBox.Multiline = true;
            this.InfoTxtBox.Name = "InfoTxtBox";
            this.InfoTxtBox.ReadOnly = true;
            this.InfoTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoTxtBox.Size = new System.Drawing.Size(333, 232);
            this.InfoTxtBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ağaca Aktar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InfoTxtBox);
            this.Name = "TextInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metin bilgileri";
            this.Load += new System.EventHandler(this.TextInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InfoTxtBox;
        private Button button1;
    }
}