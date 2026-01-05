
using System;

namespace Projeto_Matemática
{
    partial class Frm_Dobro
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
            this.Btn_Sair2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Digite = new System.Windows.Forms.Label();
            this.Txt_Dobro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Sair2
            // 
            this.Btn_Sair2.BackColor = System.Drawing.Color.Red;
            this.Btn_Sair2.ForeColor = System.Drawing.Color.White;
            this.Btn_Sair2.Location = new System.Drawing.Point(1051, 32);
            this.Btn_Sair2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair2.Name = "Btn_Sair2";
            this.Btn_Sair2.Size = new System.Drawing.Size(75, 59);
            this.Btn_Sair2.TabIndex = 0;
            this.Btn_Sair2.Text = "X";
            this.Btn_Sair2.UseVisualStyleBackColor = false;
            this.Btn_Sair2.Click += new System.EventHandler(this.Btn_Sair2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar o Dobro do Número";
            // 
            // Lbl_Digite
            // 
            this.Lbl_Digite.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Digite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digite.Location = new System.Drawing.Point(503, 302);
            this.Lbl_Digite.Name = "Lbl_Digite";
            this.Lbl_Digite.Size = new System.Drawing.Size(229, 23);
            this.Lbl_Digite.TabIndex = 2;
            this.Lbl_Digite.Text = "Digite um Numero :";
            // 
            // Txt_Dobro
            // 
            this.Txt_Dobro.Location = new System.Drawing.Point(713, 302);
            this.Txt_Dobro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Dobro.MaxLength = 9;
            this.Txt_Dobro.Name = "Txt_Dobro";
            this.Txt_Dobro.Size = new System.Drawing.Size(161, 22);
            this.Txt_Dobro.TabIndex = 3;
            this.Txt_Dobro.TextChanged += new System.EventHandler(this.Txt_Numero_TextChanged);
            this.Txt_Dobro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero_KeyPress);
            // 
            // Frm_Dobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.Imagem_Dobro;
            this.ClientSize = new System.Drawing.Size(1317, 569);
            this.Controls.Add(this.Txt_Dobro);
            this.Controls.Add(this.Lbl_Digite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Sair2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Dobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOBRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btn_Sair2_Click(object sender, EventArgs e)
        {
            Frm_Acesso acesso = new Frm_Acesso();
            acesso.Show();
            Hide();
            


        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Digite;
        private System.Windows.Forms.TextBox Txt_Dobro;
    }
}