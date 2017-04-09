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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Form Tela Login
        private void Form2_Load(object sender, EventArgs e)
        {


           }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Cad_Cliente TblCliente = new Cad_Cliente();
            TblCliente.Show();


        }


        private void tipoDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Usuario tlDep4 = new Cadastro_Usuario();
            tlDep4.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cadastro_Usuario tlDep4 = new Cadastro_Usuario();
            tlDep4.ShowDialog();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            Cad_Cliente TelaCliente = new Cad_Cliente();
            TelaCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
