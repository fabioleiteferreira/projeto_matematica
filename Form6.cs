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
    public partial class Frm_Par : Form
    {
        int numero; // Declarando uma variável inteira 
        public Frm_Par()
        {
            InitializeComponent();
        }

        private void Txt_Numeral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) Lbl_Resultado.Text = ""; // Apaga o resultado anterior ao digitar
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Digite somente números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) // Condição para verificar se o numero foi digitado //
            {
                if (Txt_Numeral.Text != "")
                {
                    numero = int.Parse(Txt_Numeral.Text); // A Variavel recebe o numero que foi digitado e convertido //

                    if (numero % 2 == 0) //Condição para saber se o resto da divisão é zero para ser par
                    {
                        Lbl_Resultado.Text = numero + " é PAR"; // Resultado aparece na tela
                    }
                    else // se caso ao contrario //
                    {
                        Lbl_Resultado.Text = numero + " é ÍMPAR";
                    }
                    Txt_Numeral.SelectAll(); // Deixa o número selecionado para digitar o próximo
                    Txt_Numeral.Focus(); // posiçção do cursor //


                }
                else // Caso ao contrario //
                {
                    MessageBox.Show("Digite um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Frm_Par_Load(object sender, EventArgs e)
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
