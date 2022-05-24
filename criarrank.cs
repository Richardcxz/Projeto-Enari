using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Enari
{
    public partial class criarrank : Form
    {
        public criarrank()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CÓDIGO EDD AQUI
            MessageBox.Show("Ranking Criado!");
            this.Hide();
            var mn = new menu();
            mn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mn = new menu();
            mn.Show();
        }
    }
}
