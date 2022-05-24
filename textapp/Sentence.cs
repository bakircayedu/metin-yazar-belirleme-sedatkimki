using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class Sentence
    {
        public string sentence;
        public Stack Words;
        public int place { get; set; }
        public Sentence(string sentence, int place)
        { // her cümle string olarak gönderilir 
            this.sentence = sentence.ToLower();
            this.place = place;
            Words = new Stack();
            SplitIntoWords();
        }

        public void SplitIntoWords()
        {
            // gönderilen cümleleri kelimelere ayırır.
            string[] words = sentence.Split(' ');
            foreach (var word in words.Select((value, i) => new { i, value }))
            {
                string s = (place+1).ToString();
                string p = (word.i+1).ToString();
                string id = s + p;
                int PositionId = int.Parse(id);
                Word newWord = new Word
                {
                    word = word.value,
                    pos = new Position
                    {
                        Sentence = place+1,
                        PlaceOfWord = word.i+1,
                        PositionId = PositionId,
                    },
                    Preprocessed = PreprocessTheWord(word.value)
                };
                
                this.Words.Push((Word)newWord); // her cümlenin kendine ait kelimeleri tuttuğu bir stack var.
            }
        }
        public string PreprocessTheWord(string word) 
        {
            // kelimeyi önden işler.
            string PreprocessedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsPunctuation(word[i]) && i != 0)
                {
                    break;
                }
                else if(i == 0 && Char.IsPunctuation(word[i])) { continue; }
                PreprocessedWord += word[i];
            }
            
            return PreprocessedWord;
        }
    }
}
