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
    public partial class votar : Form
    {
        public votar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CÓDIGO EDD AQUI
            MessageBox.Show("Voto confirmado!");
            this.Hide();
            var mn = new menu();
            mn.Show();
        }
    }
}
