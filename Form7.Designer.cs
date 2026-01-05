
namespace Projeto_Matemática
{
    partial class Frm_Igual
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
            this.Lbl_igual = new System.Windows.Forms.Label();
            this.Lbl_Primeiro = new System.Windows.Forms.Label();
            this.Lbl_Segundo = new System.Windows.Forms.Label();
            this.Txt_Primeiro = new System.Windows.Forms.TextBox();
            this.Txt_Segundo = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Lbl_Interrogação = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_igual
            // 
            this.Lbl_igual.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_igual.ForeColor = System.Drawing.Color.Red;
            this.Lbl_igual.Location = new System.Drawing.Point(525, 169);
            this.Lbl_igual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_igual.Name = "Lbl_igual";
            this.Lbl_igual.Size = new System.Drawing.Size(248, 37);
            this.Lbl_igual.TabIndex = 0;
            this.Lbl_igual.Text = "Igual ou Diferente";
            // 
            // Lbl_Primeiro
            // 
            this.Lbl_Primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Primeiro.Location = new System.Drawing.Point(408, 218);
            this.Lbl_Primeiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Primeiro.Name = "Lbl_Primeiro";
            this.Lbl_Primeiro.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Primeiro.TabIndex = 1;
            this.Lbl_Primeiro.Text = "1º Número";
            // 
            // Lbl_Segundo
            // 
            this.Lbl_Segundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Segundo.Location = new System.Drawing.Point(668, 218);
            this.Lbl_Segundo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Segundo.Name = "Lbl_Segundo";
            this.Lbl_Segundo.Size = new System.Drawing.Size(133, 28);
            this.Lbl_Segundo.TabIndex = 2;
            this.Lbl_Segundo.Text = "2º Número";
            // 
            // Txt_Primeiro
            // 
            this.Txt_Primeiro.Location = new System.Drawing.Point(408, 297);
            this.Txt_Primeiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Primeiro.Name = "Txt_Primeiro";
            this.Txt_Primeiro.Size = new System.Drawing.Size(132, 22);
            this.Txt_Primeiro.TabIndex = 3;
            this.Txt_Primeiro.TextChanged += new System.EventHandler(this.Txt_Primeiro_TextChanged);
            this.Txt_Primeiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Primeiro_KeyPress);
            // 
            // Txt_Segundo
            // 
            this.Txt_Segundo.Location = new System.Drawing.Point(672, 297);
            this.Txt_Segundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Segundo.Name = "Txt_Segundo";
            this.Txt_Segundo.Size = new System.Drawing.Size(132, 22);
            this.Txt_Segundo.TabIndex = 4;
            this.Txt_Segundo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Segundo_KeyPress);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(879, 300);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Limpar.TabIndex = 5;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Lbl_Interrogação
            // 
            this.Lbl_Interrogação.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Interrogação.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Interrogação.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Interrogação.Location = new System.Drawing.Point(589, 300);
            this.Lbl_Interrogação.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Interrogação.Name = "Lbl_Interrogação";
            this.Lbl_Interrogação.Size = new System.Drawing.Size(32, 28);
            this.Lbl_Interrogação.TabIndex = 6;
            this.Lbl_Interrogação.Text = "?";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(1048, 34);
            this.Btn_Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 66);
            this.Btn_Fechar.TabIndex = 7;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_Igual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.Imagem_igual_diferente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1397, 574);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Lbl_Interrogação);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_Segundo);
            this.Controls.Add(this.Txt_Primeiro);
            this.Controls.Add(this.Lbl_Segundo);
            this.Controls.Add(this.Lbl_Primeiro);
            this.Controls.Add(this.Lbl_igual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Igual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igual ou Diferente ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_igual;
        private System.Windows.Forms.Label Lbl_Primeiro;
        private System.Windows.Forms.Label Lbl_Segundo;
        private System.Windows.Forms.TextBox Txt_Primeiro;
        private System.Windows.Forms.TextBox Txt_Segundo;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label Lbl_Interrogação;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}