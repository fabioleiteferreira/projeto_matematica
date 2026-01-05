
namespace Projeto_Matemática
{
    partial class Frm_Operacao
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Nimero1 = new System.Windows.Forms.Label();
            this.Lbl_Numero2 = new System.Windows.Forms.Label();
            this.Lbl_Operacao = new System.Windows.Forms.Label();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Adicao = new System.Windows.Forms.Button();
            this.Btn_Subtracao = new System.Windows.Forms.Button();
            this.Btn_Multiplicacao = new System.Windows.Forms.Button();
            this.Btn_Divisao = new System.Windows.Forms.Button();
            this.Txt_Numero1 = new System.Windows.Forms.TextBox();
            this.Txt_Numero2 = new System.Windows.Forms.TextBox();
            this.Txt_Adicao = new System.Windows.Forms.TextBox();
            this.Txt_Subtracao = new System.Windows.Forms.TextBox();
            this.Txt_Multiplicacao = new System.Windows.Forms.TextBox();
            this.Txt_Divisao = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(649, 33);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(392, 28);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Operação Aritméticas";
            // 
            // Lbl_Nimero1
            // 
            this.Lbl_Nimero1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nimero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nimero1.Location = new System.Drawing.Point(675, 95);
            this.Lbl_Nimero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nimero1.Name = "Lbl_Nimero1";
            this.Lbl_Nimero1.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Nimero1.TabIndex = 1;
            this.Lbl_Nimero1.Text = "Número 1";
            // 
            // Lbl_Numero2
            // 
            this.Lbl_Numero2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero2.Location = new System.Drawing.Point(883, 95);
            this.Lbl_Numero2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Numero2.Name = "Lbl_Numero2";
            this.Lbl_Numero2.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Numero2.TabIndex = 2;
            this.Lbl_Numero2.Text = "Número 2";
            // 
            // Lbl_Operacao
            // 
            this.Lbl_Operacao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Operacao.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Operacao.Location = new System.Drawing.Point(675, 181);
            this.Lbl_Operacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Operacao.Name = "Lbl_Operacao";
            this.Lbl_Operacao.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Operacao.TabIndex = 3;
            this.Lbl_Operacao.Text = "Operação";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_Resultado.Location = new System.Drawing.Point(883, 181);
            this.Lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Resultado.TabIndex = 4;
            this.Lbl_Resultado.Text = "Resultado";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.Black;
            this.Btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.Btn_Fechar.Location = new System.Drawing.Point(1088, 15);
            this.Btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(71, 52);
            this.Btn_Fechar.TabIndex = 5;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Adicao
            // 
            this.Btn_Adicao.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Adicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicao.Location = new System.Drawing.Point(675, 247);
            this.Btn_Adicao.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Adicao.Name = "Btn_Adicao";
            this.Btn_Adicao.Size = new System.Drawing.Size(181, 28);
            this.Btn_Adicao.TabIndex = 6;
            this.Btn_Adicao.Text = "+Adição";
            this.Btn_Adicao.UseVisualStyleBackColor = false;
            this.Btn_Adicao.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Subtracao
            // 
            this.Btn_Subtracao.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subtracao.Location = new System.Drawing.Point(679, 303);
            this.Btn_Subtracao.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Subtracao.Name = "Btn_Subtracao";
            this.Btn_Subtracao.Size = new System.Drawing.Size(177, 27);
            this.Btn_Subtracao.TabIndex = 7;
            this.Btn_Subtracao.Text = "- Subtração";
            this.Btn_Subtracao.UseVisualStyleBackColor = false;
            this.Btn_Subtracao.Click += new System.EventHandler(this.Btn_Subtracao_Click);
            // 
            // Btn_Multiplicacao
            // 
            this.Btn_Multiplicacao.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplicacao.Location = new System.Drawing.Point(679, 362);
            this.Btn_Multiplicacao.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Multiplicacao.Name = "Btn_Multiplicacao";
            this.Btn_Multiplicacao.Size = new System.Drawing.Size(177, 28);
            this.Btn_Multiplicacao.TabIndex = 8;
            this.Btn_Multiplicacao.Text = "* Multiplicação";
            this.Btn_Multiplicacao.UseVisualStyleBackColor = false;
            this.Btn_Multiplicacao.Click += new System.EventHandler(this.Btn_Multiplicacao_Click);
            // 
            // Btn_Divisao
            // 
            this.Btn_Divisao.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Divisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divisao.Location = new System.Drawing.Point(679, 420);
            this.Btn_Divisao.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Divisao.Name = "Btn_Divisao";
            this.Btn_Divisao.Size = new System.Drawing.Size(177, 28);
            this.Btn_Divisao.TabIndex = 9;
            this.Btn_Divisao.Text = "/ Divião";
            this.Btn_Divisao.UseVisualStyleBackColor = false;
            this.Btn_Divisao.Click += new System.EventHandler(this.Btn_Divisao_Click);
            // 
            // Txt_Numero1
            // 
            this.Txt_Numero1.Location = new System.Drawing.Point(675, 142);
            this.Txt_Numero1.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Numero1.Name = "Txt_Numero1";
            this.Txt_Numero1.Size = new System.Drawing.Size(132, 22);
            this.Txt_Numero1.TabIndex = 10;
            this.Txt_Numero1.TextChanged += new System.EventHandler(this.Txt_Numero1_TextChanged);
            this.Txt_Numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero1_KeyPress);
            // 
            // Txt_Numero2
            // 
            this.Txt_Numero2.Location = new System.Drawing.Point(887, 142);
            this.Txt_Numero2.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Numero2.Name = "Txt_Numero2";
            this.Txt_Numero2.Size = new System.Drawing.Size(132, 22);
            this.Txt_Numero2.TabIndex = 11;
            this.Txt_Numero2.TextChanged += new System.EventHandler(this.Txt_Numero2_TextChanged);
            this.Txt_Numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero2_KeyPress);
            // 
            // Txt_Adicao
            // 
            this.Txt_Adicao.Location = new System.Drawing.Point(887, 251);
            this.Txt_Adicao.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Adicao.Name = "Txt_Adicao";
            this.Txt_Adicao.Size = new System.Drawing.Size(132, 22);
            this.Txt_Adicao.TabIndex = 12;
            // 
            // Txt_Subtracao
            // 
            this.Txt_Subtracao.Location = new System.Drawing.Point(887, 305);
            this.Txt_Subtracao.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Subtracao.Name = "Txt_Subtracao";
            this.Txt_Subtracao.Size = new System.Drawing.Size(132, 22);
            this.Txt_Subtracao.TabIndex = 13;
            // 
            // Txt_Multiplicacao
            // 
            this.Txt_Multiplicacao.Location = new System.Drawing.Point(887, 362);
            this.Txt_Multiplicacao.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Multiplicacao.Name = "Txt_Multiplicacao";
            this.Txt_Multiplicacao.Size = new System.Drawing.Size(132, 22);
            this.Txt_Multiplicacao.TabIndex = 14;
            // 
            // Txt_Divisao
            // 
            this.Txt_Divisao.Location = new System.Drawing.Point(887, 423);
            this.Txt_Divisao.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Divisao.Name = "Txt_Divisao";
            this.Txt_Divisao.Size = new System.Drawing.Size(132, 22);
            this.Txt_Divisao.TabIndex = 15;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(840, 492);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(176, 47);
            this.Btn_Limpar.TabIndex = 16;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Frm_Operacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.istockphoto_1210301928_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 554);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_Divisao);
            this.Controls.Add(this.Txt_Multiplicacao);
            this.Controls.Add(this.Txt_Subtracao);
            this.Controls.Add(this.Txt_Adicao);
            this.Controls.Add(this.Txt_Numero2);
            this.Controls.Add(this.Txt_Numero1);
            this.Controls.Add(this.Btn_Divisao);
            this.Controls.Add(this.Btn_Multiplicacao);
            this.Controls.Add(this.Btn_Subtracao);
            this.Controls.Add(this.Btn_Adicao);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Lbl_Operacao);
            this.Controls.Add(this.Lbl_Numero2);
            this.Controls.Add(this.Lbl_Nimero1);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Operacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operação Aritméticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Nimero1;
        private System.Windows.Forms.Label Lbl_Numero2;
        private System.Windows.Forms.Label Lbl_Operacao;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Adicao;
        private System.Windows.Forms.Button Btn_Subtracao;
        private System.Windows.Forms.Button Btn_Multiplicacao;
        private System.Windows.Forms.Button Btn_Divisao;
        private System.Windows.Forms.TextBox Txt_Numero1;
        private System.Windows.Forms.TextBox Txt_Numero2;
        private System.Windows.Forms.TextBox Txt_Adicao;
        private System.Windows.Forms.TextBox Txt_Subtracao;
        private System.Windows.Forms.TextBox Txt_Multiplicacao;
        private System.Windows.Forms.TextBox Txt_Divisao;
        private System.Windows.Forms.Button Btn_Limpar;
    }
}