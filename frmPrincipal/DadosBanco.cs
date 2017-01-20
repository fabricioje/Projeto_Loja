using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace frmPrincipal
{
    public class DadosBanco
    {
        public string servidor { get; set; }
        public string banco { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }


        public void VerificaDados()
        {
            StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
            servidor = arquivo.ReadLine();
            banco = arquivo.ReadLine();
            usuario = arquivo.ReadLine();
            senha = arquivo.ReadLine();
        }
    }
}
