using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    class Verificacao
    {
        SqlConnection con;
        Conexao banco = new Conexao();
        
        public bool verificaBanco(string valor)
        {
            con = banco.abrir_conexao();

            bool aux = false;
            string query = "SELECT COUNT (login) FROM Usuario WHERE login=@login1";
            

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@login1", valor);
            
            //Uso o escalar porque ele retorna o valor da coluna do select, jogo no object para receber um valor nullo.
            object o = cmd.ExecuteScalar();

            if(o != null)
            {
                int total = Convert.ToInt32(o);
                if(total > 0)
                {

                    cmd.Parameters.Clear();
                    aux = false;
                }
                else
                {
                    aux = true;
                }
            }
            return aux;
        }
    }
}
