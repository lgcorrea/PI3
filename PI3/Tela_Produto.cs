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
    public partial class Produtos : Form
    {
        private ClsUsuario infoUser;
        public Produtos(ClsUsuario infouser)
        {
            infoUser = infouser;
            InitializeComponent();
            
        }

        //forma Produtos
        private void Produtos_Load(object sender, EventArgs e)
        {
            ListaGridProdutos();
        }

        //label Nome Produto
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Label desconto promocao
        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        private void label_vlr_produto_Click(object sender, EventArgs e)
        {

        }

        private void label_qtdMinima_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdMinProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdDispProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescPromocao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checkbox_prodInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureProduto_Click(object sender, EventArgs e)
        {

        }

        private void imgProd_Click(object sender, EventArgs e)
        {

        }

        private void label_descricao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_categoria_Click(object sender, EventArgs e)
        {
            Categoria telaCategoria = new Categoria();
            telaCategoria.ShowDialog();
        }

        private void bt_Pesquisar_Click(object sender, EventArgs e)
        {
            ClsProduto ProdutoFiltro = new ClsProduto();
            //dgProdutos.DataSource = null;
            dgProdutos.DataSource =  ProdutoFiltro.ConsultaProduto(txtPesquisaProd.Text);
            //ListaGridProdutos();
            ConfiguraGrid();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
            Menu tela_menu = new Menu(infoUser);
        }

        private void ListaGridProdutos() {

            ClsProduto Produto = new ClsProduto();
            dgProdutos.DataSource = Produto.ListaProduto();
            ConfiguraGrid();
        }

        private void ConfiguraGrid()
        {             //COLUNAS GRID

            dgProdutos.Columns["nomeProduto"].HeaderText = "Nome produto";
            dgProdutos.Columns["descProduto"].HeaderText = "Descrição Produto";
            dgProdutos.Columns["precProduto"].HeaderText = "Preço Produto";
            dgProdutos.Columns["qtdProdutoDisponivel"].HeaderText = "Estoque disponível";
            dgProdutos.Columns["descontoPromocao"].HeaderText = "Desconto promoção";
            dgProdutos.Columns["nomeCategoria"].HeaderText = "Categoria";
            dgProdutos.Columns["qtdMinEstoque"].HeaderText = "Qtd minina de estoque";
            dgProdutos.Columns["ativoProduto"].HeaderText = "Produto Ativo";


            //COLUNA FICA INVISIVEL NO GRID
            dgProdutos.Columns["idProduto"].Visible = false;

            //COLUNAS SOMENTE LEITURA
            dgProdutos.Columns["nomeProduto"].ReadOnly = true;
            dgProdutos.Columns["descProduto"].ReadOnly = true;
            dgProdutos.Columns["precProduto"].ReadOnly = true;
            dgProdutos.Columns["descontoPromocao"].ReadOnly = true;
            dgProdutos.Columns["nomeCategoria"].ReadOnly = true;
            dgProdutos.Columns["qtdMinEstoque"].ReadOnly = true;
            dgProdutos.Columns["qtdProdutoDisponivel"].ReadOnly = true;
        }



        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeProduto.Text = dgProdutos.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtDescricaoProduto.Text = dgProdutos.CurrentRow.Cells["descProduto"].Value.ToString();
            txtValorProduto.Text = dgProdutos.CurrentRow.Cells["precProduto"].Value.ToString();
            txtDescPromocao.Text = dgProdutos.CurrentRow.Cells["descontoPromocao"].Value.ToString();
            comboBoxCategProd.Text = dgProdutos.CurrentRow.Cells["nomeCategoria"].Value.ToString();
            txtQtdDispProd.Text = dgProdutos.CurrentRow.Cells["qtdProdutoDisponivel"].Value.ToString();
            txtQtdMinProd.Text = dgProdutos.CurrentRow.Cells["qtdProdutoDisponivel"].Value.ToString();
            Checkbox_prodInativo.Checked = Convert.ToBoolean(dgProdutos.CurrentRow.Cells["ativoProduto"].Value);
            if(dgProdutos.CurrentRow.Cells["imagem"].Value != DBNull.Value)
            {
                //pictureProduto = (byte[])dgProdutos.CurrentRow.Cells["imagem"].Value;

            }

        }

        private void btnAvancada_Click(object sender, EventArgs e)
        {

        }
    }
}
