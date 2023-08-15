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
    public partial class Pessoa : Form
    {

        public Pessoa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nome_txt.Text = "";
            Email_txt.Text = "";
            CPF_txtmask.Text = "";
            Endereco_txt.Text = "";
            Telefone_txtmask.Text = "";
            RG_txt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nome = Nome_txt.Text;
            string email = Email_txt.Text;
            string cpf = CPF_txtmask.Text;
            string endereco = Endereco_txt.Text;
            string telefone = Telefone_txtmask.Text;
            string rg = RG_txt.Text;

            C_Pessoa a = new C_Pessoa(nome,cpf,telefone,email,endereco,rg);
        }
    }
}
