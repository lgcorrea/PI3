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
    public partial class Cadastrar_Usuario : Form
    {
        private int idUsuario { get; set; }
        private string nomeUsuario { get; set; }
        private string loginUsuario { get; set; }
        private string senha { get; set; }
        private string Rsenha { get; set; }
        private string tipoPerfil { get; set; }
        private bool usuarioInativo { get; set; }
        private ClsUsuario infoUser;

        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }

        private void gpbCadastrarUsuario_Enter(object sender, EventArgs e)
        {

            
        }

        private void Cadastrar_Usuario_Load(object sender, EventArgs e)
        {
            txtNomeCadastrar.Text = "";
            TxtLoginCadastrar.Text = "";
            CbxTipodePerfilCadastrar.Text = "";
            txtSenhaCadastrar.Text = "";
            txtRepeteSenhaCadastrar.Text = "";
            checkBox_UserAtivoCadastrar.Checked = true;
            idUsuario = 0;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txtNomeCadastrar.Text = "";
            TxtLoginCadastrar.Text = "";
            CbxTipodePerfilCadastrar.Text = "";
            txtSenhaCadastrar.Text = "";
            txtRepeteSenhaCadastrar.Text = "";
            checkBox_UserAtivoCadastrar.Checked = true;
            idUsuario = 0;

        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

            ClsUsuario RegistroUsuario = new ClsUsuario();

            if (txtNomeCadastrar.Text == ""){
                MessageBox.Show("Preencha o Nome de usuário");
            } else if(TxtLoginCadastrar.Text == "") {
                MessageBox.Show("Preencha o Login do usuário");
            } else if(txtSenhaCadastrar.Text == "") {
                MessageBox.Show("Preencha a Senha do usuário");
            }else if (txtRepeteSenhaCadastrar.Text == "") {
                MessageBox.Show("Repita a Senha do Informada");
            }else if (CbxTipodePerfilCadastrar.Text == "") {
                MessageBox.Show("Informe o tipo de Perfil do Usuário");
            }else if(txtSenhaCadastrar.Text != txtRepeteSenhaCadastrar.Text)
            {
                MessageBox.Show("Senhas não confere. Repita a senha novamente");
            }

                RegistroUsuario.nomeUsuario = txtNomeCadastrar.Text;
                RegistroUsuario.loginUsuario = TxtLoginCadastrar.Text;
                RegistroUsuario.senhaUsuario = txtSenhaCadastrar.Text;
                RegistroUsuario.tipoPerfil = CbxTipodePerfilCadastrar.Text;
                RegistroUsuario.usuarioAtivo = checkBox_UserAtivoCadastrar.Checked;
                RegistroUsuario.idUsuario = idUsuario; 

            RegistroUsuario.Salvar();
            MessageBox.Show("Usuário Cadastrado com Sucesso!");
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            //Cadastro_Usuario Tela_Usuario = new Cadastro_Usuario();
        }
    }
}
