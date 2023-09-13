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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbotton_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text;
            string password = passwordbox.Text;

            if (username == "admin" && password == "admin")
            {

                //Application.SetCompatibleTextRenderingDefault(false);
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
                MessageBox.Show("USERNAME OR PASSWORD NOT MATCHED");
        }
    }
}
