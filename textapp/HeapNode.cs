using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class HeapNode
    {
        public Word Value { get; set; }
        public HeapNode(Word value)
        {
            this.Value = value;

        }
    }
}
