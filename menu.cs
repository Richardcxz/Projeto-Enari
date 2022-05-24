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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var unlog = new Form1();
            unlog.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var amig = new friends();
            amig.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cr = new criarrank();
            cr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vote = new votar();
            vote.Show();
        }
    }
}
