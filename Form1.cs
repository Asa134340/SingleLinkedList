using SingleLinkedList.CLinkedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
            SLinkedList sLinkedList = new();
            sLinkedList.appendNode("I am the Head");
            sLinkedList.appendNode("I am the Second Node");
            sLinkedList.appendNode("I am the Third Node");
        }

        private void karaokeBtn_Click(object sender, EventArgs e)
        {
           SLinkedList sLinkedList = new();
            // MessageBox.Show(sLinkedList));
            // MessageBox.Show(sLinkedList.appendNode("I am the Second Node"));
            // MessageBox.Show(sLinkedList.appendNode("I am the Third Node"));
            // MessageBox.Show(sLinkedList.appendNode("You're my heart shaker"));
            sLinkedList.prepend("I am the new head");
            sLinkedList.prepend("I am the Second Node");

        }
    }
}
