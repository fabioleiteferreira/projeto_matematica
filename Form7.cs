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

                MessageBox.Show("Somente Numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                    if (Txt_Primeiro.Text != "")
                    {
                    n1 = int.Parse(Txt_Primeiro.Text);
                    Txt_Segundo.Focus();// Posição do cursor para digitar o 2º numero //
                    }
                    else //Caso contrario , se não for digitado o numero //
                    {
                    MessageBox.Show("Digite o numero !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }
        }

        private void Txt_Segundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
                e.Handled = true;

                MessageBox.Show("Digite o numero !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                 
                
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Segundo.Text != "")
                {
                    n2 = int.Parse(Txt_Segundo.Text);

                    if (n1 == n2) // Condição para verificar se os números são iguais //
                    {
                        MessageBox.Show("Os numeros são iguais !!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lbl_Interrogação.Text = "="; // Midando a interrogação para o sinal =
                    }
                    else // Caso ao contrario os numeros não forem iguais //
                    {
                        MessageBox.Show("Os Numeros São Diferentes", " Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
