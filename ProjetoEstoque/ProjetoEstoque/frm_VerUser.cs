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
    public partial class frm_VerUser : Form
    {
        public frm_VerUser()
        {
            InitializeComponent();
        }

        private void frm_VerUser_Load(object sender, EventArgs e)
        {
            String StringCon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/rrome/Área de Trabalho/faculdade/ProjetoEstoque/ProjetoEstoque/pecas11.accdb";
            OleDbConnection banco = new OleDbConnection(StringCon);
            banco.Open();
            string sql = "SELECT * FROM [User]";
            OleDbDataAdapter grid = new OleDbDataAdapter(sql, banco);
            DataSet ds = new DataSet();
            grid.Fill(ds, "Usuarios");
            banco.Close();

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Usuarios";





           

        }
    }
}
