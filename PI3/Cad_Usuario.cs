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
        private int idUsuario { get; set; }
        private string nomeUsuario { get; set; }
        private string loginUsuario { get; set; }
        private string senha { get; set; }
        private string Rsenha { get; set; }
        private string tipoPerfil { get; set; }
        private bool usuarioInativo { get; set;}
        private ClsUsuario infoUser;

        public Cadastro_Usuario(ClsUsuario infoUser)
        {

            InitializeComponent();
            this.infoUser = new ClsUsuario() ;
            this.infoUser = infoUser;
            
        }

        class tipo {

            public string Nome { get; set; }
            public string Sigla { get; set; }
            public tipo(string nome, string sigla)
            {

                this.Nome = nome;
                this.Sigla = sigla;
            }

            public override string ToString()
            {
                return Nome;
            }

            public static tipo[] GetTiposDisponiveis() {

                return new tipo[]
                {
                    new tipo("Administrador","A"),
                    new tipo("Estoquista","E")

            };

            }

       }
        

        public Cadastro_Usuario()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            Menu Tela_menu = new Menu();
            Tela_menu.Show();                                
            
        }


        //tela form usuario
        private void Form4_Load(object sender, EventArgs e)
        {

            //navegacao = infoUser.NavegaUsuarios();
            //dgUsuarios.DataSource = navegacao;
            ListaGrid();
            idUsuario = 0;
            CbxTipodePerfil.Items.AddRange(tipo.GetTiposDisponiveis());

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
        
            
        }

        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            ClsUsuario RegistroUsuario = new ClsUsuario();

            RegistroUsuario.nomeUsuario = txtNome.Text;
            RegistroUsuario.loginUsuario = TxtLogin.Text;
            RegistroUsuario.senhaUsuario = txtSenhaUser.Text;
            RegistroUsuario.tipoPerfil = CbxTipodePerfil.Text;
            RegistroUsuario.usuarioAtivo = checkBox_UserAtivo.Checked;
            RegistroUsuario.idUsuario = idUsuario;

            RegistroUsuario.Salvar();
            ListaGrid();

        }

        private void bt_NovoUsuario_Click(object sender, EventArgs e)
        {
            Cadastrar_Usuario Tela_CadastrarUsuario = new Cadastrar_Usuario();
            Tela_CadastrarUsuario.ShowDialog();
        }   
  

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //POPULA CAMPOS DA TELA

            txtNome.Text = dgUsuarios.CurrentRow.Cells[1].Value.ToString();
            TxtLogin.Text = dgUsuarios.CurrentRow.Cells[2].Value.ToString();
            CbxTipodePerfil.Text = dgUsuarios.CurrentRow.Cells[3].Value.ToString();
            checkBox_UserAtivo.Checked = Convert.ToBoolean(dgUsuarios.CurrentRow.Cells[4].Value);

            //POPULA VARIAVEL COM ID DO REGISTRO SELECIONADO NO GRID
            idUsuario = Convert.ToInt32(dgUsuarios.CurrentRow.Cells[0].Value);

        }

        private void ListaGrid()
        {
            DataGridView navegacao = new DataGridView();
            dgUsuarios.DataSource = infoUser.NavegaUsuarios();
            //COLUNAS GRID

            //dgUsuarios.Columns[1].HeaderText = "Login";
            dgUsuarios.Columns[2].HeaderText = "Nome Usuário";
            dgUsuarios.Columns[3].HeaderText = "Tipo de Perfil";
            dgUsuarios.Columns[4].HeaderText = "Usuário ativo";
            

            //COLUNA FICA INVISIVEL NO GRID
            dgUsuarios.Columns["idUsuario"].Visible = false;
            dgUsuarios.Columns["loginUsuario"].Visible = false;

            //COLUNAS SOMENTE LEITURA

            //dgUsuarios.Columns["loginUsuario"].ReadOnly = true;
            dgUsuarios.Columns["nomeUsuario"].ReadOnly = true;          



        }

        private void txtSenhaUser_TextChanged(object sender, EventArgs e)
        {
            txtSenhaUser.PasswordChar = '*';
        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {
            txtRepeteSenha.PasswordChar = '*';
        }


    }
}
