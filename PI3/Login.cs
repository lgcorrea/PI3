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

        private void bt2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            
            Menu tlDep = new Menu();
            tlDep.Show();
                      

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string senha;
            senha = Console.ReadLine();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            string login;
            login = Console.ReadLine();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
