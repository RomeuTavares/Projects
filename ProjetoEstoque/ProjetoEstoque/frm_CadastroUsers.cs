using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstoque
{
    public partial class frm_CadastroUsers : Form
    {
        
        public frm_CadastroUsers()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/OneDrive/DocumentoS/projetoestoque/pecas11.accdb";
            // OleDbConnection banco = new OleDbConnection(StringCon);
            //  banco.Open();
            //  string sql;
            //  sql = "INSERT INTO User(Nome,Email,Senha,Usuario,Permissao) Values (?, ?, ?, ?, ?)";
            //  sql += "('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + comboBox1.Text + "')";
            //  OleDbCommand cmd = new OleDbCommand(sql, banco);
            // cmd.ExecuteNonQuery();
            //  MessageBox.Show("Cadastrado com sucesso");



            //   textBox1.Clear();
            //   textBox2.Clear();
            //    textBox3.Clear();
            //    textBox4.Clear();
            //    banco.Close();

            String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/Área de Trabalho/faculdade/ProjetoEstoque/ProjetoEstoque/pecas11.accdb";
            using (OleDbConnection banco = new OleDbConnection(StringCon))
            {
                banco.Open();

                string sql = "INSERT INTO [User] (Nome, Email, Senha, Usuario, Permissao) VALUES (?, ?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(sql, banco))
                {
                    cmd.Parameters.AddWithValue("Nome", textBox1.Text);
                    cmd.Parameters.AddWithValue("Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("Senha", textBox3.Text);
                    cmd.Parameters.AddWithValue("Usuario", textBox4.Text);
                    cmd.Parameters.AddWithValue("Permissao", comboBox1.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastrado com sucesso");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }




        }
        }
    } 
    