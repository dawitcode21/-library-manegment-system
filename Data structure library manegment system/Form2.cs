﻿using System;
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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIEW vi = new VIEW();
            vi.ShowDialog();



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LINERARSEARCH ls = new LINERARSEARCH();
            ls.ShowDialog();
        }
    }
}
