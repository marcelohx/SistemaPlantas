using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//importar o MySQL

namespace SistemaPlantas
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] codigo;
        public string[] nome;
        public string[] especie;
        public string[] origem;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=SistemaPlantas;Uid=root;password=");
            try
            {
                conexao.Open();//abrir a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do construtor

        public string inserir(long codigo, string nome, string especie, string origem)
        {
            string inserir = $"Insert into plantas(codigo, nome, especie, origem) values" + $"('{codigo}','{nome}','{especie}','{origem}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;
        }//Fim do metodo

        public void PreencherVetor()
        {
            string query = "select * from plantas";
            //instanciar
            this.codigo = new long[100];
            this.nome = new string[100];
            this.especie = new string[100];
            this.origem = new string[100];
            //Fazer o comando de seleção do banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Leitor do banco
            MySqlDataReader leitura = sql.ExecuteReader();
            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt64(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                especie[i] = leitura["especie"] + "";
                origem[i] = leitura["origem"] + "";
                i++;//Percorrer o vetor
                contador++;//Contar quantos dados eu tenho
            }//Fim do while
            //Encerro a comunicação com o software
            leitura.Close();
        }//Fim do preencher
        public int QuantidadeDados()
        {
            return contador;
        }//Fim do quantidade de dados
        public string Atualizar(long codigo, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado!";
            return resultado;
        }//Fim do metodo
        public string Excluir(long codigo, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluído!";
            return resultado;
        }//Fim do excluir
    }//Fim da classe
}//Fim do projeto
