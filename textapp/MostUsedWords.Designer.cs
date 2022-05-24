namespace textapp
{
    partial class MostUsedWords
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
            this.components = new System.ComponentModel.Container();
            this.WordsData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preprocessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MostUsedBtn = new System.Windows.Forms.Button();
            this.CreateHashTableBtn = new System.Windows.Forms.Button();
            this.SentenceTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WordTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WordsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // WordsData
            // 
            this.WordsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Preprocessed,
            this.Position,
            this.Frequency});
            this.WordsData.Location = new System.Drawing.Point(12, 12);
            this.WordsData.Name = "WordsData";
            this.WordsData.RowTemplate.Height = 25;
            this.WordsData.Size = new System.Drawing.Size(776, 367);
            this.WordsData.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Word";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Preprocessed
            // 
            this.Preprocessed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preprocessed.HeaderText = "Preprocessed";
            this.Preprocessed.Name = "Preprocessed";
            this.Preprocessed.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // word
            // 
            this.word.Frozen = true;
            this.word.HeaderText = "Word";
            this.word.Name = "word";
            this.word.ReadOnly = true;
            // 
            // MostUsedBtn
            // 
            this.MostUsedBtn.Location = new System.Drawing.Point(291, 385);
            this.MostUsedBtn.Name = "MostUsedBtn";
            this.MostUsedBtn.Size = new System.Drawing.Size(218, 53);
            this.MostUsedBtn.TabIndex = 1;
            this.MostUsedBtn.Text = "En sık kullanılan kelimeleri getir";
            this.MostUsedBtn.UseVisualStyleBackColor = true;
            this.MostUsedBtn.Click += new System.EventHandler(this.MostUsedBtn_Click);
            // 
            // CreateHashTableBtn
            // 
            this.CreateHashTableBtn.Enabled = false;
            this.CreateHashTableBtn.Location = new System.Drawing.Point(831, 60);
            this.CreateHashTableBtn.Name = "CreateHashTableBtn";
            this.CreateHashTableBtn.Size = new System.Drawing.Size(218, 53);
            this.CreateHashTableBtn.TabIndex = 2;
            this.CreateHashTableBtn.Text = "Hash Tablosu oluştur";
            this.CreateHashTableBtn.UseVisualStyleBackColor = true;
            this.CreateHashTableBtn.Click += new System.EventHandler(this.CreateHashTableBtn_Click);
            // 
            // SentenceTxtBox
            // 
            this.SentenceTxtBox.Enabled = false;
            this.SentenceTxtBox.Location = new System.Drawing.Point(831, 181);
            this.SentenceTxtBox.Name = "SentenceTxtBox";
            this.SentenceTxtBox.Size = new System.Drawing.Size(218, 23);
            this.SentenceTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cümle Konumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kelime Konumu";
            // 
            // WordTxtBox
            // 
            this.WordTxtBox.Enabled = false;
            this.WordTxtBox.Location = new System.Drawing.Point(832, 238);
            this.WordTxtBox.Name = "WordTxtBox";
            this.WordTxtBox.Size = new System.Drawing.Size(218, 23);
            this.WordTxtBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Enabled = false;
            this.SearchBtn.Location = new System.Drawing.Point(831, 282);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(218, 53);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Kelimeyi ara";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MostUsedWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WordTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SentenceTxtBox);
            this.Controls.Add(this.CreateHashTableBtn);
            this.Controls.Add(this.MostUsedBtn);
            this.Controls.Add(this.WordsData);
            this.Name = "MostUsedWords";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "En çok kullanılan kelimeler";
            this.Load += new System.EventHandler(this.MostUsedWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WordsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView WordsData;
        private DataGridViewTextBoxColumn word;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Preprocessed;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Frequency;
        private Button MostUsedBtn;
        private Button CreateHashTableBtn;
        private TextBox SentenceTxtBox;
        private Label label1;
        private Label label2;
        private TextBox WordTxtBox;
        private Button SearchBtn;
        private ErrorProvider errorProvider1;
    }
}