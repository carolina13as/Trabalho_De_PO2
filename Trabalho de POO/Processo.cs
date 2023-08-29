using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Trabalho_de_POO
{
    public partial class Processo : Form
    {
        public List<C_Processo> processoList = new List<C_Processo>();
        public List<C_Pessoa> pessoaList = new List<C_Pessoa>();
        


        
        public Processo()
        {
            InitializeComponent();
            
            
            try
            {
                pessoaList = C_Pessoa.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoPessoa.json");
                foreach (var pessoa in pessoaList)
                {
                    comboBox_Pessoa.Items.Add(pessoa.CPF);
                }

                processoList = C_Processo.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoProcesso.json");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = processoList;
                if (processoList.Count > 0)
                {
                    button_editar.Enabled = true;
                    button_editar.Visible = true;
                }

                tx_numero.Text = N_Processo.Pro(processoList);
                if(processoList == null)
                {
                    tx_numero.Text = "1";
                }
            }
            catch(Exception ex)
            {

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

                int index = dataGridView1.CurrentCell.RowIndex;
                C_Processo a = processoList[index];

                
                tx_vara.Text = a.Vara;
                tx_numero.Text = a.Numero;
                tx_descricao.Text = a.Descricao;
                comboBox_Pessoa.Text = a.Pessoa;
                data_txtmask.Text = a.Data;
                tx_tipo.Text = a.Tipo;
                dataGridView1.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                string numero = tx_numero.Text;
                string descricao = tx_descricao.Text;
                string data = data_txtmask.Text;
                string vara = tx_vara.Text;
                string tipo = tx_tipo.Text;
                string pessoa = comboBox_Pessoa.Text;
                
                if (numero != "" && descricao != "" && data != "" && vara != "" && tipo != "" && pessoa != "")
                {
                    if(Verificar_Cliente.Cliente_Valido(pessoa, pessoaList))
                    {
                        C_Processo a = new C_Processo(numero, descricao, data, vara, tipo, pessoa);
                        processoList.Add(a);

                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = processoList;

                        button_editar.Enabled = true;
                        button_editar.Visible = true;

                        var c_processo = a;
                        if (c_processo.JsonSerializarLista(processoList, @"C:\Users\carol\OneDrive\Documentos\json\arquivoProcesso.json")) ;
                        {
                            label3.Text = "";
                        }
                        tx_numero.Text = N_Processo.Pro(processoList);
                    }
                    else
                    {
                        label3.Text = "Cliente não cadastrado";
                    }
                }
                else
                {
                    label3.Text = "Falta informações";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Menu a = new Menu();
                a.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                data_txtmask.Text = string.Empty;
                tx_descricao.Text = string.Empty;
                tx_numero.Text = string.Empty;
                comboBox_Pessoa.Text = string.Empty;
                tx_tipo.Text = string.Empty;
                tx_vara.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (processoList.Count > 0)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    processoList.RemoveAt(index);

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = processoList;
                    tx_numero.Text = N_Processo.Pro(processoList);
                }
                else
                {
                    MessageBox.Show("A lista já está vazia");
                }
                
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show($"Erro{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro{ex.Message}");
            }

            var c_processo = new C_Processo();
            if (c_processo.JsonSerializarLista(processoList, @"C:\Users\carol\OneDrive\Documentos\json\arquivoProcesso.json")) ;

            if (processoList.Count == 0)
            {
                button_editar.Enabled = false;
                button_editar.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                string vara = tx_vara.Text;
                string numero = tx_numero.Text;
                string descricao = tx_descricao.Text;
                string pessoa = comboBox_Pessoa.Text;
                string data = data_txtmask.Text;
                string tipo = tx_tipo.Text;

                if (Verificar_Cliente.Cliente_Valido(pessoa, pessoaList))
                {
                    C_Processo a = new C_Processo(numero, descricao, data, vara, tipo, pessoa);
                    processoList.RemoveAt(index);
                    processoList.Insert(index, a);


                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = processoList;

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
                    var c_processo = new C_Processo();
                    if (c_processo.JsonSerializarLista(processoList, @"C:\Users\carol\OneDrive\Documentos\json\arquivoProcesso.json")) ;
                }
                else
                {
                    label3.Text = "Cliente não cadastrado";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( $"Erro{ ex.Message}");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //processoList = C_Processo.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoProcesso.json");

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = processoList;
        }

        private void comboBox_Pessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
