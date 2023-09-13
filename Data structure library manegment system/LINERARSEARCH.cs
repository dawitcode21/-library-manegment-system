using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_structure_library_manegment_system
{
    public partial class LINERARSEARCH : Form 
    {
        public LINERARSEARCH()
        {
            VIEW V = new VIEW();
            InitializeComponent();
            

            

        }
       
        public int LinearSearch(string[] arr, string x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int y = string.Compare(x, arr[i]);
                if (y==0)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }
        public int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
              
                if (arr[i]== x)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int x = LinearSearch(VIEW.titarr, input);
            if (x != -1)
            {
                int isbn = VIEW.firstbooks[x].ISBN;
                string title = VIEW.firstbooks[x].TITLE;
                string author = VIEW.firstbooks[x].AUTHOR;
                int date = VIEW.firstbooks[x].publicationdate;
                listBox1.Items.Add(isbn + "    " + title +"    " + author + "     " + date);
            }
            else
                MessageBox.Show("not founded");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            int x = LinearSearch(VIEW.ahuarr, input);
            if (x != -1)
            {
                int isbn = VIEW.firstbooks[x].ISBN;
                string title = VIEW.firstbooks[x].TITLE;
                string author = VIEW.firstbooks[x].AUTHOR;
                int date = VIEW.firstbooks[x].publicationdate;
                listBox2.Items.Add(isbn + "    " + title + "      " + author + "     " + date);
            }
            else
                MessageBox.Show("not founded");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox3.Text);
            int x = LinearSearch(VIEW.isarr, input);
            if (x != -1)
            {
                int isbn = VIEW.firstbooks[x].ISBN;
                string title = VIEW.firstbooks[x].TITLE;
                string author = VIEW.firstbooks[x].AUTHOR;
                int date = VIEW.firstbooks[x].publicationdate;
                listBox3.Items.Add(isbn + "    " + title + "      " + author + "     " + date);
            }
            else
                MessageBox.Show("not founded");

        }
    }
}
