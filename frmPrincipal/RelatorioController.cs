using frmPrincipal.LojaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    class RelatorioController
    {
        public static LojaDataSet.ConsultaDataTable GetConsulta()
        {
            ConsultaTableAdapter da = new ConsultaTableAdapter();

            LojaDataSet ds = new LojaDataSet();

            Conexao c = new Conexao();

            using (SqlConnection conn = c.abrir_conexao())
            {
                da.Connection = conn;
                da.Fill(ds.Consulta);
            }

            return ds.Consulta;
        }

        public static LojaDataSet.RelatorioDataTable GetRelatorio(string nome)
        {
            RelatorioTableAdapter da = new RelatorioTableAdapter();

            LojaDataSet ds = new LojaDataSet();

            Conexao c = new Conexao();

            using(SqlConnection conn= c.abrir_conexao())
            {
                da.Connection = conn;
                da.Fill(ds.Relatorio, nome);
            }

            return ds.Relatorio;
        }

    }
}
