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
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtLogin.Text = "";
            TxtNome.Text = "";
            CbxTipodePerfil.Text = "";
            TxtSenha.Text = "";
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
