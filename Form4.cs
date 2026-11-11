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
    public partial class Frm_Dobro : Form
    {
        double num; // Declarando variavél que aceita números com casas decimais publica //
        public Frm_Dobro()
        {
            InitializeComponent();
        }

        private void Txt_Numero_TextChanged(object sender, EventArgs e)

        {
            
           

           
            

        }



        private void Txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) Lbl_Resultado.Text = ""; // Apaga o resultado anterior ao digitar
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',')) // Condição para ver
            {
                e.Handled = true; // Verificando e confirma se a tecla pressionada é  numero
                MessageBox.Show("Digite somente números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13) // Condição para verificar se a tecla enter foi pressionada //

                if (Txt_Dobro.Text != "") // Condição Para verificar se foi digitado o numero
                {
                    if (!double.TryParse(Txt_Dobro.Text, out num)) // Evita erro com mais de uma vírgula
                    {
                        MessageBox.Show("Número inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Dobro.Clear();
                        Txt_Dobro.Focus();
                        return;
                    }
                    Lbl_Resultado.Text = "O dobro de " + num + " é " + (num + num); // Resultado aparece na tela
                    num = num + num; // Calculo do Dobro //
                    Txt_Dobro.SelectAll(); // Deixa o número selecionado para digitar o próximo
                    Txt_Dobro.Focus(); // Posição do cursor //
                }
                else // se o numero não for digitado //
                {

                    MessageBox.Show("Digite um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    {



                    }
                }
        }

    }
    
}
