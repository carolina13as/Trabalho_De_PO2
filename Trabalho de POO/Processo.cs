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
    public partial class Processo : Form
    {
        public List<C_Processo> processoList = new List<C_Processo>();
        public Processo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            tx_vara.Text = processoList[index].Vara;
            tx_numero.Text = processoList[index].Numero;
            tx_descricao.Text = processoList[index].Descricao;
            processoList[index].Pessoa = tx_pessoa.Text;
            tx_data.Text = processoList[index].Data;
            tx_tipo.Text = processoList[index].Tipo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string numero = tx_numero.Text;
            string descricao = tx_descricao.Text;
            string data = tx_data.Text;
            string vara = tx_vara.Text;
            string tipo = tx_tipo.Text;
            string pessoa = tx_pessoa.Text;

            C_Processo a = new C_Processo(numero, descricao, data, vara, tipo, pessoa);
            processoList.Add(a);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = processoList;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_data.Text = string.Empty;
            tx_descricao.Text = string.Empty;
            tx_numero.Text = string.Empty;
            tx_pessoa.Text = string.Empty;
            tx_tipo.Text = string.Empty;
            tx_vara.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            processoList.RemoveAt(index);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = processoList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            processoList[index].Vara = tx_vara.Text;
            processoList[index].Numero = tx_numero.Text;
            processoList[index].Descricao = tx_descricao.Text;
            processoList[index].Pessoa = tx_pessoa.Text;
            processoList[index].Data = tx_data.Text;
            processoList[index].Tipo = tx_tipo.Text;

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = processoList;
        }
    }
}
