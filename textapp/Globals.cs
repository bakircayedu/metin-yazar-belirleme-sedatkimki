using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public static class Globals
    {
        public static Text text;
        
        public static Stream FileStream;
        public static string FilePath { get; set; }

        public static List<string> PreprocessedWords = new List<string>();
        public static Heap HeapTree;
        public static Word[] SortedWords;
        public static Hash HashTable;
        static Globals()
        {
            FilePath= string.Empty;
            text = new Text();
            HeapTree = new Heap(200);
            HashTable = new Hash(10);
        }
        
        public static string GetTextInfos()
        {
            // stackten her cümle ve her kelimeyi hesaplayıp rapor oluşturur.
            string infos = "";
            float sumOfSentences = text.Sentences.count;
            float sumOfWords= 0;
            string SumOfWordsByEachSentence = "";

            Stack tempStk = new Stack();
            while (!text.Sentences.IsEmpty())
            {
                Sentence sentence = (Sentence)text.Sentences.Pop();
                sumOfWords += sentence.Words.count;
                SumOfWordsByEachSentence += (sentence.place+1).ToString() + ". Cümlede " + sentence.Words.count + " kelime var. "+ Environment.NewLine;
                tempStk.Push(sentence);
            }
            while (!tempStk.IsEmpty())
            {
                Sentence sentence = (Sentence)tempStk.Pop();
                text.Sentences.Push(sentence);
            }   
            infos += "Bu metinde toplam " + sumOfSentences + " cümle ve "+ sumOfWords + " kelime vardır." + Environment.NewLine+ Environment.NewLine+
                     SumOfWordsByEachSentence + Environment.NewLine +
                     "Cümle Başına ortalama kelime sayısı: " + (sumOfWords/sumOfSentences);

            return infos;
        }

        
        
    }
}
