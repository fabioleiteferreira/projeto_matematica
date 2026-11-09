
namespace Projeto_Matemática
{
    partial class Frm_Abertura
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
            this.components = new System.ComponentModel.Container();
            this.Timer_Abertura = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Carregando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer_Abertura
            // 
            this.Timer_Abertura.Enabled = true;
            this.Timer_Abertura.Interval = 3000;
            this.Timer_Abertura.Tick += new System.EventHandler(this.Timer_Abertura_Tick);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(0, 140);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(901, 90);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Projeto Matemática";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Carregando
            // 
            this.Lbl_Carregando.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Carregando.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Lbl_Carregando.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Carregando.Location = new System.Drawing.Point(0, 240);
            this.Lbl_Carregando.Name = "Lbl_Carregando";
            this.Lbl_Carregando.Size = new System.Drawing.Size(901, 40);
            this.Lbl_Carregando.TabIndex = 1;
            this.Lbl_Carregando.Text = "Carregando...";
            this.Lbl_Carregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 36, 38);
            this.BackgroundImage = global::Projeto_Matemática.Properties.Resources.Imagem_1mat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.Lbl_Carregando);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABERTURA";
            this.Load += new System.EventHandler(this.Frm_Abertura_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Abertura;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Carregando;
    }
}

