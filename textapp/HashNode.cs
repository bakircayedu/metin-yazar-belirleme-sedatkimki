using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class HashNode
    {
        public Word Value { get; set; }
        public HashNode Next { get; set; }
        private int key;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }
    }
}
