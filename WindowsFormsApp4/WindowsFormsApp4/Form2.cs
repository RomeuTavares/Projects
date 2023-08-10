using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pecas11DataSet1.Pecas'. Você pode movê-la ou removê-la conforme necessário.
            this.pecasTableAdapter1.Fill(this.pecas11DataSet1.Pecas);
            // TODO: esta linha de código carrega dados na tabela 'pecas11DataSet.Pecas'. Você pode movê-la ou removê-la conforme necessário.
            this.pecasTableAdapter.Fill(this.pecas11DataSet.Pecas);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

           BindingSource bs = new BindingSource();
            
            bs.DataSource = dataGridView1.DataSource;
            try
            {
                bs.Filter = "Maquina like '%" + txtFiltro.Text + "%'";
                
            }
            catch {}
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dataGridView1.DataSource;
            try
            {
                bs.Filter = "nome like '%" + txtFiltro.Text + "%'";

            }
            catch { }
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 cadastrar = new Form1();
               cadastrar.ShowDialog();
            
        }
    }
}
