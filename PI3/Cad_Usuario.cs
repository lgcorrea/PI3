﻿using System;
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
            Menu Tela_Menu = new Menu(infoUser);
            Tela_Menu.Show();


        }


        //tela form usuario
        private void Form4_Load(object sender, EventArgs e)
        {

            ListaGrid();
            idUsuario = 0;
            CbxTipodePerfil.Items.AddRange(tipo.GetTiposDisponiveis());            
            checkBox_UserAtivo.Checked = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CbxTipodePerfil_SelectedIndexChanged(object sender, EventArgs e)
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

            if (ValidaCamposTela())
            {
                ClsUsuario SalvarUsuario = new ClsUsuario();

                SalvarUsuario.nomeUsuario = txtNome.Text;
                SalvarUsuario.loginUsuario = TxtLogin.Text;
                SalvarUsuario.senhaUsuario = txtSenhaUser.Text;
                //MessageBox.Show(tipo.GetTiposDisponiveis().ToString());
                //MessageBox.Show(tipo.GetTiposDisponiveis().);
                SalvarUsuario.tipoPerfil = CbxTipodePerfil.Text;
                SalvarUsuario.usuarioAtivo = checkBox_UserAtivo.Checked;
                SalvarUsuario.idUsuario = idUsuario;

                SalvarUsuario.Salvar();
                ListaGrid();
                idUsuario = SalvarUsuario.idUsuario;
                txtSenhaUser.Text = "";
            }
            

        }

        private void bt_NovoUsuario_Click(object sender, EventArgs e)
        {
            idUsuario = 0;
            txtNome.Text = "";
            TxtLogin.Text = "";
            txtSenhaUser.Text = "";
            checkBox_UserAtivo.Checked = true;
            
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
            dgUsuarios.DataSource = infoUser.NavegaUsuarios();
            ConfiguraGrid();

        }

        private void ConfiguraGrid()
        {   
            //COLUNAS GRID
            dgUsuarios.Columns["nomeUsuario"].HeaderText = "Nome Usuário";
            dgUsuarios.Columns["tipoPerfil"].HeaderText = "Tipo de Perfil";
            dgUsuarios.Columns["usuarioAtivo"].HeaderText = "Usuário ativo";


            //COLUNA FICA INVISIVEL NO GRID
            dgUsuarios.Columns["idUsuario"].Visible = false;
            dgUsuarios.Columns["loginUsuario"].Visible = false;

            //COLUNAS SOMENTE LEITURA

            dgUsuarios.Columns["nomeUsuario"].ReadOnly = true;
        }

        

        private void txtSenhaUser_TextChanged(object sender, EventArgs e)
        {
            txtSenhaUser.PasswordChar = '*';
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = infoUser.BuscaUser(txt_Pesquisar.Text);

            ConfiguraGrid();
                        
        }

        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            


        }

        private bool ValidaCamposTela()
        {
            bool CamposOk;
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome do usuário");
                CamposOk = false;
            }
            else if (TxtLogin.Text == "")
            {

                MessageBox.Show("Informe o Login do usuário");
                CamposOk = false;
            }
            else if (txtSenhaUser.Text == "" && idUsuario == 0)
            {

                MessageBox.Show("Informa a senha do usuário");
                CamposOk = false;
            }

            else
            {

                CamposOk = true;
            }

            return CamposOk;
        }
            
    }
}
