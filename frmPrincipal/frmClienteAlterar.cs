﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmClienteAlterar : Form
    {
        Conexao banco = new Conexao();
        SqlConnection con;

        int id, numero;
        double limiteCredito;
        string nome, nomeMae, cpf, dataNascimento, cidade, rua, bairro, referencia, telefone, celular;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmClienteAlterarFinal f = new frmClienteAlterarFinal();
            f.recebeDados(id, nome, nomeMae, cpf, dataNascimento, cidade, rua, numero, bairro, referencia, telefone, celular, limiteCredito);
            f.ShowDialog();


            //banco.fecha_conexao();
        }

        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[0].Value);
                nome = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[1].Value);
                nomeMae = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[2].Value);
                cpf = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[3].Value);
                dataNascimento = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[4].Value);
                cidade = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[5].Value);
                rua = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[6].Value);
                numero = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[7].Value);
                bairro = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[8].Value);
                referencia = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[9].Value);
                telefone = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[10].Value);
                celular = Convert.ToString(dataConsulta.Rows[e.RowIndex].Cells[11].Value);
                limiteCredito = Convert.ToInt32(dataConsulta.Rows[e.RowIndex].Cells[12].Value);

                btnAlterar.Enabled = true;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na execução do programa \n\r Erro:" + ex.Message, "Erro ", MessageBoxButtons.OK);
            }
            

        }

        private void frmClienteAlterar_Load(object sender, EventArgs e)
        {
            try
            {
                string seleciona = @"SELECT idCli AS ID, nomeCli AS Nome, maeCli AS Nome_da_Mãe,cpfCli AS CPF, dataNascimentoCli AS Data_Nascimento, cidadecli AS Cidade, ruaCli AS Rua, numeroCli AS Número, bairroCli AS Bairro, referenciaCli AS Referencia, telCli AS Telefone, celCli AS Celular, limiteCreditoCli AS Limite_de_Credito FROM Cliente";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtNome.Text;

            try
            {
                //comando para buscar os dados do cliente no banco
                string seleciona = @"SELECT idCli AS ID, nomeCli AS Nome, maeCli AS Nome_da_Mãe,cpfCli AS CPF,dataNascimentoCli AS Data_Nascimento, cidadecli AS Cidade, ruaCli AS Rua, numeroCli AS Número, bairroCli AS Bairro, referenciaCli AS Referencia, telCli AS Telefone, celCli AS Celular, limiteCreditoCli AS Limite_de_Credito FROM Cliente WHERE nomeCli LIKE '%" + buscar + "%' OR cpfCli LIKE '%" + buscar + "%' ";
                SqlDataAdapter adaptador = new SqlDataAdapter(seleciona, con);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dataConsulta.DataSource = tabela;
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na execução do programa \n\r Erro: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
            
            
        }

        public frmClienteAlterar()
        {
            InitializeComponent();
            con = banco.abrir_conexao();

            btnAlterar.Enabled = false;
        }


    }
}
