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
    public partial class Frm_Acesso : Form
    {
        public Frm_Acesso()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rad_Dobro_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Dobro dobro = new Frm_Dobro ();
            dobro .Show();
            Hide();
          




        }

        private void Rad_Antecessor_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Antecessor dobro = new Frm_Antecessor();

            dobro.Show();
            Hide();


        }

        private void Rad_Par_CheckedChanged(object sender, EventArgs e)
        {

            Frm_Par par  = new Frm_Par();

            par.Show();
            Hide();
        }

        private void Lbl_Projeto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
           
            //Mensagem com condiçãoe com 2 botões 

            if (MessageBox.Show("Deseja Sair do Programa ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }



        }

        private void Rad_Positivo_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Positivo Positivo  = new Frm_Positivo();

            Positivo .Show();
            Hide();


        }

        private void Rad_Igual_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Igual igual   = new Frm_Igual();
            igual.Show ();
            Hide();


        }

        private void Rad_Maior_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Maior maior   = new Frm_Maior();
            maior.Show();
            Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Frm_Operacao operacao = new Frm_Operacao();
            operacao.Show();
            Hide();
        }

        private void Frm_Acesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Fechando o Aplicativo com a tecla Esc

            if (e.KeyChar == 27)
            {
                if (MessageBox.Show("Deseja Sair do Programa ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
