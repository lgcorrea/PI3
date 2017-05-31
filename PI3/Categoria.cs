using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace PI3
{
    public partial class Categoria : Form
    {
        int idCategoria;
        public Categoria()
        {
            InitializeComponent();
            ListaGridCategoria();
            ConfiguraGrid();
            idCategoria = 0;
        }

        private void ListaGridCategoria() {

            ClsCategoria categoria = new ClsCategoria();
            dgCategoria.DataSource =  categoria.GetCategoria();
        }

        private void ConfiguraGrid() {
            //COLUNAS GRID

            dgCategoria.Columns["nomeCategoria"].HeaderText = "Nome Categoria";
            dgCategoria.Columns["descCategoria"].HeaderText = "Descrição Categoria";


            //COLUNA FICA INVISIVEL NO GRID
            dgCategoria.Columns["idCategoria"].Visible = false;

            //COLUNAS SOMENTE LEITURA
            dgCategoria.Columns["nomeCategoria"].ReadOnly = true;
            dgCategoria.Columns["descCategoria"].ReadOnly = true;

            dgCategoria.Columns["nomeCategoria"].Width = 120;
            dgCategoria.Columns["descCategoria"].Width = 180;
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoria.Text = dgCategoria.CurrentRow.Cells["nomeCategoria"].Value.ToString();
            txtDescricao.Text = dgCategoria.CurrentRow.Cells["descCategoria"].Value.ToString();

            idCategoria = (int)dgCategoria.CurrentRow.Cells["idCategoria"].Value;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ClsCategoria novaCategoria = new ClsCategoria();
            if (txtCategoria.Text != "")
            {
                novaCategoria.nomeCategoria = txtCategoria.Text;
                novaCategoria.descCategoria = txtDescricao.Text;
                novaCategoria.idCategoria = idCategoria;
                novaCategoria.Salvar();
                ListaGridCategoria();
                idCategoria = novaCategoria.idCategoria;

            }
            else {

                MessageBox.Show("Informe o nome da Categoria");

            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            idCategoria = 0;
            txtCategoria.Text = "";
            txtDescricao.Text = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
