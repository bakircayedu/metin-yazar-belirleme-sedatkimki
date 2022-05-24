using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class Text
    {
        // dosyaların cümlelerini bir stackta tutar. ayrıca dosyanın dizinini tutar.
        public Stack Sentences;
         
        public string FilePath { get; set; }
        public Text()
        {
            Sentences= new Stack();
        }
        public void AddSentence(Sentence sentence)
        {
            Sentences.Push(sentence);
        }
    }
}
