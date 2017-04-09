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
            string login;
            login = Console.ReadLine();
        }

        //Campo texto senha
        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            string senha;
            senha = Console.ReadLine();
        }

        //botao Entrar
        private void bt_entrar_Click(object sender, EventArgs e)
        {
            Menu Tela_Menu = new Menu();
            Tela_Menu.Show();
        }
    }
}
