using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Form Tela Login
        private void Form2_Load(object sender, EventArgs e)
        {


        }

        //barra chama tela cliente
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Cad_Cliente TblCliente = new Cad_Cliente();
            TblCliente.Show();
        }

        //barra chama tela tipo pagamento
        private void tipoDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // barra chama tela usuario
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Usuario Telausuario = new Cadastro_Usuario();
            Telausuario.Show();
        }

        //barra chama tela de pedidos
        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Venda TelaVenda = new PI3.Venda();
            TelaVenda.ShowDialog();
        }

        //barra sai do programa
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //botao chama tela clientes
        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            Cad_Cliente TelaCliente = new Cad_Cliente();
            TelaCliente.Show();
        }  

        //bi
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //botao chama tela de vendas
        private void bt_Vendas_Click(object sender, EventArgs e)
        {
            Venda TelaVendas = new Venda();
            TelaVendas.ShowDialog();
        }
        
        //botao chama tela produtos
        private void bt_Produtos_Click(object sender, EventArgs e)
        {
            Produtos TelaProduto = new Produtos();
            TelaProduto.ShowDialog();
        }
        
        //
        private void bt_Estoque_Click(object sender, EventArgs e)
        {

        }

        private void bt_Config_Click(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
