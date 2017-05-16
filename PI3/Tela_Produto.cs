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
            

            //dgwProduto.DataSource = tlProduto.ConsultaProduto(txtPesquisaProd.Text);
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
        }

        private void ListaGridProdutos() {    

            ClsProduto Produto = new ClsProduto();            
            dgProdutos.DataSource = Produto.ConsultaProduto();
            
            //COLUNAS GRID

            //dgProdutos.Columns[1].HeaderText = "idProduto";
            dgProdutos.Columns[2].HeaderText = "Descrição Produto";
            dgProdutos.Columns[3].HeaderText = "Preço Produto";
            dgProdutos.Columns[4].HeaderText = "Desconto promoção";                
            
            //COLUNA FICA INVISIVEL NO GRID
            dgProdutos.Columns["idProduto"].Visible = false;
            //dgwProduto.Columns["loginUsuario"].Visible = false;

            //COLUNAS SOMENTE LEITURA

            //dgwProduto.Columns["nomeUsuario"].ReadOnly = true;
            
        }

        private void txtPesquisaProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
