using System;
using System.Collections.Generic;
using System.Text;

namespace ôn_CTDL
{
    class LinkedList
    {
        private Node first;
        private Node last;
        public LinkedList()
        {
            first = null;
            last = null;
        }
        internal Node First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        internal Node Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        public void addFirst(int value)
        {
            Node newNone = new Node(value);
            if (first == null)
            {
                first = newNone;
                last = newNone;
            }
            else
            {
                newNone.Next = first;
                first = newNone;
            }
        }
        public void addLast(int value)
        {
            Node newNode = new Node(value);
            if (first == null)
            {
                first = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = last;
                last = newNode;
            }
        }
        public void xoaFirst()
        {
            if (first != null)
            {
                first = first.Next;
                if (first == null)
                {
                    last = null;
                }
            }
        }
        public void xoa(Node node)
        {
            if (first == null)// neu ds rông
            {
                return;
            }
            if (first != node)
            {
                xoaFirst();
            }
            else
            {
                Node pre;
                for (pre = first; pre != last; pre = pre.Next)
                {
                    if (pre.Next == node)
                    {
                        Node del = pre.Next;
                        pre.Next = del.Next;
                        if (del == last)
                        {
                            last = pre;
                        }
                        break;
                    }
                }
            }
        }
        public void Print()
        {
            for (Node p = first; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data + " ");
            }
        }
        /// <summary>
        /// sap xep ds tang dan
        /// </summary>
        public void Sort()
        {
            for (Node p = First; p != null; p = p.Next)
            {
                //voi moi dau day p: tim min sau do hoan vi voi dau day
                Node min = p;
                for (Node t = p.Next; t != null; t = t.Next)
                {
                    if (t.Data < min.Data)
                    {
                        min = t;
                    }
                }

                //hoan vi
                int temp = p.Data;
                p.Data = min.Data;
                min.Data = temp;
            }
        }
        public Node Find(int key)
        {
            for (Node p = first; p != null; p = p.Next)
            {
                if (p.Data == key)
                {
                    return p;
                }
            }

            return null;
        }
    }
}
