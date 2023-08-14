using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstoque
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/OneDrive/DocumentoS/projetoestoque/pecas11.accdb";
            OleDbConnection banco = new OleDbConnection(StringCon);
            banco.Open();
            string sql;
            sql = "Insert into Pecas(Maquina,nome,codigo,quantidade) Values";
            sql += "('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' , '" + textBox4.Text + "')";

            OleDbCommand cmd = new OleDbCommand(sql, banco);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso");


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            banco.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_estoque estoque = new frm_estoque();
            estoque.ShowDialog();
        }
    }
}
