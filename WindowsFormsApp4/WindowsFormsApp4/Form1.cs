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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
             
            String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/OneDrive/DocumentoS/projetoestoque/pecas11.accdb";
            OleDbConnection banco = new OleDbConnection(StringCon);
            banco.Open();
           string sql;
            sql =  "Insert into Pecas(Maquina,nome,codigo,quantidade) Values";
            sql += "('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' , '" + textBox4.Text + "')";
           
            OleDbCommand cmd = new OleDbCommand(sql,banco);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso");
            

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox4.Clear();
             banco.Close();
            

       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 estoque = new Form2();
            estoque.ShowDialog();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 retirada = new Form3();
            retirada.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

