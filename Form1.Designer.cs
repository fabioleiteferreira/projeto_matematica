
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Abertura));
            this.Timer_Abertura = new System.Windows.Forms.Timer(this.components);
            this.Wmp_Abertura = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Abertura)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Abertura
            // 
            this.Timer_Abertura.Enabled = true;
            this.Timer_Abertura.Interval = 32000;
            this.Timer_Abertura.Tick += new System.EventHandler(this.Timer_Abertura_Tick);
            // 
            // Wmp_Abertura
            // 
            this.Wmp_Abertura.Enabled = true;
            this.Wmp_Abertura.Location = new System.Drawing.Point(1, 2);
            this.Wmp_Abertura.Name = "Wmp_Abertura";
            this.Wmp_Abertura.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wmp_Abertura.OcxState")));
            this.Wmp_Abertura.Size = new System.Drawing.Size(805, 421);
            this.Wmp_Abertura.TabIndex = 0;
            this.Wmp_Abertura.Enter += new System.EventHandler(this.Wmp_Abertura_Enter);
            // 
            // Frm_Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.Wmp_Abertura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Abertura";
            this.Text = "ABERTURA";
            this.Load += new System.EventHandler(this.Frm_Abertura_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Abertura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Abertura;
        private AxWMPLib.AxWindowsMediaPlayer Wmp_Abertura;
    }
}

