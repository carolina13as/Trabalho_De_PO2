using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_POO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Processo a = new Processo();
            a.ShowDialog();
            
        }


        List<C_Pessoa> Lista = new List<C_Pessoa>();


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pessoa a = new Pessoa();
            a.ShowDialog();
            
        }

    }
}
