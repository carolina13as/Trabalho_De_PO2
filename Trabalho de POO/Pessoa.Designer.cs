namespace Trabalho_de_POO
{
    partial class Pessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pessoa));
            this.txt_nome = new System.Windows.Forms.Label();
            this.Nome_txt = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Endereco_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.Label();
            this.RG_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_salvaredit = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_novo = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.CPF_txtmask = new System.Windows.Forms.MaskedTextBox();
            this.Telefone_txtmask = new System.Windows.Forms.MaskedTextBox();
            this.button_menu = new System.Windows.Forms.Button();
            this.txt_falta_Info = new System.Windows.Forms.Label();
            this.txt_cpf_invalido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.BackColor = System.Drawing.Color.Transparent;
            this.txt_nome.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(12, 136);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(87, 37);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Nome:";
            // 
            // Nome_txt
            // 
            this.Nome_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nome_txt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_txt.Location = new System.Drawing.Point(101, 136);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(254, 31);
            this.Nome_txt.TabIndex = 1;
            // 
            // txt_cpf
            // 
            this.txt_cpf.AutoSize = true;
            this.txt_cpf.BackColor = System.Drawing.Color.Transparent;
            this.txt_cpf.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(12, 235);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(69, 37);
            this.txt_cpf.TabIndex = 2;
            this.txt_cpf.Text = "CPF:";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(550, 136);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(82, 37);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "Email:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.AutoSize = true;
            this.txt_telefone.BackColor = System.Drawing.Color.Transparent;
            this.txt_telefone.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(12, 325);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(118, 37);
            this.txt_telefone.TabIndex = 4;
            this.txt_telefone.Text = "Telefone:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.AutoSize = true;
            this.txt_endereco.BackColor = System.Drawing.Color.Transparent;
            this.txt_endereco.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(494, 229);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(126, 37);
            this.txt_endereco.TabIndex = 5;
            this.txt_endereco.Text = "Endereço:";
            // 
            // Email_txt
            // 
            this.Email_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_txt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.Location = new System.Drawing.Point(668, 136);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(226, 31);
            this.Email_txt.TabIndex = 7;
            // 
            // Endereco_txt
            // 
            this.Endereco_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Endereco_txt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco_txt.Location = new System.Drawing.Point(645, 235);
            this.Endereco_txt.Name = "Endereco_txt";
            this.Endereco_txt.Size = new System.Drawing.Size(222, 31);
            this.Endereco_txt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 57);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastro de Pessoas";
            // 
            // txt_rg
            // 
            this.txt_rg.AutoSize = true;
            this.txt_rg.BackColor = System.Drawing.Color.Transparent;
            this.txt_rg.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rg.Location = new System.Drawing.Point(549, 315);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(56, 37);
            this.txt_rg.TabIndex = 11;
            this.txt_rg.Text = "RG:";
            // 
            // RG_txt
            // 
            this.RG_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG_txt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG_txt.Location = new System.Drawing.Point(611, 315);
            this.RG_txt.Name = "RG_txt";
            this.RG_txt.Size = new System.Drawing.Size(129, 31);
            this.RG_txt.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 534);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 245);
            this.dataGridView1.TabIndex = 13;
            // 
            // button_salvaredit
            // 
            this.button_salvaredit.Enabled = false;
            this.button_salvaredit.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvaredit.Location = new System.Drawing.Point(12, 445);
            this.button_salvaredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_salvaredit.Name = "button_salvaredit";
            this.button_salvaredit.Size = new System.Drawing.Size(186, 49);
            this.button_salvaredit.TabIndex = 15;
            this.button_salvaredit.Text = "Salvar Edição";
            this.button_salvaredit.UseVisualStyleBackColor = true;
            this.button_salvaredit.Visible = false;
            this.button_salvaredit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_editar
            // 
            this.button_editar.Enabled = false;
            this.button_editar.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.Location = new System.Drawing.Point(12, 388);
            this.button_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(110, 49);
            this.button_editar.TabIndex = 22;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Visible = false;
            this.button_editar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(245, 445);
            this.button_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(110, 49);
            this.button_excluir.TabIndex = 23;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_novo
            // 
            this.button_novo.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_novo.Location = new System.Drawing.Point(361, 445);
            this.button_novo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(111, 49);
            this.button_novo.TabIndex = 24;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = true;
            this.button_novo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.Location = new System.Drawing.Point(478, 445);
            this.button_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(127, 49);
            this.button_salvar.TabIndex = 26;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button5_Click);
            // 
            // CPF_txtmask
            // 
            this.CPF_txtmask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_txtmask.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_txtmask.Location = new System.Drawing.Point(101, 235);
            this.CPF_txtmask.Mask = "000,000,000-00";
            this.CPF_txtmask.Name = "CPF_txtmask";
            this.CPF_txtmask.Size = new System.Drawing.Size(172, 31);
            this.CPF_txtmask.TabIndex = 27;
            // 
            // Telefone_txtmask
            // 
            this.Telefone_txtmask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Telefone_txtmask.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_txtmask.Location = new System.Drawing.Point(136, 327);
            this.Telefone_txtmask.Mask = "(00) 0000-0000";
            this.Telefone_txtmask.Name = "Telefone_txtmask";
            this.Telefone_txtmask.Size = new System.Drawing.Size(172, 31);
            this.Telefone_txtmask.TabIndex = 28;
            // 
            // button_menu
            // 
            this.button_menu.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.Location = new System.Drawing.Point(705, 445);
            this.button_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(213, 49);
            this.button_menu.TabIndex = 29;
            this.button_menu.Text = "Voltar ao Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_falta_Info
            // 
            this.txt_falta_Info.AutoSize = true;
            this.txt_falta_Info.BackColor = System.Drawing.Color.Transparent;
            this.txt_falta_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_falta_Info.ForeColor = System.Drawing.Color.Red;
            this.txt_falta_Info.Location = new System.Drawing.Point(589, 372);
            this.txt_falta_Info.Name = "txt_falta_Info";
            this.txt_falta_Info.Size = new System.Drawing.Size(0, 32);
            this.txt_falta_Info.TabIndex = 33;
            // 
            // txt_cpf_invalido
            // 
            this.txt_cpf_invalido.AutoSize = true;
            this.txt_cpf_invalido.Location = new System.Drawing.Point(101, 273);
            this.txt_cpf_invalido.Name = "txt_cpf_invalido";
            this.txt_cpf_invalido.Size = new System.Drawing.Size(0, 16);
            this.txt_cpf_invalido.TabIndex = 34;
            // 
            // Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::Trabalho_de_POO.Properties.Resources.imagem3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 805);
            this.Controls.Add(this.txt_cpf_invalido);
            this.Controls.Add(this.txt_falta_Info);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.Telefone_txtmask);
            this.Controls.Add(this.CPF_txtmask);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_salvaredit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RG_txt);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Endereco_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.Nome_txt);
            this.Controls.Add(this.txt_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pessoa";
            this.Text = "Pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.TextBox Nome_txt;
        private System.Windows.Forms.Label txt_cpf;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_telefone;
        private System.Windows.Forms.Label txt_endereco;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Endereco_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_rg;
        private System.Windows.Forms.TextBox RG_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_salvaredit;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.MaskedTextBox CPF_txtmask;
        private System.Windows.Forms.MaskedTextBox Telefone_txtmask;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Label txt_falta_Info;
        private System.Windows.Forms.Label txt_cpf_invalido;
    }
}