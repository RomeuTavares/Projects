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
        class Global
        {
            public static string usuario, senha;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            {
                
                String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/Área de Trabalho/faculdade/ProjetoEstoque/ProjetoEstoque/pecas11.accdb";
                OleDbConnection banco = new OleDbConnection(StringCon);
                banco.Open();
                string sql;
                string sql2;
                
                sql = "SELECT * FROM User (Usuario,Senha) Values";
                //sql2.CommandText = "SELECT Usuario, Senha FROM User";
                sql2 = "SELECT * FROM [User]";
                OleDbCommand command = new OleDbCommand(sql2, banco);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Dados");
                    while (reader.Read()){
                        Global.usuario = reader["Usuario"].ToString();
                        Global.senha = reader["Senha"].ToString();
                        Console.WriteLine(reader["Usuario"].ToString());
                        Console.WriteLine(reader["Senha"].ToString());
                        Console.WriteLine(Global.usuario);
                        Console.WriteLine(Global.senha);
                    }
                }
           


                Console.WriteLine(sql);
               // sql += "('" + textBox1.Text + "', '" + textBox2.Text + "')";
               
  


                OleDbCommand cmd = new OleDbCommand(sql, banco);
                //int v = cmd.ExecuteNonQuery();

                banco.Close();

                if  (textBox2.Text == Global.usuario && Global.senha == textBox1.Text ) 
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
       