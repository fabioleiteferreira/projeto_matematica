
namespace Projeto_Matemática
{
    partial class Frm_Acesso
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Projeto = new System.Windows.Forms.Label();
            this.Rad_Dobro = new System.Windows.Forms.RadioButton();
            this.Rad_Antecessor = new System.Windows.Forms.RadioButton();
            this.Rad_Par = new System.Windows.Forms.RadioButton();
            this.Rad_Positivo = new System.Windows.Forms.RadioButton();
            this.Rad_Igual = new System.Windows.Forms.RadioButton();
            this.Rad_Maior = new System.Windows.Forms.RadioButton();
            this.Rad_Operacao = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Red;
            this.Btn_Sair.Location = new System.Drawing.Point(790, 34);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(63, 48);
            this.Btn_Sair.TabIndex = 0;
            this.Btn_Sair.Text = "X";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_Projeto
            // 
            this.Lbl_Projeto.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Projeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Projeto.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_Projeto.Location = new System.Drawing.Point(178, 89);
            this.Lbl_Projeto.Name = "Lbl_Projeto";
            this.Lbl_Projeto.Size = new System.Drawing.Size(273, 32);
            this.Lbl_Projeto.TabIndex = 3;
            this.Lbl_Projeto.Text = "Projeto Matemática";
            this.Lbl_Projeto.Click += new System.EventHandler(this.Lbl_Projeto_Click);
            // 
            // Rad_Dobro
            // 
            this.Rad_Dobro.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Dobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Dobro.ForeColor = System.Drawing.Color.White;
            this.Rad_Dobro.Location = new System.Drawing.Point(182, 141);
            this.Rad_Dobro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rad_Dobro.Name = "Rad_Dobro";
            this.Rad_Dobro.Size = new System.Drawing.Size(217, 29);
            this.Rad_Dobro.TabIndex = 4;
            this.Rad_Dobro.TabStop = true;
            this.Rad_Dobro.Text = "Dobro";
            this.Rad_Dobro.UseVisualStyleBackColor = false;
            this.Rad_Dobro.CheckedChanged += new System.EventHandler(this.Rad_Dobro_CheckedChanged);
            // 
            // Rad_Antecessor
            // 
            this.Rad_Antecessor.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Antecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Antecessor.ForeColor = System.Drawing.Color.White;
            this.Rad_Antecessor.Location = new System.Drawing.Point(182, 175);
            this.Rad_Antecessor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rad_Antecessor.Name = "Rad_Antecessor";
            this.Rad_Antecessor.Size = new System.Drawing.Size(217, 29);
            this.Rad_Antecessor.TabIndex = 5;
            this.Rad_Antecessor.TabStop = true;
            this.Rad_Antecessor.Text = "Antecessor e Sucessor";
            this.Rad_Antecessor.UseVisualStyleBackColor = false;
            this.Rad_Antecessor.CheckedChanged += new System.EventHandler(this.Rad_Antecessor_CheckedChanged);
            // 
            // Rad_Par
            // 
            this.Rad_Par.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Par.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Par.ForeColor = System.Drawing.Color.White;
            this.Rad_Par.Location = new System.Drawing.Point(182, 209);
            this.Rad_Par.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rad_Par.Name = "Rad_Par";
            this.Rad_Par.Size = new System.Drawing.Size(217, 29);
            this.Rad_Par.TabIndex = 6;
            this.Rad_Par.TabStop = true;
            this.Rad_Par.Text = "Par ou ímpar";
            this.Rad_Par.UseVisualStyleBackColor = false;
            this.Rad_Par.CheckedChanged += new System.EventHandler(this.Rad_Par_CheckedChanged);
            // 
            // Rad_Positivo
            // 
            this.Rad_Positivo.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Positivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Positivo.ForeColor = System.Drawing.Color.White;
            this.Rad_Positivo.Location = new System.Drawing.Point(182, 243);
            this.Rad_Positivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rad_Positivo.Name = "Rad_Positivo";
            this.Rad_Positivo.Size = new System.Drawing.Size(217, 29);
            this.Rad_Positivo.TabIndex = 7;
            this.Rad_Positivo.TabStop = true;
            this.Rad_Positivo.Text = "Positivo ou Negativo ou Neutro";
            this.Rad_Positivo.UseVisualStyleBackColor = false;
            this.Rad_Positivo.CheckedChanged += new System.EventHandler(this.Rad_Positivo_CheckedChanged);
            // 
            // Rad_Igual
            // 
            this.Rad_Igual.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Igual.ForeColor = System.Drawing.Color.White;
            this.Rad_Igual.Location = new System.Drawing.Point(182, 277);
            this.Rad_Igual.Name = "Rad_Igual";
            this.Rad_Igual.Size = new System.Drawing.Size(194, 24);
            this.Rad_Igual.TabIndex = 8;
            this.Rad_Igual.TabStop = true;
            this.Rad_Igual.Text = "Igual ou Diferente  ";
            this.Rad_Igual.UseVisualStyleBackColor = false;
            this.Rad_Igual.CheckedChanged += new System.EventHandler(this.Rad_Igual_CheckedChanged);
            // 
            // Rad_Maior
            // 
            this.Rad_Maior.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Maior.ForeColor = System.Drawing.Color.White;
            this.Rad_Maior.Location = new System.Drawing.Point(182, 317);
            this.Rad_Maior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rad_Maior.Name = "Rad_Maior";
            this.Rad_Maior.Size = new System.Drawing.Size(158, 24);
            this.Rad_Maior.TabIndex = 9;
            this.Rad_Maior.TabStop = true;
            this.Rad_Maior.Text = "Maior Menor";
            this.Rad_Maior.UseVisualStyleBackColor = false;
            this.Rad_Maior.CheckedChanged += new System.EventHandler(this.Rad_Maior_CheckedChanged);
            // 
            // Rad_Operacao
            // 
            this.Rad_Operacao.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Operacao.ForeColor = System.Drawing.Color.White;
            this.Rad_Operacao.Location = new System.Drawing.Point(182, 356);
            this.Rad_Operacao.Name = "Rad_Operacao";
            this.Rad_Operacao.Size = new System.Drawing.Size(225, 24);
            this.Rad_Operacao.TabIndex = 10;
            this.Rad_Operacao.TabStop = true;
            this.Rad_Operacao.Text = "Operação Aritméticas";
            this.Rad_Operacao.UseVisualStyleBackColor = false;
            this.Rad_Operacao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Frm_Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.Imagem_1mat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 513);
            this.Controls.Add(this.Rad_Operacao);
            this.Controls.Add(this.Rad_Maior);
            this.Controls.Add(this.Rad_Igual);
            this.Controls.Add(this.Rad_Positivo);
            this.Controls.Add(this.Rad_Par);
            this.Controls.Add(this.Rad_Antecessor);
            this.Controls.Add(this.Rad_Dobro);
            this.Controls.Add(this.Lbl_Projeto);
            this.Controls.Add(this.Btn_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Matematica";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Acesso_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_Projeto;
        private System.Windows.Forms.RadioButton Rad_Dobro;
        private System.Windows.Forms.RadioButton Rad_Antecessor;
        private System.Windows.Forms.RadioButton Rad_Par;
        private System.Windows.Forms.RadioButton Rad_Positivo;
        private System.Windows.Forms.RadioButton Rad_Igual;
        private System.Windows.Forms.RadioButton Rad_Maior;
        private System.Windows.Forms.RadioButton Rad_Operacao;
    }
}