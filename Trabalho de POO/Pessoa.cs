using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho_de_POO
{
    public partial class Pessoa : Form
    {
        public List<C_Pessoa > pessoaList = new List<C_Pessoa>();
        
        public Pessoa()
        {

            InitializeComponent();
            try
            {
                pessoaList = C_Pessoa.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pessoaList;

                if (pessoaList.Count > 0)
                {
                    button_editar.Enabled = true;
                    button_editar.Visible = true;
                }
            } catch (Exception ex)
            { 
            
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

                if (ValidarCPF.ValidaCPF(CPF_txtmask.Text) == false)
                {
                    txt_cpf_invalido.Text = "CPF inválido, insira outro novamente";
                }
                else
                {
                    txt_cpf_invalido.Text = "";
                    int index = dataGridView1.CurrentCell.RowIndex;
                    string nome = Nome_txt.Text;
                    string email = Email_txt.Text;
                    string cpf = CPF_txtmask.Text;
                    string endereco = Endereco_txt.Text;
                    string telefone = Telefone_txtmask.Text;
                    string rg = RG_txt.Text;



                    if (nome != "" && cpf != "" && telefone != "" && email != "" && endereco != "" && rg != "")
                    {
                        txt_falta_Info.Text = "";
                        if (ValidarCPF.ValidaCPF(CPF_txtmask.Text) == false)
                        {
                            txt_cpf_invalido.Text = "CPF inválido, insira outro novamente";
                        }
                        else
                        {
                            C_Pessoa a = pessoaList[index];
                            bool verificacao = ValidarCPF.CPF_existente_Editar(cpf, pessoaList,a.CPF);

                            if (verificacao)
                            {
                                a = new C_Pessoa(nome, cpf, telefone, email, endereco, rg);
                                pessoaList.RemoveAt(index);
                                pessoaList.Insert(index, a);

                                dataGridView1.DataSource = null;
                                dataGridView1.Refresh();
                                dataGridView1.DataSource = pessoaList;

                                txt_falta_Info.Text = "";
                                button_editar.Enabled = true;
                                button_editar.Visible = true;

                                button_salvaredit.Enabled = false;
                                button_salvaredit.Visible = false;

                                button_novo.Enabled = true;
                                button_novo.Visible = true;

                                button_excluir.Enabled = true;
                                button_excluir.Visible = true;

                                button_salvar.Enabled = true;
                                button_salvar.Visible = true;

                                button_menu.Enabled = true;
                                button_menu.Visible = true;
                                dataGridView1.Enabled = true;
                            }
                            else
                            {
                                txt_cpf_invalido.Text = "CPF já foi cadastrado";
                            }
                        }
                    }
                    else
                    {
                        txt_falta_Info.Text = "Falta informações";
                    }
                    
                    
                }
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

                txt_cpf_invalido.Text = "";
                
                string nome = Nome_txt.Text;
                string email = Email_txt.Text;
                string cpf = CPF_txtmask.Text;
                string endereco = Endereco_txt.Text;
                string telefone = Telefone_txtmask.Text;
                string rg = RG_txt.Text;


                if (nome != "" && cpf != "" && telefone != "" && email != "" && endereco != "" && rg != "")
                {
                    txt_falta_Info.Text = "";
                    if (ValidarCPF.ValidaCPF(CPF_txtmask.Text) == false)
                    {
                        txt_cpf_invalido.Text = "CPF inválido, insira outro novamente";
                    }
                    else
                    {
                        bool verificacao = ValidarCPF.CPF_existente(cpf,pessoaList);
                        
                        if (verificacao)
                        {
                            C_Pessoa a = new C_Pessoa(nome, cpf, telefone, email, endereco, rg);
                            pessoaList.Add(a);

                            dataGridView1.DataSource = null;
                            dataGridView1.Refresh();
                            dataGridView1.DataSource = pessoaList;

                            txt_falta_Info.Text = "";
                            button_editar.Enabled = true;
                            button_editar.Visible = true;
                        }
                        else
                        {
                            txt_cpf_invalido.Text = "CPF já foi cadastrado";
                        }
                    }
                }
                else
                {
                    txt_falta_Info.Text = "Falta informações";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var c_pessoa = new C_Pessoa();
            if (c_pessoa.JsonSerializarLista(pessoaList, @"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json"));
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (pessoaList.Count>0)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    pessoaList.RemoveAt(index);

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = pessoaList;

                    var c_pessoa = new C_Pessoa();
                    if (c_pessoa.JsonSerializarLista(pessoaList, @"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json")) ;
                }
                else { MessageBox.Show("Lista já está vazia"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (pessoaList.Count == 0)
            {
                button_editar.Enabled = false;
                button_editar.Visible = false;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button_salvaredit.Enabled = true;
                button_salvaredit.Visible = true;

                button_novo.Enabled = false;
                button_novo.Visible = false;

                button_excluir.Enabled = false;
                button_excluir.Visible = false;

                button_salvar.Enabled = false;
                button_salvar.Visible = false;

                button_menu.Enabled = false;
                button_menu.Visible = false;

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
