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
    public partial class VIEW : Form
    {
        public static List<book> firstbooks;
        public static List<book> secondbooks;

        string read;
        public static string[] titarr = new string[15];
        public static string[] ahuarr = new string[15];
        public static int[] isarr = new int[15];

        public VIEW()
        {
            InitializeComponent();
            firstbooks = new List<book>

            {
             new book(123456, "1984", "George Orwell", 1949),
            new book(234567, "To Kill a Mockingbird", "Harper Lee", 1960),
            new book(345678, "The Great Gatsby", "F. Scott Fitzgerald", 1925),
            new book(456789, "Moby-Dick", "Herman Melville", 1851),
            new book(567890, "Pride and Prejudice", "Jane Austen", 1813),
            new book(678901, "Lord of the Flies", "William Golding", 1954),
            new book(789012, "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997),
            new book(890123, "The Catcher in the Rye", "J.D. Salinger", 1951),
            new book(901234, "Brave New World", "Aldous Huxley", 1932),
            new book(012345, "The Hobbit", "J.R.R. Tolkien", 1937),
            new book(987654, "Don Quixote", "Miguel de Cervantes", 1605),
            new book(098765, "The Odyssey", "Homer", 1888),
            new book(109876, "Crime and Punishment", "Fyodor Dostoevsky", 1866),
            new book(210987, "Anna Karenina", "Leo Tolstoy", 1877),
            new book(321098, "War and Peace", "Leo Tolstoy", 1869)

            };
            for (int i = 0; i < 15; i++)
            {
                titarr[i] = firstbooks[i].TITLE;

            }
            for (int i = 0; i < 15; i++)
            {
                ahuarr[i] = firstbooks[i].AUTHOR;
            }
            for (int i = 0; i < 15; i++)
            {
                isarr[i] = firstbooks[i].ISBN;
            }

        }
        public void bubblesort(string[] titarr)
        {
            int len = titarr.Length;

            for (int i = 0; i < len-1; i++)
            {
                for (int j = 0; j < len - i-1; j++)
                {
                    int result = string.Compare(titarr[j], titarr[j + 1]);
                    if (result> 0)
                    {
                        string tempTitle = titarr[j];
                        titarr[j] = titarr[j + 1];   //changing the title array 
                        titarr[j + 1] = tempTitle;

                        book temp = secondbooks[j];
                        secondbooks[j] = secondbooks[j + 1]; //changing the real book list
                                                 //because the have similar index to the titarr we can change when titarr is changed 
                        secondbooks[j + 1] = temp;                        
                    }              
                }
            }
           // dataGridView1.DataSource = secondbooks;


        }
        public void selectionsort(string[] autarr)
        {
            int len = autarr.Length;
            int mp;

            for (int i = 0; i < len - 1; i++) 
            {
                mp = i;
                for (int j = i + 1; j < len; j++)
                {
                    int result = string.Compare(autarr[mp], autarr[j]);
                    if(result > 0)
                    {
                        mp = j;
                    }

                }
                string tempaut = autarr[i];
                autarr[i] = autarr[mp];
                autarr[mp] = tempaut;

                book temp = secondbooks[i];
                secondbooks[i] = secondbooks[mp];
                secondbooks[mp] = temp;
            }



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = firstbooks;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            

            if (comboBox1.Text == "BY TITLE")
            {
                bubblesort(titarr);
                if (dataGridView1 != null)
                    dataGridView1.DataSource = secondbooks;

                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = secondbooks;

                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
               selectionsort(ahuarr);
                if (dataGridView1 != null)
                    dataGridView1.DataSource = secondbooks;
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = secondbooks;

                }

            }
        }

        private void VIEW_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("BY TITLE");
            comboBox1.Items.Add("BY AUTHOR");
            comboBox1.Items.Add("BY YEAR");

            secondbooks = new List<book>
            {
             new book(123456, "1984", "George Orwell", 1949),
            new book(234567, "To Kill a Mockingbird", "Harper Lee", 1960),
            new book(345678, "The Great Gatsby", "F. Scott Fitzgerald", 1925),
            new book(456789, "Moby-Dick", "Herman Melville", 1851),
            new book(567890, "Pride and Prejudice", "Jane Austen", 1813),
            new book(678901, "Lord of the Flies", "William Golding", 1954),
            new book(789012, "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997),
            new book(890123, "The Catcher in the Rye", "J.D. Salinger", 1951),
            new book(901234, "Brave New World", "Aldous Huxley", 1932),
            new book(012345, "The Hobbit", "J.R.R. Tolkien", 1937),
            new book(987654, "Don Quixote", "Miguel de Cervantes", 1605),
            new book(098765, "The Odyssey", "Homer", 1888),
            new book(109876, "Crime and Punishment", "Fyodor Dostoevsky", 1866),
            new book(210987, "Anna Karenina", "Leo Tolstoy", 1877),
            new book(321098, "War and Peace", "Leo Tolstoy", 1869)

            };
          

            //for (int i = 0; i < 15; i++)
            //{
            //    titarr[i] = firstbooks[i].TITLE;

            //}
            //for(int i =0; i<15; i++)
            //{
            //    ahuarr[i] = firstbooks[i].AUTHOR;
            //}








        }
    }
}
