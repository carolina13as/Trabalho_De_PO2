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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // os nomes dos campos estão modificados, o combombox ta combo e seu numero em ordem
        //EX: combom_1
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo();
            processo.ShowDialog();
        }
    }
}
