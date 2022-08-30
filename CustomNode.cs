using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    internal class CustomNode
    {
        public CustomNode Next;
        string data;
        public CustomNode()
        {
            
        }
        public CustomNode(string data)
        {
            this.data = data;
        }
    }
}
