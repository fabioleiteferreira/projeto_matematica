
namespace Projeto_Matemática
{
    partial class Frm_Positivo
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
            this.Lbl_Positivo = new System.Windows.Forms.Label();
            this.Lbl_Digite2 = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Positivo
            // 
            this.Lbl_Positivo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Positivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Positivo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Positivo.Location = new System.Drawing.Point(373, 192);
            this.Lbl_Positivo.Name = "Lbl_Positivo";
            this.Lbl_Positivo.Size = new System.Drawing.Size(357, 28);
            this.Lbl_Positivo.TabIndex = 0;
            this.Lbl_Positivo.Text = "Positivo ou Negativo ou Neutro";
            // 
            // Lbl_Digite2
            // 
            this.Lbl_Digite2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Digite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digite2.ForeColor = System.Drawing.Color.White;
            this.Lbl_Digite2.Location = new System.Drawing.Point(397, 281);
            this.Lbl_Digite2.Name = "Lbl_Digite2";
            this.Lbl_Digite2.Size = new System.Drawing.Size(228, 23);
            this.Lbl_Digite2.TabIndex = 1;
            this.Lbl_Digite2.Text = "Digite o número:";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.ForeColor = System.Drawing.Color.Black;
            this.Txt_Numero.Location = new System.Drawing.Point(580, 282);
            this.Txt_Numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Numero.MaxLength = 9;
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(133, 22);
            this.Txt_Numero.TabIndex = 2;
            this.Txt_Numero.TextChanged += new System.EventHandler(this.Txt_Numero_TextChanged);
            this.Txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero_KeyPress);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Red;
            this.Btn_Sair.Location = new System.Drawing.Point(1064, 23);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 52);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "X";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_Resultado.Location = new System.Drawing.Point(397, 330);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(330, 40);
            this.Lbl_Resultado.TabIndex = 10;
            this.Lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Positivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.imagem_positivo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 587);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.Lbl_Digite2);
            this.Controls.Add(this.Lbl_Positivo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Positivo";
            this.Text = "POSITIVO, NEGATIVO OU NEUTRO";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Positivo;
        private System.Windows.Forms.Label Lbl_Digite2;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_Resultado;
    }
}