namespace Trabalho_de_POO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lab_1 = new System.Windows.Forms.Label();
            this.lab_2 = new System.Windows.Forms.Label();
            this.lab_6 = new System.Windows.Forms.Label();
            this.lab_3 = new System.Windows.Forms.Label();
            this.lab_7 = new System.Windows.Forms.Label();
            this.lab_4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_1 = new System.Windows.Forms.TextBox();
            this.text_3 = new System.Windows.Forms.TextBox();
            this.text_6 = new System.Windows.Forms.TextBox();
            this.lab_5 = new System.Windows.Forms.Label();
            this.combo_4 = new System.Windows.Forms.ComboBox();
            this.combo_5 = new System.Windows.Forms.ComboBox();
            this.text_mask_7 = new System.Windows.Forms.MaskedTextBox();
            this.text_mask_2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
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
            this.lab_1.Location = new System.Drawing.Point(12, 131);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(87, 37);
            this.lab_1.TabIndex = 1;
            this.lab_1.Text = "Nome:";
            // 
            // lab_2
            // 
            this.lab_2.AutoSize = true;
            this.lab_2.BackColor = System.Drawing.Color.Transparent;
            this.lab_2.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_2.Location = new System.Drawing.Point(12, 212);
            this.lab_2.Name = "lab_2";
            this.lab_2.Size = new System.Drawing.Size(69, 37);
            this.lab_2.TabIndex = 2;
            this.lab_2.Text = "CPF:";
            // 
            // lab_6
            // 
            this.lab_6.AutoSize = true;
            this.lab_6.BackColor = System.Drawing.Color.Transparent;
            this.lab_6.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_6.Location = new System.Drawing.Point(505, 275);
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
            this.lab_3.Size = new System.Drawing.Size(126, 37);
            this.lab_3.TabIndex = 4;
            this.lab_3.Text = "Endereço:";
            // 
            // lab_7
            // 
            this.lab_7.AutoSize = true;
            this.lab_7.BackColor = System.Drawing.Color.Transparent;
            this.lab_7.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_7.Location = new System.Drawing.Point(458, 358);
            this.lab_7.Name = "lab_7";
            this.lab_7.Size = new System.Drawing.Size(118, 37);
            this.lab_7.TabIndex = 5;
            this.lab_7.Text = "Telefone:";
            // 
            // lab_4
            // 
            this.lab_4.AutoSize = true;
            this.lab_4.BackColor = System.Drawing.Color.Transparent;
            this.lab_4.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_4.Location = new System.Drawing.Point(388, 131);
            this.lab_4.Name = "lab_4";
            this.lab_4.Size = new System.Drawing.Size(251, 37);
            this.lab_4.TabIndex = 6;
            this.lab_4.Text = "Grau de Escolaridade:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_1
            // 
            this.text_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_1.Location = new System.Drawing.Point(105, 137);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(176, 31);
            this.text_1.TabIndex = 8;
            // 
            // text_3
            // 
            this.text_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_3.Location = new System.Drawing.Point(134, 305);
            this.text_3.Name = "text_3";
            this.text_3.Size = new System.Drawing.Size(160, 31);
            this.text_3.TabIndex = 10;
            // 
            // text_6
            // 
            this.text_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_6.Location = new System.Drawing.Point(591, 276);
            this.text_6.Name = "text_6";
            this.text_6.Size = new System.Drawing.Size(199, 31);
            this.text_6.TabIndex = 12;
            // 
            // lab_5
            // 
            this.lab_5.AutoSize = true;
            this.lab_5.BackColor = System.Drawing.Color.Transparent;
            this.lab_5.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_5.Location = new System.Drawing.Point(489, 197);
            this.lab_5.Name = "lab_5";
            this.lab_5.Size = new System.Drawing.Size(87, 37);
            this.lab_5.TabIndex = 14;
            this.lab_5.Text = "Status:";
            // 
            // combo_4
            // 
            this.combo_4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_4.FormattingEnabled = true;
            this.combo_4.Location = new System.Drawing.Point(645, 128);
            this.combo_4.Name = "combo_4";
            this.combo_4.Size = new System.Drawing.Size(207, 34);
            this.combo_4.TabIndex = 15;
            // 
            // combo_5
            // 
            this.combo_5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_5.FormattingEnabled = true;
            this.combo_5.Location = new System.Drawing.Point(591, 197);
            this.combo_5.Name = "combo_5";
            this.combo_5.Size = new System.Drawing.Size(216, 34);
            this.combo_5.TabIndex = 16;
            // 
            // text_mask_7
            // 
            this.text_mask_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_mask_7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mask_7.Location = new System.Drawing.Point(582, 358);
            this.text_mask_7.Mask = "(00) 0000-0000";
            this.text_mask_7.Name = "text_mask_7";
            this.text_mask_7.Size = new System.Drawing.Size(138, 30);
            this.text_mask_7.TabIndex = 17;
            // 
            // text_mask_2
            // 
            this.text_mask_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_mask_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mask_2.Location = new System.Drawing.Point(87, 212);
            this.text_mask_2.Mask = "000,000,000-00";
            this.text_mask_2.Name = "text_mask_2";
            this.text_mask_2.Size = new System.Drawing.Size(162, 30);
            this.text_mask_2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Trabalho_de_POO.Properties.Resources.imagem3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 566);
            this.Controls.Add(this.text_mask_2);
            this.Controls.Add(this.text_mask_7);
            this.Controls.Add(this.combo_5);
            this.Controls.Add(this.combo_4);
            this.Controls.Add(this.lab_5);
            this.Controls.Add(this.text_6);
            this.Controls.Add(this.text_3);
            this.Controls.Add(this.text_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_4);
            this.Controls.Add(this.lab_7);
            this.Controls.Add(this.lab_3);
            this.Controls.Add(this.lab_6);
            this.Controls.Add(this.lab_2);
            this.Controls.Add(this.lab_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Processos";
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
        private System.Windows.Forms.Label lab_4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_1;
        private System.Windows.Forms.TextBox text_3;
        private System.Windows.Forms.TextBox text_6;
        private System.Windows.Forms.Label lab_5;
        private System.Windows.Forms.ComboBox combo_4;
        private System.Windows.Forms.ComboBox combo_5;
        private System.Windows.Forms.MaskedTextBox text_mask_7;
        private System.Windows.Forms.MaskedTextBox text_mask_2;
    }
}

