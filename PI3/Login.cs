using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace PI3
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
            
        }
        //tela login
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // label login
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //label senha
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Campo texto login
        private void textLogin_TextChanged(object sender, EventArgs e)
        {

            //string login = textLogin.Text;
        }

        //Campo texto senha
        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            textSenha.PasswordChar = '*';
            //string senha = textSenha.Text;
        }
        
        //PERMITE LOGAR APERTANDO TECLA ENTER
        private void Tela_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                bt_entrar_Click(sender, e);

            }

        }       

        //botao Entrar
        private void bt_entrar_Click(object sender, EventArgs e)
        {
            

           
            ClsUsuario usuarioLogin = ClsUsuario.Logar(textLogin.Text,textSenha.Text);

            if (usuarioLogin == null)
            {
                MessageBox.Show("Login inválido");

            }

            else {
                
                Menu Tela_Menu = new Menu();                
                Tela_Menu.ShowDialog();
                
                

            }
            

            
            
        }


        
    }
}
