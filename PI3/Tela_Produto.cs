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
using System.IO;

namespace PI3
{
    public partial class Produtos : Form
    {
        private ClsUsuario infoUser;
        byte[] imagem;
        int idCategoria;
        public Produtos(ClsUsuario infouser)
        {
            infoUser = infouser;
            InitializeComponent();

        }

        //forma Produtos
        private void Produtos_Load(object sender, EventArgs e)
        {
            ListaGridProdutos();
           // comboBoxCategProd.Items.AddRange((object[])atualizaCmbCategoria());
        }

        public void atualizaCmbCategoria()
        {

            ClsCategoria Categoria = new ClsCategoria();

            comboBoxCategProd.DataSource = Categoria.GetCategoria();
            comboBoxCategProd.ValueMember = "idCategoria";
            comboBoxCategProd.DisplayMember = "nomeCategoria";
            
            //atualizaCmbCategoria();
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
            dgProdutos.DataSource = ProdutoFiltro.ConsultaProduto(txtPesquisaProd.Text);
            ConfiguraGrid();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxCategProd.SelectedValue.ToString());
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
            Menu tela_menu = new Menu(infoUser);
        }

        private void ListaGridProdutos()
        {

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
            dgProdutos.Columns["Imagem"].Visible = false;

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
             idCategoria = (int)dgProdutos.CurrentRow.Cells["idCategoria"].Value;
            
            

            MessageBox.Show(idCategoria.ToString());


            if (((byte[])dgProdutos.CurrentRow.Cells["imagem"].Value).Length != 0)
            {
                MemoryStream imagem = new MemoryStream((byte[])dgProdutos.CurrentRow.Cells["imagem"].Value);
                pictureProduto.Image = Image.FromStream(imagem);
            }
            else
            {
                pictureProduto.Image = null;

            }
        }



        private void btnAvancada_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagem (*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    imagem = File.ReadAllBytes(ofd.FileName);
                    mostraFoto(imagem);
                }
                else
                {
                    imagem = new byte[0];
                    MessageBox.Show("Arquivo Inválido! Tente novamente...");
                }
            }

        }

        private void mostraFoto(Byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(dados);
                pictureProduto.Image = Image.FromStream(mem);
            }
            else
            {
                pictureProduto.Image = null;
            }
        }


        private void comboBoxCategProd_Click(object sender, EventArgs e)
        {
            atualizaCmbCategoria();
  
        }

        private void comboBoxCategProd_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

}