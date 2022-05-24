using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    internal interface IStack
    {
        void Push(Object item);
        object Pop();
        object Peek();
        bool IsEmpty();
    }
}
