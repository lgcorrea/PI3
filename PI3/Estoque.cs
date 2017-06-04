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
    public partial class Estoque : Form
    {
        public int idProduto { get; set; }

        public Estoque(int idProduto)
        {
            InitializeComponent();
            this.idProduto = idProduto;
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            PopulaCampos();
            cbox_entrada.Checked = true;

        }

        private void txt_personalizado_Click(object sender, EventArgs e)
        {
            

            txt_personalizado.Text = string.Format("Informe a quantidade de {0}",cbox_entrada.Checked==true ? "entrada" : "saida");
        }


        private void PopulaCampos() {

            ClsEstoque item = new ClsEstoque();
            item = item.RetornaItemEstoque(idProduto);

            txtNomeProduto.Text = item.nomeProduto;
            txtQtdDispProd.Text = item.qtdDisponivel.ToString();
            txtQtdMinProd.Text = item.qtdMinima.ToString();          

        }

        private void cbox_entrada_CheckedChanged_1(object sender, EventArgs e)
        {
            configuraCheckboxEntrada();

        }

        private void cbox_Saida_CheckedChanged_1(object sender, EventArgs e)
        {
            configuraCheckboxSaida();
        }

        private void configuraCheckboxEntrada()
        {

            if (cbox_entrada.Checked)
            {

                cbox_Saida.Checked = false;
            }
            else
            {

                cbox_Saida.Checked = true;
                cbox_entrada.Checked = false;
            }
        }

        private void configuraCheckboxSaida()
        {

            if (cbox_Saida.Checked)
            {

                cbox_entrada.Checked = false;
            }
            else
            {

                cbox_entrada.Checked = true;
                cbox_Saida.Checked = false;
            }
        }
    }
}
