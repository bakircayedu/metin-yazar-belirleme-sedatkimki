using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textapp
{
    public partial class MostUsedWords : Form
    {
        public MostUsedWords()
        {
            InitializeComponent();
        }

        private void MostUsedBtn_Click(object sender, EventArgs e)
        {
            WordsData.Rows.Clear();
            WordsData.Refresh();

            // sıralanan kelimelerin datagridview da gösterilmesi
            foreach (Word item in Globals.SortedWords)
            {
                if (item != null)
                {
                    DataGridViewRow row = (DataGridViewRow)WordsData.Rows[0].Clone();
                    row.Cells[0].Value = item.word;
                    row.Cells[1].Value = item.Preprocessed;
                    row.Cells[2].Value = (item.pos.Sentence) + ".Cümle  " + (item.pos.PlaceOfWord ) + ".Kelime " ;
                    row.Cells[3].Value = item.Frequency;
                    WordsData.Rows.Add(row);
                }
            }
            CreateHashTableBtn.Enabled = true;
        }

        private void CreateHashTableBtn_Click(object sender, EventArgs e)
        {
            // Sıralanmış kelime dizisinden kelimelerle hash tablosu oluşturur
            foreach (Word item in Globals.SortedWords)
            {
                if (item != null)
                {
                    Globals.HashTable.Insert(item, item.pos.PositionId);
                }
            }
            SentenceTxtBox.Enabled = true;
            WordTxtBox.Enabled = true;
            SearchBtn.Enabled = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())// inputlar doğruysa aranan kelime message boxta gösterilir.
            {
                int sentencePos = int.Parse(SentenceTxtBox.Text);
                int wordPos = int.Parse(WordTxtBox.Text);
                int SearchKey = int.Parse(SentenceTxtBox.Text + WordTxtBox.Text);
                Word word = Globals.HashTable.GetWord(SearchKey);
                if (word != null)
                {
                    if (word.pos.PlaceOfWord == wordPos && word.pos.Sentence == sentencePos)
                    {
                        MessageBox.Show("Kelime: " + word.word + Environment.NewLine +
                                        "Kelimenin işlenmiş hali: " + word.Preprocessed + Environment.NewLine +
                                        "Kelimenin kullanım sıklığı: " + word.Frequency + Environment.NewLine +
                                        "Kelimenin konumu: " + word.pos.Sentence + ". Cümle " + word.pos.PlaceOfWord + ". Kelime");
                        SentenceTxtBox.Text = "";
                        WordTxtBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Aradığınız kelime bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Aradığınız kelime bulunamadı.");
                }


            }    
        }

        private void MostUsedWords_Load(object sender, EventArgs e)
        { // form yüklendiğinde kelimeleri heaptree yardımıyla sıralar
            Globals.SortedWords = Globals.HeapTree.Sort();
        }

        private bool ValidateInputs()
        { // inputları doğrular
            if (string.IsNullOrWhiteSpace(SentenceTxtBox.Text) || string.IsNullOrWhiteSpace(WordTxtBox.Text))
            {
                MessageBox.Show("Cümle veya kelime alanları boş bırakılamaz.");
                return false;
            }
            if (!int.TryParse(SentenceTxtBox.Text, out _) || !int.TryParse(WordTxtBox.Text, out _))
            {
                MessageBox.Show("Cümle veya kelime alanları sayısal olmalı.");
                return false;
            }
            return true;
            
        }
    }
}
