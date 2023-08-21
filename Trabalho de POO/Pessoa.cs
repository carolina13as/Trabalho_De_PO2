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
        public List<C_Pessoa > pessoaList = new List<C_Pessoa>();

        public Pessoa()
        {
            InitializeComponent();

            pessoaList = C_Pessoa.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pessoaList;

            if(pessoaList.Count > 0)
            {
                button4.Enabled = true;
                button4.Visible = true;
            }
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
            try
            {


                int index = dataGridView1.CurrentCell.RowIndex;
                string nome = Nome_txt.Text;
                string email = Email_txt.Text;
                string cpf = CPF_txtmask.Text;
                string endereco = Endereco_txt.Text;
                string telefone = Telefone_txtmask.Text;
                string rg = RG_txt.Text;

                C_Pessoa a = new C_Pessoa(nome, cpf, telefone, email, endereco, rg);
                pessoaList.RemoveAt(index);
                pessoaList.Insert(index,a);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = pessoaList;
                
                button1.Enabled = false;
                button1.Visible = false;

                button2.Enabled = true;
                button2.Visible = true;

                button3.Enabled = true;
                button3.Visible = true;

                button5.Enabled = true;
                button5.Visible = true;

                button6.Enabled = true;
                button6.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Enabled = true;
                button4.Visible = true;


                string nome = Nome_txt.Text;
                string email = Email_txt.Text;
                string cpf = CPF_txtmask.Text;
                string endereco = Endereco_txt.Text;
                string telefone = Telefone_txtmask.Text;
                string rg = RG_txt.Text;
                if (nome != "" && cpf != "" && telefone != "" && email != "" && endereco != "" && rg != "")
                {
                    C_Pessoa a = new C_Pessoa(nome, cpf, telefone, email, endereco, rg);
                    pessoaList.Add(a);

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = pessoaList;

                    label3.Text = "";
                }
                else
                {
                    label8.Text = "Falta informações";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var c_pessoa = new C_Pessoa();
            if (c_pessoa.JsonSerializarLista(pessoaList, @"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json")) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                pessoaList.RemoveAt(index);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = pessoaList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (pessoaList.Count == 0)
            {
                button4.Enabled = false;
                button4.Visible = false;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button1.Visible = true;

                button2.Enabled = false;
                button2.Visible = false;

                button3.Enabled = false;
                button3.Visible = false;

                button5.Enabled = false;
                button5.Visible = false;

                button6.Enabled = false;
                button6.Visible = false;

                C_Pessoa p = new C_Pessoa();
                p = pessoaList[dataGridView1.CurrentCell.RowIndex];
                Nome_txt.Text = p.Nome;
                CPF_txtmask.Text = p.CPF;
                Telefone_txtmask.Text = p.Telefone;
                Email_txt.Text = p.Email;
                Endereco_txt.Text = p.Endereco;
                RG_txt.Text = p.RG;

                dataGridView1.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = pessoaList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //pessoaList = C_Pessoa.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json");

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = pessoaList;
        }
    }
}
