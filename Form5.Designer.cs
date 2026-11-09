
namespace Projeto_Matemática
{
    partial class Frm_Antecessor
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
            this.Lbl_Antecessor = new System.Windows.Forms.Label();
            this.Lbl_Digite = new System.Windows.Forms.Label();
            this.Txt_Inteiro = new System.Windows.Forms.TextBox();
            this.Btn_Antecessor = new System.Windows.Forms.Button();
            this.Btn_Sucessor = new System.Windows.Forms.Button();
            this.Btn_Lixeira = new System.Windows.Forms.Button();
            this.Lbl_Ante = new System.Windows.Forms.Label();
            this.Lbl_Sucessor = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Antecessor
            // 
            this.Lbl_Antecessor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Antecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Antecessor.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Antecessor.Location = new System.Drawing.Point(342, 111);
            this.Lbl_Antecessor.Name = "Lbl_Antecessor";
            this.Lbl_Antecessor.Size = new System.Drawing.Size(355, 33);
            this.Lbl_Antecessor.TabIndex = 0;
            this.Lbl_Antecessor.Text = "Antecessor e Sucessor";
            this.Lbl_Antecessor.Click += new System.EventHandler(this.Lbl_Antecessor_Click);
            // 
            // Lbl_Digite
            // 
            this.Lbl_Digite.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Digite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digite.Location = new System.Drawing.Point(342, 205);
            this.Lbl_Digite.Name = "Lbl_Digite";
            this.Lbl_Digite.Size = new System.Drawing.Size(302, 23);
            this.Lbl_Digite.TabIndex = 1;
            this.Lbl_Digite.Text = "Digite um número inteiro";
            // 
            // Txt_Inteiro
            // 
            this.Txt_Inteiro.Location = new System.Drawing.Point(679, 205);
            this.Txt_Inteiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Inteiro.MaxLength = 9;
            this.Txt_Inteiro.Name = "Txt_Inteiro";
            this.Txt_Inteiro.Size = new System.Drawing.Size(216, 22);
            this.Txt_Inteiro.TabIndex = 2;
            this.Txt_Inteiro.TextChanged += new System.EventHandler(this.Txt_Inteiro_TextChanged);
            this.Txt_Inteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Inteiro_KeyPress);
            // 
            // Btn_Antecessor
            // 
            this.Btn_Antecessor.Image = global::Projeto_Matemática.Properties.Resources.arrow_circle_left_arrow_icon_253876;
            this.Btn_Antecessor.Location = new System.Drawing.Point(347, 250);
            this.Btn_Antecessor.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Antecessor.Name = "Btn_Antecessor";
            this.Btn_Antecessor.Size = new System.Drawing.Size(100, 80);
            this.Btn_Antecessor.TabIndex = 3;
            this.Btn_Antecessor.Text = "Antecessor";
            this.Btn_Antecessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Antecessor.UseVisualStyleBackColor = true;
            this.Btn_Antecessor.Visible = false;
            this.Btn_Antecessor.Click += new System.EventHandler(this.Btn_Esquerda_Click);
            // 
            // Btn_Sucessor
            // 
            this.Btn_Sucessor.Image = global::Projeto_Matemática.Properties.Resources.circle_right_arrow_arrow_icon_253891;
            this.Btn_Sucessor.Location = new System.Drawing.Point(501, 250);
            this.Btn_Sucessor.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Sucessor.Name = "Btn_Sucessor";
            this.Btn_Sucessor.Size = new System.Drawing.Size(100, 80);
            this.Btn_Sucessor.TabIndex = 4;
            this.Btn_Sucessor.Text = "Sucessor";
            this.Btn_Sucessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Sucessor.UseVisualStyleBackColor = true;
            this.Btn_Sucessor.Visible = false;
            this.Btn_Sucessor.Click += new System.EventHandler(this.Btn_Sucessor_Click);
            // 
            // Btn_Lixeira
            // 
            this.Btn_Lixeira.Image = global::Projeto_Matemática.Properties.Resources.Lixeira;
            this.Btn_Lixeira.Location = new System.Drawing.Point(665, 250);
            this.Btn_Lixeira.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Lixeira.Name = "Btn_Lixeira";
            this.Btn_Lixeira.Size = new System.Drawing.Size(100, 80);
            this.Btn_Lixeira.TabIndex = 5;
            this.Btn_Lixeira.Text = "Limpar";
            this.Btn_Lixeira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Lixeira.UseVisualStyleBackColor = true;
            this.Btn_Lixeira.Visible = false;
            this.Btn_Lixeira.Click += new System.EventHandler(this.Btn_Lixeira_Click);
            // 
            // Lbl_Ante
            // 
            this.Lbl_Ante.AutoSize = true;
            this.Lbl_Ante.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Ante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ante.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lbl_Ante.Location = new System.Drawing.Point(368, 354);
            this.Lbl_Ante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Ante.Name = "Lbl_Ante";
            this.Lbl_Ante.Size = new System.Drawing.Size(26, 29);
            this.Lbl_Ante.TabIndex = 6;
            this.Lbl_Ante.Text = "?";
            // 
            // Lbl_Sucessor
            // 
            this.Lbl_Sucessor.AutoSize = true;
            this.Lbl_Sucessor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Sucessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sucessor.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Sucessor.Location = new System.Drawing.Point(529, 354);
            this.Lbl_Sucessor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Sucessor.Name = "Lbl_Sucessor";
            this.Lbl_Sucessor.Size = new System.Drawing.Size(26, 29);
            this.Lbl_Sucessor.TabIndex = 7;
            this.Lbl_Sucessor.Text = "?";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(1044, 44);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 68);
            this.Btn_Fechar.TabIndex = 8;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_Antecessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.IMagem_Antecessor;
            this.ClientSize = new System.Drawing.Size(1193, 597);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Lbl_Sucessor);
            this.Controls.Add(this.Lbl_Ante);
            this.Controls.Add(this.Btn_Lixeira);
            this.Controls.Add(this.Btn_Sucessor);
            this.Controls.Add(this.Btn_Antecessor);
            this.Controls.Add(this.Txt_Inteiro);
            this.Controls.Add(this.Lbl_Digite);
            this.Controls.Add(this.Lbl_Antecessor);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Antecessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANTECESSOR E SUCESSOR";
            this.Load += new System.EventHandler(this.Frm_Antecessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Antecessor;
        private System.Windows.Forms.Label Lbl_Digite;
        private System.Windows.Forms.TextBox Txt_Inteiro;
        private System.Windows.Forms.Button Btn_Antecessor;
        private System.Windows.Forms.Button Btn_Sucessor;
        private System.Windows.Forms.Button Btn_Lixeira;
        private System.Windows.Forms.Label Lbl_Ante;
        private System.Windows.Forms.Label Lbl_Sucessor;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}