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
    

    public partial class Frm_Positivo : Form
    {
        int pnn; // Declarando a Variavel inteira

        public Frm_Positivo()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) Lbl_Resultado.Text = ""; // Apaga o resultado anterior ao digitar
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-')) // Condição para verificar se atecla pressionada foi numero, tecla de controle e o sinal de -
            {
                e.Handled = true; // Confirmar se foi digitado numero , teclas de controle e o sinal de -
                MessageBox.Show("Digite somente números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (e.KeyChar == 13) // Condição para verificar se a tecla enter foi pressionada //
            {
                if (Txt_Numero.Text != "") // Condição para verifica se o numero foi digitado //
                {
                    if (!int.TryParse(Txt_Numero.Text, out pnn)) // Evita erro com "-" sozinho ou sinal no lugar errado
                    {
                        MessageBox.Show("Número inválido! Use o sinal de - só no começo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Numero.Clear();
                        Txt_Numero.Focus();
                        return;
                    }

                    if (pnn == 0) //  Conção para verificar se o numero digitado é zero//
                    {
                        Lbl_Resultado.Text = "0 é NEUTRO (zero)"; // Resultado aparece na tela

                    }
                    else if (pnn > 0) // Senão se, condição  para verificar se o numero é positivo //
                    {
                        Lbl_Resultado.Text = pnn + " é POSITIVO";

                    }
                    else // Caso contrario, se o numero for negativo //
                    {
                        Lbl_Resultado.Text = pnn + " é NEGATIVO";
                    }
                    Txt_Numero.SelectAll(); // Deixa o número selecionado para digitar o próximo
                    Txt_Numero.Focus(); // Posicionnando o cursos //
                }
                else // Caso contrario, se não for digitado o numero //
                {
                    MessageBox.Show("Digite um número!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); // Verificando se o numero foi digitado //
                }
            }
        }

        private void Txt_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Frm_Acesso _Acesso = new Frm_Acesso();
            _Acesso.Show();
           
            Hide();

        }
    }
}
