using frmPrincipal.LojaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

            using(SqlConnection conn = c.abrir_conexao())
            {
                da.Connection = conn;
                da.Fill(ds.Relatorio, nome);
            }

            return ds.Relatorio;
        }
        /**
         * não foi necessário usar essa chamada para o relatório de vendas abertas
         * 
        public static LojaDataSet.Venda_Aberta_Com_PeriodoDataTable GetVenda(DateTime data, DateTime data1)
        {
            Venda_Aberta_Com_PeriodoTableAdapter da = new Venda_Aberta_Com_PeriodoTableAdapter();

            LojaDataSet ds = new LojaDataSet();

            Conexao c = new Conexao();


            using (SqlConnection conn = c.abrir_conexao())
            {
                da.Connection = conn;
                da.Fill(ds.Venda_Aberta_Com_Periodo, data, data1);
            }

            return ds.Venda_Aberta_Com_Periodo;
        }
    **/
    }
}
