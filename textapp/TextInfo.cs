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
    public partial class TextInfo : Form
    {
        public TextInfo()
        {
            InitializeComponent();
        }

        private void TextInfo_Load(object sender, EventArgs e)
        {
            InfoTxtBox.Text = Globals.GetTextInfos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Stack> WordsList= ClassifyTheWords();
            CalculateFrequency(WordsList);
            this.Hide();
            var MostUsedWords = new MostUsedWords();
            MostUsedWords.Closed += (s, args) => this.Close();
            MostUsedWords.Show();


        }
        private List<Stack> ClassifyTheWords()
        {
            List<Stack> WordsStack = new List<Stack>();
            Stack sentences = (Stack)Globals.text.Sentences;
            while (!sentences.IsEmpty())
            {
                Sentence sentence = (Sentence)sentences.Pop();
                while (!sentence.Words.IsEmpty())
                {
                    bool found = false;
                    Word word = (Word)sentence.Words.Pop();
                    foreach (Stack item in WordsStack)
                    {
                        Word w = (Word)item.Peek();
                        if (w.Preprocessed == word.Preprocessed )
                        {
                            item.Push(word);
                            found = true;
                            break;
                        }
                    }
                    if (WordsStack.Count==0 || !found)
                    {
                        Stack stk = new Stack();
                        stk.Push(word);
                        WordsStack.Add(stk);
                    }
                }
            }
            return WordsStack;
            
        }
        private void CalculateFrequency(List<Stack> wl)
        {
            foreach (Stack item in wl)
            {
                int fq = item.count;
                while (!item.IsEmpty())
                {
                    Word word = (Word)item.Pop();
                    word.Frequency = fq;
                    Globals.HeapTree.Insert(word);
                }
            }
        }
    }
}
