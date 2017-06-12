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
        int idProduto;
        bool CategoriaAlterada;


        public Produtos(ClsUsuario infouser)
        {
            infoUser = infouser;
            InitializeComponent();
        }

        //forma Produtos
        private void Produtos_Load(object sender, EventArgs e)
        {

            atualizaCmbCategoria();
            ListaGridProdutos();
            idProduto = 0;
            if(idProduto == 0)
            {
                btn_Estoque.Enabled = false;
            }
              
            
            if (infoUser.tipoPerfil != "A") {

                txtNomeProduto.Enabled = false;
                txtNomeProduto.Enabled = false;
                txtDescricaoProduto.Enabled = false;
                txtValorProduto.Enabled = false;
                txtDescPromocao.Enabled = false;
                comboBoxCategProd.Enabled = false;
                comboBoxCategProd.Enabled = false;
                txtQtdMinProd.Enabled = false;
                txtQtdDispProd.Enabled = false;
                Checkbox_prodInativo.Enabled = false;                
                bt_Salvar.Enabled = false;
                bt_Novo.Enabled = false;
                bt_excluir.Enabled = false;
                bt_categoria.Enabled = false;
                btn_removerFoto.Enabled = false;                
                btnCarregarFoto.Enabled = false;

                

            }
        }

        public void atualizaCmbCategoria()
        {
            
            ClsCategoria Categoria = new ClsCategoria();

            comboBoxCategProd.DataSource = Categoria.GetCategoria();
            comboBoxCategProd.ValueMember = "idCategoria";
            comboBoxCategProd.DisplayMember = "nomeCategoria";
            
            //atualizaCmbCategoria();
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
            //MessageBox.Show(comboBoxCategProd.SelectedValue.ToString());
            ClsProduto novoProduto = new ClsProduto();

            novoProduto.idProduto = idProduto;
            novoProduto.nomeProduto = txtNomeProduto.Text;
            novoProduto.descProduto = txtDescricaoProduto.Text;
            novoProduto.precProduto = Convert.ToDouble(txtValorProduto.Text);
            novoProduto.descontoPromocao = Convert.ToDouble(txtDescPromocao.Text);
            if (CategoriaAlterada)
            {
                novoProduto.idCategoria = (int)comboBoxCategProd.SelectedValue;
            }
            else 
            {
                novoProduto.idCategoria = idCategoria;
            }
            novoProduto.ativoProduto = Convert.ToBoolean(Checkbox_prodInativo.Checked);
            novoProduto.idUsuario = infoUser.idUsuario;
            novoProduto.qtdMinEstoque = Convert.ToInt32(txtQtdMinProd.Text);
            novoProduto.imagem = imagem == null?new byte[0]:imagem;           

            novoProduto.Salvar();
            idProduto = novoProduto.idProduto;
            ListaGridProdutos();


        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            ClsProduto ExcluiItem = new ClsProduto();
            if(idProduto == 0)
            {
                MessageBox.Show("Selecione um produto para excluir");

            }
            else
            {

                ExcluiItem.Excluir(idProduto);
                ListaGridProdutos();
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
            Menu tela_menu = new Menu(infoUser);
            tela_menu.Show();
        }

        public void ListaGridProdutos()
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
            dgProdutos.Columns["idCategoria"].Visible = false;

            //COLUNAS SOMENTE LEITURA
            dgProdutos.Columns["nomeProduto"].ReadOnly = true;
            dgProdutos.Columns["descProduto"].ReadOnly = true;
            dgProdutos.Columns["precProduto"].ReadOnly = true;
            dgProdutos.Columns["descontoPromocao"].ReadOnly = true;
            dgProdutos.Columns["nomeCategoria"].ReadOnly = true;
            dgProdutos.Columns["qtdMinEstoque"].ReadOnly = true;
            dgProdutos.Columns["qtdProdutoDisponivel"].ReadOnly = true;
            dgProdutos.Columns["ativoProduto"].ReadOnly = true;
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_Estoque.Enabled = true;
            txtNomeProduto.Text = dgProdutos.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtDescricaoProduto.Text = dgProdutos.CurrentRow.Cells["descProduto"].Value.ToString();
            txtValorProduto.Text = string.Format("{0:C}",dgProdutos.CurrentRow.Cells["precProduto"].Value.ToString());
            txtDescPromocao.Text = dgProdutos.CurrentRow.Cells["descontoPromocao"].Value.ToString();
            comboBoxCategProd.Text = dgProdutos.CurrentRow.Cells["nomeCategoria"].Value.ToString();
            comboBoxCategProd.SelectedValue = (int)dgProdutos.CurrentRow.Cells["idCategoria"].Value;
            txtQtdMinProd.Text = dgProdutos.CurrentRow.Cells["qtdMinEstoque"].Value.ToString();
            txtQtdDispProd.Text = dgProdutos.CurrentRow.Cells["qtdProdutoDisponivel"].Value.ToString();
            Checkbox_prodInativo.Checked = Convert.ToBoolean(dgProdutos.CurrentRow.Cells["ativoProduto"].Value);
            idCategoria = (int)dgProdutos.CurrentRow.Cells["idCategoria"].Value;
            idProduto = Convert.ToInt32(dgProdutos.CurrentRow.Cells["idProduto"].Value);
            
            if ( (dgProdutos.SelectedRows[0].Cells["imagem"].Value) != null )//|| ((byte[])dgProdutos.CurrentRow.Cells["imagem"].Value) != null)
            {
                //imagem = new byte[0];
                imagem = (byte[])dgProdutos.CurrentRow.Cells["imagem"].Value;
                mostraFoto((byte[])dgProdutos.CurrentRow.Cells["imagem"].Value);      
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

        private void mostraFoto(byte[] imagem)
        {
           
            if (imagem.Length > 0)
            {
                pictureProduto.Image = null;
                MemoryStream mem = new MemoryStream(imagem);
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
            // MessageBox.Show(comboBoxCategProd.SelectedValue.ToString());
            CategoriaAlterada = true;

        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {

            txtNomeProduto.Text = "";
            txtDescricaoProduto.Text = "";
            txtValorProduto.Text = "";
            txtDescPromocao.Text = "";
            comboBoxCategProd.Text = "";
            txtQtdDispProd.Text = "";
            txtQtdMinProd.Text = "";
            Checkbox_prodInativo.Checked = true;           
            pictureProduto.Image = null;
            idProduto = 0;    

        }

        private void btn_removerFoto_Click(object sender, EventArgs e)
        {
            pictureProduto.Image = null;
            imagem = null;
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Estoque tela_estoque = new Estoque(idProduto, infoUser);

            tela_estoque.ShowDialog();

            if (Estoque.atualizaProd)
            {
                ListaGridProdutos();              
            }
        }

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
        }

        private void txtDescPromocao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
        }

        private void txtQtdMinProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }

}