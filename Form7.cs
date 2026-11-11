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
    public partial class Frm_Igual : Form
    {
        int n1, n2; // Declarando Variavel as variaveis //

        public Frm_Igual()
        {
            InitializeComponent();
        }

        private void Txt_Primeiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Digite somente números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                    if (Txt_Primeiro.Text != "")
                    {
                    Txt_Segundo.Focus();// Posição do cursor para digitar o 2º numero //
                    }
                    else //Caso contrario , se não for digitado o numero //
                    {
                    MessageBox.Show("Digite um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }
        }

        private void Txt_Segundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
                e.Handled = true;

                MessageBox.Show("Digite um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                 
                
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Segundo.Text != "")
                {
                    if (Txt_Primeiro.Text == "") // Garante que o 1º número também foi digitado
                    {
                        MessageBox.Show("Digite o 1º número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Primeiro.Focus();
                        return;
                    }
                    if (!int.TryParse(Txt_Primeiro.Text, out n1) || !int.TryParse(Txt_Segundo.Text, out n2)) // Evita erro com número grande demais
                    {
                        MessageBox.Show("Número muito grande!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (n1 == n2) // Condição para verificar se os números são iguais //
                    {
                        Lbl_Interrogação.Text = "="; // Midando a interrogação para o sinal =
                    }
                    else // Caso ao contrario os numeros não forem iguais //
                    {
                        Lbl_Interrogação.Text = "≠";
                    }
                }

            }
            
               
            


        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Primeiro.Clear();
            Txt_Segundo.Clear();
            Lbl_Interrogação.Text = "?";
            Txt_Primeiro.Focus();
        }

        private void Txt_Primeiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Frm_Acesso acesso = new Frm_Acesso();
            acesso.Show();
            Hide();
           
        }
    }
}
