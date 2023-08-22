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
            
            pessoaList = C_Pessoa.JsonDesserializarLista(@"C:\Users\luizs\OneDrive\Documentos\New\2º ano\3º bimestre 2\CastroPessoa.json");
            foreach (var pessoa in pessoaList)
            {
                comboBox1.Items.Add(pessoa.Nome);

            }
            try
            {
                processoList = C_Processo.JsonDesserializarLista(@"C:\Users\luizs\OneDrive\Documentos\New\2º ano\3º bimestre 2\Arquivo.json");
            }
            catch(Exception ex)
            {

            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = processoList;

            if (processoList.Count > 0)
            {
                button4.Enabled = true;
                button4.Visible = true;
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

                int index = dataGridView1.CurrentCell.RowIndex;
                C_Processo a = processoList[index];

                
                tx_vara.Text = a.Vara;
                tx_numero.Text = a.Numero;
                tx_descricao.Text = a.Descricao;
                comboBox1.Text = a.Pessoa;
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
                string pessoa = comboBox1.Text;
                
                if (numero != "" && descricao != "" && data != "" && vara != "" && tipo != "" && pessoa != "")
                {
                    C_Processo a = new C_Processo(numero, descricao, data, vara, tipo, pessoa);
                    processoList.Add(a);

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = processoList;

                    button4.Enabled = true;
                    button4.Visible = true;

                    var c_processo = a;
                    if (c_processo.JsonSerializarLista(processoList, @"C:\Users\luizs\OneDrive\Documentos\New\2º ano\3º bimestre 2\Arquivo.json")) ;
                    {
                        label3.Text = "";
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
                comboBox1.Text = string.Empty;
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
            if (c_processo.JsonSerializarLista(processoList, @"C:\Users\luizs\OneDrive\Documentos\New\2º ano\3º bimestre 2\Arquivo.json")) ;

            if (processoList.Count == 0)
            {
                button4.Enabled = false;
                button4.Visible = false;
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
            string pessoa = comboBox1.Text;
            string data = data_txtmask.Text;
            string tipo = tx_tipo.Text;

            C_Processo a = new C_Processo(numero, descricao, data, vara, tipo, pessoa);
            processoList.RemoveAt(index);
            processoList.Insert(index, a);


            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = processoList;
            }
            catch(Exception ex)
            {
                MessageBox.Show( $"Erro{ ex.Message}");
            }
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
            dataGridView1.Enabled = true;
            var c_processo = new C_Processo();
            if (c_processo.JsonSerializarLista(processoList, @"C:\Users\luizs\OneDrive\Documentos\New\2º ano\3º bimestre 2\Arquivo.json")) ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //processoList = C_Processo.JsonDesserializarLista(@"C:\Users\carol\OneDrive\Documentos\json\arquivoProcesso.json");

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = processoList;
        }
    }
}
