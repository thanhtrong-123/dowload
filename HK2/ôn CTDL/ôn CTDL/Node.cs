using System;
using System.Collections.Generic;
using System.Text;

namespace ôn_CTDL
{
    class Node
    {
        private int data;
        private Node next;
        public Node (int value)
        {
            data = value;
            next = null;
        }
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        internal Node Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}
