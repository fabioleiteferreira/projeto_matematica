
namespace Projeto_Matemática
{
    partial class Frm_Par
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
            this.Lbl_Par = new System.Windows.Forms.Label();
            this.Lbl_Digite = new System.Windows.Forms.Label();
            this.Txt_Numeral = new System.Windows.Forms.TextBox();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Par
            // 
            this.Lbl_Par.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Par.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Par.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Par.Location = new System.Drawing.Point(227, 166);
            this.Lbl_Par.Name = "Lbl_Par";
            this.Lbl_Par.Size = new System.Drawing.Size(259, 23);
            this.Lbl_Par.TabIndex = 0;
            this.Lbl_Par.Text = "Par ou Ímpar";
            // 
            // Lbl_Digite
            // 
            this.Lbl_Digite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digite.Location = new System.Drawing.Point(239, 239);
            this.Lbl_Digite.Name = "Lbl_Digite";
            this.Lbl_Digite.Size = new System.Drawing.Size(183, 23);
            this.Lbl_Digite.TabIndex = 1;
            this.Lbl_Digite.Text = "Digite um número:";
            // 
            // Txt_Numeral
            // 
            this.Txt_Numeral.Location = new System.Drawing.Point(428, 240);
            this.Txt_Numeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Numeral.MaxLength = 9;
            this.Txt_Numeral.Name = "Txt_Numeral";
            this.Txt_Numeral.Size = new System.Drawing.Size(159, 22);
            this.Txt_Numeral.TabIndex = 2;
            this.Txt_Numeral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numeral_KeyPress);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(1075, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 65);
            this.Btn_Fechar.TabIndex = 3;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_Par
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.Imagem_Par_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 530);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Txt_Numeral);
            this.Controls.Add(this.Lbl_Digite);
            this.Controls.Add(this.Lbl_Par);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Par";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAR OU ÍMPAR";
            this.Load += new System.EventHandler(this.Frm_Par_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Par;
        private System.Windows.Forms.Label Lbl_Digite;
        private System.Windows.Forms.TextBox Txt_Numeral;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}