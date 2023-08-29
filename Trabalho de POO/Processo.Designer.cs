namespace Trabalho_de_POO
{
    partial class Processo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processo));
            this.label1 = new System.Windows.Forms.Label();
            this.lab_1 = new System.Windows.Forms.Label();
            this.lab_2 = new System.Windows.Forms.Label();
            this.lab_6 = new System.Windows.Forms.Label();
            this.lab_3 = new System.Windows.Forms.Label();
            this.lab_7 = new System.Windows.Forms.Label();
            this.tx_numero = new System.Windows.Forms.TextBox();
            this.tx_tipo = new System.Windows.Forms.TextBox();
            this.button_novo = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.tx_descricao = new System.Windows.Forms.TextBox();
            this.tx_vara = new System.Windows.Forms.TextBox();
            this.button_salvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_salvaredit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.data_txtmask = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Pessoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Processo";
            // 
            // lab_1
            // 
            this.lab_1.AutoSize = true;
            this.lab_1.BackColor = System.Drawing.Color.Transparent;
            this.lab_1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_1.Location = new System.Drawing.Point(12, 130);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(47, 37);
            this.lab_1.TabIndex = 1;
            this.lab_1.Text = "Nº:";
            // 
            // lab_2
            // 
            this.lab_2.AutoSize = true;
            this.lab_2.BackColor = System.Drawing.Color.Transparent;
            this.lab_2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_2.Location = new System.Drawing.Point(12, 212);
            this.lab_2.Name = "lab_2";
            this.lab_2.Size = new System.Drawing.Size(129, 37);
            this.lab_2.TabIndex = 2;
            this.lab_2.Text = "Descrição:";
            // 
            // lab_6
            // 
            this.lab_6.AutoSize = true;
            this.lab_6.BackColor = System.Drawing.Color.Transparent;
            this.lab_6.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_6.Location = new System.Drawing.Point(459, 124);
            this.lab_6.Name = "lab_6";
            this.lab_6.Size = new System.Drawing.Size(71, 37);
            this.lab_6.TabIndex = 3;
            this.lab_6.Text = "Tipo:";
            // 
            // lab_3
            // 
            this.lab_3.AutoSize = true;
            this.lab_3.BackColor = System.Drawing.Color.Transparent;
            this.lab_3.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_3.Location = new System.Drawing.Point(12, 305);
            this.lab_3.Name = "lab_3";
            this.lab_3.Size = new System.Drawing.Size(131, 37);
            this.lab_3.TabIndex = 4;
            this.lab_3.Text = "Data inicio:";
            // 
            // lab_7
            // 
            this.lab_7.AutoSize = true;
            this.lab_7.BackColor = System.Drawing.Color.Transparent;
            this.lab_7.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_7.Location = new System.Drawing.Point(460, 212);
            this.lab_7.Name = "lab_7";
            this.lab_7.Size = new System.Drawing.Size(70, 37);
            this.lab_7.TabIndex = 5;
            this.lab_7.Text = "Vara:";
            // 
            // tx_numero
            // 
            this.tx_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_numero.Enabled = false;
            this.tx_numero.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_numero.Location = new System.Drawing.Point(65, 130);
            this.tx_numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_numero.Name = "tx_numero";
            this.tx_numero.Size = new System.Drawing.Size(60, 31);
            this.tx_numero.TabIndex = 8;
            this.tx_numero.Text = "1";
            // 
            // tx_tipo
            // 
            this.tx_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_tipo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_tipo.Location = new System.Drawing.Point(551, 124);
            this.tx_tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_tipo.Name = "tx_tipo";
            this.tx_tipo.Size = new System.Drawing.Size(199, 31);
            this.tx_tipo.TabIndex = 12;
            // 
            // button_novo
            // 
            this.button_novo.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_novo.Location = new System.Drawing.Point(379, 421);
            this.button_novo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(111, 49);
            this.button_novo.TabIndex = 19;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = true;
            this.button_novo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(245, 421);
            this.button_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(110, 49);
            this.button_excluir.TabIndex = 20;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_editar
            // 
            this.button_editar.Enabled = false;
            this.button_editar.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(19, 368);
            this.button_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(110, 49);
            this.button_editar.TabIndex = 21;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Visible = false;
            this.button_editar.Click += new System.EventHandler(this.button4_Click);
            // 
            // tx_descricao
            // 
            this.tx_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_descricao.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_descricao.Location = new System.Drawing.Point(147, 212);
            this.tx_descricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_descricao.Name = "tx_descricao";
            this.tx_descricao.Size = new System.Drawing.Size(258, 31);
            this.tx_descricao.TabIndex = 22;
            // 
            // tx_vara
            // 
            this.tx_vara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_vara.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_vara.Location = new System.Drawing.Point(551, 212);
            this.tx_vara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_vara.Name = "tx_vara";
            this.tx_vara.Size = new System.Drawing.Size(159, 31);
            this.tx_vara.TabIndex = 23;
            // 
            // button_salvar
            // 
            this.button_salvar.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.Location = new System.Drawing.Point(513, 421);
            this.button_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(116, 49);
            this.button_salvar.TabIndex = 25;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 236);
            this.dataGridView1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pessoa:";
            // 
            // button_menu
            // 
            this.button_menu.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.Location = new System.Drawing.Point(650, 421);
            this.button_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(213, 49);
            this.button_menu.TabIndex = 30;
            this.button_menu.Text = "Voltar ao Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_salvaredit
            // 
            this.button_salvaredit.Enabled = false;
            this.button_salvaredit.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvaredit.Location = new System.Drawing.Point(19, 421);
            this.button_salvaredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_salvaredit.Name = "button_salvaredit";
            this.button_salvaredit.Size = new System.Drawing.Size(186, 49);
            this.button_salvaredit.TabIndex = 31;
            this.button_salvaredit.Text = "Salvar Edição";
            this.button_salvaredit.UseVisualStyleBackColor = true;
            this.button_salvaredit.Visible = false;
            this.button_salvaredit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(571, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 32;
            // 
            // data_txtmask
            // 
            this.data_txtmask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_txtmask.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_txtmask.Location = new System.Drawing.Point(162, 305);
            this.data_txtmask.Mask = "00/00/0000";
            this.data_txtmask.Name = "data_txtmask";
            this.data_txtmask.Size = new System.Drawing.Size(172, 31);
            this.data_txtmask.TabIndex = 33;
            // 
            // comboBox_Pessoa
            // 
            this.comboBox_Pessoa.FormattingEnabled = true;
            this.comboBox_Pessoa.Location = new System.Drawing.Point(542, 299);
            this.comboBox_Pessoa.Name = "comboBox_Pessoa";
            this.comboBox_Pessoa.Size = new System.Drawing.Size(240, 24);
            this.comboBox_Pessoa.TabIndex = 34;
            this.comboBox_Pessoa.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pessoa_SelectedIndexChanged);
            // 
            // Processo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Trabalho_de_POO.Properties.Resources.imagem3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 733);
            this.Controls.Add(this.comboBox_Pessoa);
            this.Controls.Add(this.data_txtmask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_salvaredit);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.tx_vara);
            this.Controls.Add(this.tx_descricao);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.tx_tipo);
            this.Controls.Add(this.tx_numero);
            this.Controls.Add(this.lab_7);
            this.Controls.Add(this.lab_3);
            this.Controls.Add(this.lab_6);
            this.Controls.Add(this.lab_2);
            this.Controls.Add(this.lab_1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Processo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Processos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_1;
        private System.Windows.Forms.Label lab_2;
        private System.Windows.Forms.Label lab_6;
        private System.Windows.Forms.Label lab_3;
        private System.Windows.Forms.Label lab_7;
        private System.Windows.Forms.TextBox tx_numero;
        private System.Windows.Forms.TextBox tx_tipo;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.TextBox tx_vara;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_descricao;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_salvaredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox data_txtmask;
        private System.Windows.Forms.ComboBox comboBox_Pessoa;
    }
}

