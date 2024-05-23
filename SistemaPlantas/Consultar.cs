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
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();
            ConfigurarGrid();
            NomeDados();
            bd.PreencherVetor();
            AdicionarDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Especie";
            dataGridView1.Columns[3].Name = "Origem";
        }//Fim do metodo
        public void AdicionarDados()
        {
            for (int i = 0; i < bd.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.codigo[i], bd.nome[i], bd.especie[i], bd.origem[i]);
            }
        }//Fim do metodo
        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//usuario não adiciona linhas
            dataGridView1.AllowUserToDeleteRows = false;//Usuario não deleta linhas
            dataGridView1.AllowUserToResizeColumns = false;//Usuario não adiciona colunas
            dataGridView1.AllowUserToResizeRows = false;//usuario não modifica linhas
            dataGridView1.ColumnCount = 4;
        }//Fim do metodo

        private void Consultar_Load(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
