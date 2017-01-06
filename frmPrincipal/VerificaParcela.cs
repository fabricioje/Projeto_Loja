using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    class VerificaParcela
    {
        public double VerificaValorParcela(double valorTotal, int qtdParcelas)
        {
            double valorParcela = valorTotal / qtdParcelas;
            if (qtdParcelas == 0)
            {
                valorParcela = 0;
            }
            return valorParcela;
        }

        public int BaixaParcela(int totalParcelas)
        {
            int parcelasRestantes;

              parcelasRestantes = totalParcelas - 1;

            return parcelasRestantes;
        }

        public int VerificaParcelas(int totalParcelas, int parcelasPagas)
        {
            int parcelasRestantes = totalParcelas - totalParcelas + 1;
            return parcelasRestantes;
        }

        public string VerificaSituacao(int parcelaAtualizada)
        {
            string situacao;
            if(parcelaAtualizada > 0)
            {
                situacao = "ABERTA";
            }
            else
            {
                situacao = "FECHADA";
            }
            return situacao;
        }
    }
}
