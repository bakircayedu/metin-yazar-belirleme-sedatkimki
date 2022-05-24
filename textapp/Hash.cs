using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class Hash
    {

        public HashNode[] Table { get; set; }
        public int TableSize { get; set; }

        public Hash(int tableSize)
        {
            this.TableSize = tableSize;
            Table = new HashNode[TableSize];
            for (int i = 0; i < TableSize; i++)
            {
                Table[i] = null;
            }

        }
        public void Insert(Word data, int key)
        {
            int keyVal = key % TableSize;
            if (Table[keyVal] != null)
            {
                HashNode currnode = Table[keyVal];
                while (currnode.Next != null)
                {
                    if ( currnode != null)
                    {
                        currnode = currnode.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                currnode.Next = new HashNode
                {
                    Value = data,
                    Key = keyVal
                };
            }
            else
            {
                Table[keyVal] = new HashNode
                {
                    Value = data,
                    Key = keyVal
                };
            }
        }
        public Word GetWord(int key)
        {
            int keyVal = (key % TableSize);
            HashNode currnode = Table[keyVal];
            while (currnode != null && currnode.Value.pos.PositionId != key)
            {
                currnode = currnode.Next;
            }
            if (currnode == null)
            {
                return null;
            }
            else
            {
                return (Word)currnode.Value;
            }
        }

    }
}
