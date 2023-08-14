using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            {
                
                String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/Área de Trabalho/faculdade/ProjetoEstoque/ProjetoEstoque/pecas11.accdb";
                OleDbConnection banco = new OleDbConnection(StringCon);
                banco.Open();
                string sql;
                sql = "SELECT * FROM User (Usuario,Senha) Values";
                sql += "('" + textBox1.Text + "', '" + textBox2.Text + "')";
               
  


                OleDbCommand cmd = new OleDbCommand(sql, banco);
               //int v = cmd.ExecuteNonQuery();
              
                banco.Close();
                string usuario = textBox1.Text;
                string senha = textBox2.Text;

                if (usuario == textBox1.Text && senha == textBox2.Text ) 
                        {
                            frm_controle controle = new frm_controle();
                            controle.ShowDialog();
                        }
                        else {
                            MessageBox.Show("Credenciais incorretas!!!");
                        }
                    }
                }
               
                }

            }
       