using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    class Autenticacao
    {
        static string id;
        static string nome;
        static string login;
        static string senha;
        static string permissao;

        public static void Login(string id1, string nome1, string login1, string senha1, string permissao1)
        {
            id = id1;
            nome = nome1;
            login = login1;
            senha = senha1;
            permissao = permissao1;
        }

        public static void Logout()
        {
            nome = null;
            senha = null;
            permissao = null;
        }

        public static String getUsuario()
        {
            return nome;
        }

        public static int getID()
        {
            int retonaID = Convert.ToInt32(id);
            return retonaID;
        }
    }
}
