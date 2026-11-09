
namespace Projeto_Matemática
{
    partial class Frm_Maior
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
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Lbl_Texto = new System.Windows.Forms.Label();
            this.Lbl_Segundo = new System.Windows.Forms.Label();
            this.Lbl_Primeiro = new System.Windows.Forms.Label();
            this.Lbl_Sinais = new System.Windows.Forms.Label();
            this.Txt_Primeiro = new System.Windows.Forms.TextBox();
            this.Txt_Segundo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(748, 238);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(83, 27);
            this.Btn_Limpar.TabIndex = 0;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Fechar.Location = new System.Drawing.Point(776, 27);
            this.Btn_Fechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(56, 50);
            this.Btn_Fechar.TabIndex = 1;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Lbl_Texto
            // 
            this.Lbl_Texto.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Texto.Location = new System.Drawing.Point(524, 79);
            this.Lbl_Texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Texto.Name = "Lbl_Texto";
            this.Lbl_Texto.Size = new System.Drawing.Size(180, 38);
            this.Lbl_Texto.TabIndex = 2;
            this.Lbl_Texto.Text = "Maior ou Menor";
            // 
            // Lbl_Segundo
            // 
            this.Lbl_Segundo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Segundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Segundo.Location = new System.Drawing.Point(610, 183);
            this.Lbl_Segundo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Segundo.Name = "Lbl_Segundo";
            this.Lbl_Segundo.Size = new System.Drawing.Size(94, 30);
            this.Lbl_Segundo.TabIndex = 3;
            this.Lbl_Segundo.Text = "2º Número";
            // 
            // Lbl_Primeiro
            // 
            this.Lbl_Primeiro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Primeiro.Location = new System.Drawing.Point(420, 183);
            this.Lbl_Primeiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Primeiro.Name = "Lbl_Primeiro";
            this.Lbl_Primeiro.Size = new System.Drawing.Size(120, 25);
            this.Lbl_Primeiro.TabIndex = 4;
            this.Lbl_Primeiro.Text = "1º Número";
            // 
            // Lbl_Sinais
            // 
            this.Lbl_Sinais.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Sinais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sinais.Location = new System.Drawing.Point(544, 246);
            this.Lbl_Sinais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Sinais.Name = "Lbl_Sinais";
            this.Lbl_Sinais.Size = new System.Drawing.Size(26, 19);
            this.Lbl_Sinais.TabIndex = 5;
            this.Lbl_Sinais.Text = "?";
            // 
            // Txt_Primeiro
            // 
            this.Txt_Primeiro.Location = new System.Drawing.Point(423, 238);
            this.Txt_Primeiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Primeiro.Name = "Txt_Primeiro";
            this.Txt_Primeiro.Size = new System.Drawing.Size(90, 20);
            this.Txt_Primeiro.TabIndex = 6;
            this.Txt_Primeiro.TextChanged += new System.EventHandler(this.Txt_Primeiro_TextChanged);
            this.Txt_Primeiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Primeiro_KeyPress);
            // 
            // Txt_Segundo
            // 
            this.Txt_Segundo.Location = new System.Drawing.Point(613, 237);
            this.Txt_Segundo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Segundo.Name = "Txt_Segundo";
            this.Txt_Segundo.Size = new System.Drawing.Size(92, 20);
            this.Txt_Segundo.TabIndex = 7;
            this.Txt_Segundo.TextChanged += new System.EventHandler(this.Txt_Segundo_TextChanged);
            this.Txt_Segundo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Segundo_KeyPress);
            // 
            // Frm_Maior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.imagem_maior_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 480);
            this.Controls.Add(this.Txt_Segundo);
            this.Controls.Add(this.Txt_Primeiro);
            this.Controls.Add(this.Lbl_Sinais);
            this.Controls.Add(this.Lbl_Primeiro);
            this.Controls.Add(this.Lbl_Segundo);
            this.Controls.Add(this.Lbl_Texto);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_Limpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Maior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maior Menor";
            this.Load += new System.EventHandler(this.Frm_Maior_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Label Lbl_Texto;
        private System.Windows.Forms.Label Lbl_Segundo;
        private System.Windows.Forms.Label Lbl_Primeiro;
        private System.Windows.Forms.Label Lbl_Sinais;
        private System.Windows.Forms.TextBox Txt_Primeiro;
        private System.Windows.Forms.TextBox Txt_Segundo;
    }
}