using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class DoublyLinkedNode
    {
        public int Value { get; set; }
        public DoublyLinkedNode Next { get; set; }
        public DoublyLinkedNode Previus { get; set; }
        public DoublyLinkedNode(int value)
        {
            Value = value;
            Next = null;
            Previus = null;
        }
    }
}
