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
    public partial class frm_controle : Form
    {
        public frm_controle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_estoque estoque = new frm_estoque();
            estoque.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_CadastroUsers cadastroUser = new frm_CadastroUsers();
            cadastroUser.ShowDialog();

        }
    }
}
