using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Matemática
{
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Timer_Abertura_Tick(object sender, EventArgs e)
        {
            Timer_Abertura.Start(); // Iniciar a contagem Tempo //
            Timer_Abertura.Stop(); // Parar a contagem do Tempo//
            Frm_Acesso acesso = new Frm_Acesso();
            acesso.Show();
            Hide();

        }

        private void Frm_Abertura_Load(object sender, EventArgs e)
        {
        }
    }
}
