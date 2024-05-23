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
    public partial class Atualizar : Form
    {
        DAO bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do dado

        private void Atualiza_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                long codigo = Convert.ToInt64(textBox1.Text);
                string campo = textBox2.Text;
                string dado = textBox3.Text;
                //Atualizar dados
                MessageBox.Show(bd.Atualizar(codigo, "plantas", campo, dado));
                //limpar os campos
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do botao Atualizar

        private void Cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botao cancelar
    }//Fim da classe
}//Fim do projeto
