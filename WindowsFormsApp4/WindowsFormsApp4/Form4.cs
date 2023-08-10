using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (textBox2.Text == "Romeu" && textBox1.Text == "romeu") 
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else {
                MessageBox.Show("Credenciais incorretas");
            }

        }
    }
}
