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
    public partial class Cadastro_Usuario : Form
    {
        private string nomeUsuario { get; set; }
        private string loginUsuario { get; set; }
        private string senha { get; set; }
        private string Rsenha { get; set; }
        private string tipoPerfil { get; set; }
        private bool usuarioInativo { get; set;}
        private BindingSource navegacao { get; set; }

        public Cadastro_Usuario(BindingSource navegacao)
        {

            InitializeComponent();
            this.navegacao = navegacao;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }


        //tela form Login
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CbxTipodePerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }



        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {
            nomeUsuario = txtNome.Text;

        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            loginUsuario = TxtLogin.Text;

        }

        private void label_tipoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_UserAtivo_CheckedChanged(object sender, EventArgs e)
        {
            bool usuarioInativo = false;

            if (checkBox_UserAtivo.Checked) {

                usuarioInativo = true;

            }           
            
        }


        private void bt_mudaSenha_Click(object sender, EventArgs e)
        {
            AlteraSenha Tela_AlteraSenha = new AlteraSenha();
            Tela_AlteraSenha.Show();

        }

        private void barraNavegacao_RefreshItems(object sender, EventArgs e)
        {
            //BindingSource navegacao = new BindingSource();
            //navegacao = ClsUsuario.NavegaUsuarios(); 
                        
            barraNavegacao.BindingSource = navegacao;
       
            TxtLogin.DataBindings.Clear();
            TxtLogin.DataBindings.Add(new Binding("Text", navegacao, "loginUsuario"));
            txtNome.DataBindings.Clear();
            txtNome.DataBindings.Add(new Binding("Text", navegacao, "nomeUsuario"));
            CbxTipodePerfil.DataBindings.Clear();
            CbxTipodePerfil.DataBindings.Add(new Binding("Text", navegacao, "tipoPerfil"));

        }

        private void bt_NavegacaoNext_Click(object sender, EventArgs e)
        {
            bt_NavegacaoNext.Enabled = true;
            this.navegacao.MoveNext();
         
        }

        private void bt_NavegacaoPrevious_Click(object sender, EventArgs e)
        {
            //bt_NavegacaoPrevious.Enabled = true;
            this.navegacao.MoveLast();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }
}
