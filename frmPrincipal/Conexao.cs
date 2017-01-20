using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace frmPrincipal
{
    class Conexao
    {
        SqlConnection con;
        
        public static String servidor;// = @"FABRICIO\SQLEXPRESS";
        public static String banco;// = "Loja";
        public static String usuario;// = "sa";
        public static String senha;// = "123456";
    
    
        public SqlConnection abrir_conexao()
        {

            try
            {   
                //** teste para altrar o caminha da string d conexao
                DadosBanco dados = new DadosBanco();
                dados.VerificaDados();
                servidor = dados.servidor;
                banco = dados.banco;
                usuario = dados.usuario;
                senha = dados.senha;
                

                con = new SqlConnection();
                con.ConnectionString = @"Data Source=" + servidor + "; Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
                con.Open();
                //return con;
            }catch(Exception)
            {
                
            }

            return con;            
        }


        public static string testar_conexao
        {

            get
            {
                return @"Data Source=" + servidor + "; Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }

        }

        public void fecha_conexao()
        {
            con.Close();
        }
    }
}
