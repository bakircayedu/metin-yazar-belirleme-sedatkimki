using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class Word
    {
        // kelimelerin özelliklerini tutar 
        public string word { get; set; }

        public Position pos;
        public string Preprocessed { get; set; }
        public float Frequency { get; set; }

        public Word()
        {
            Frequency = 0;
        }


    }
}
