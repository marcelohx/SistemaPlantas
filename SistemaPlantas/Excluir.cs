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
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do codigo

        private void Exclusao_Click(object sender, EventArgs e)
        {
            try
            {
                long codigo = Convert.ToInt64(textBox1.Text);//Coletando o cpf
                                                          //chamar o metodo
                MessageBox.Show(bd.Excluir(codigo, "plantas"));
                //limpar o campo
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do botao excluir

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botao cancelar
    }
}
