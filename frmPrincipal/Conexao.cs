using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    class Conexao
    {
        SqlConnection con;

        public SqlConnection abrir_conexao()
        {

            con = new SqlConnection();
            con.ConnectionString = @"Data Source=FABRICIO\SQLEXPRESS;Initial Catalog=Loja;Integrated Security=True";
            con.Open();
            return con;
        }

        public void fecha_conexao()
        {
            con.Close();
        }
    }
}
