using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Caching;

namespace Projeto_Enari
{
    public partial class logar : Form
    {
        public logar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = (string)Projeto_Enari.Program.cacheteste.Get("Nome");
            string sen = (string)Projeto_Enari.Program.cacheteste.Get("Senha");
            if (textBox1.Text == log && textBox2.Text == sen) {
                MessageBox.Show("Login realizado!");
                this.Hide();
                var menulog = new menu();
                menulog.Show();
            }
            else if(textBox1.Text != log || textBox2.Text != sen)
            {
                MessageBox.Show("Login/Senha inválidas!");
            }
        }
    }
}
