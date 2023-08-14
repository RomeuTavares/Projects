using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstoque
{
    public partial class frm_estoque : Form
    {
        public frm_estoque()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            try
            {
                bs.Filter = "Maquina like '%" + txtFiltro.Text + "%'";

            }
            catch { }
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

        private void frm_estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pecas11DataSet.Pecas'. Você pode movê-la ou removê-la conforme necessário.
            this.pecasTableAdapter.Fill(this.pecas11DataSet.Pecas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastrar = new Frm_Cadastro();
            cadastrar.ShowDialog();
        }
    }
}
