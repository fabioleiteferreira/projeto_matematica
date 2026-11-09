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
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',')) // Condição para ver
            {
                e.Handled = true; // Verificando e confirma se a tecla pressionada é  numero
                MessageBox.Show("Digite somente números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13) // Condição para verificar se a tecla enter foi pressionada //

                if (Txt_Dobro.Text != "") // Condição Para verificar se foi digitado o numero
                {
                    num = double.Parse(Txt_Dobro.Text); // Variavel está recebendo o numero que  foi digitado e condição
                    num = num + num; // Calculo do Dobro //
                    MessageBox.Show("O dobro do número é: " + num, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txt_Dobro.Clear(); // Limpando o numero digitado para o Próximo numero //
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
