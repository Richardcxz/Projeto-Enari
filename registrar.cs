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
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //código edd necessário
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                Projeto_Enari.Program.cacheteste.Add("Nome",textBox1.Text,null);
                Projeto_Enari.Program.cacheteste.Add("Senha", textBox2.Text, null);

                MessageBox.Show("Registro realizado!");
                this.Hide();
                var rstd = new Form1();
                rstd.Show();
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio!");
            }
        }
    }
}
