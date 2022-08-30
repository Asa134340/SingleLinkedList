using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList.CLinkedList
{
    internal class SLinkedList
    {
        CustomNode head;
        String data;
        String nodeData;
        int nodeCount;
        CustomNode current;

        public void appendNode(string data)
        {

            if (head == null)
            {
                head = new CustomNode(data);
                nodeData = data;
                nodeCount++;

            }
            while (current.Next != null)
            {
                current = current.Next;
            }

            {
                current.Next = new CustomNode(data);
                nodeData = data;
                nodeCount++;

            }
        }

        public void prepend(string data)
        {
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
            }
            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }
        }
        public void deleteWithData(string data)
        {
            if (head == null)
            {
                MessageBox.Show("could not delete value because the list is empty");
                return;
            }
            if (head.data.Equals(data))
            {
                head = head.Next;
            }
        }
    }


            // List<string> showNext(int count, int listSize)
           // {
               // List<string> nextlist = new List<string>();
              //  current = head;
              //  nextlist.Add(current.data);
             //   while (current.Next != null)
             //   {
             //       nextlist.Add(current.Next.data);
             //       current = current.Next;
              //  }
               // return nextlist;
            }
        }
    }


