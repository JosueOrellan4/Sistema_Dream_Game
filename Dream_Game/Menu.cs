using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadJogos form = new CadJogos();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerenciamento_Jogos form = new Gerenciamento_Jogos();
            form.ShowDialog();
        }
    }
}
