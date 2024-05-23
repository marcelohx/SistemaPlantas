using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPlantas
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do especie

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim da origem

        private void Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados do banco
                long codigo = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string especie = textBox3.Text;
                string origem = textBox4.Text;
                //Cadastrar
                MessageBox.Show(bd.inserir(codigo, nome, especie, origem));//Insere dados no BD
                                                                           //Limpar a tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do botao cadastrar

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do cancelar
    }//Fim da classe
}//Fim do projeto
