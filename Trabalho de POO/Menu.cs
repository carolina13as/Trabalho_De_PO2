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
        List<C_Pessoa> list = new List<C_Pessoa> ();
        public Menu()
        {
            InitializeComponent();
            try
            {
                list = C_Pessoa.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json");
                if (list.Count > 0)
                {
                    button1.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                
            }
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

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
