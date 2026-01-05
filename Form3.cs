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

        int dobro; // Declarando variével inteira pública

        public Frm_Positivo()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-')) // Condição para verificar se atecla pressionada foi numero, tecla de controle e o sinal de -
            {
                e.Handled = true; // Confirmar se foi digitado numero , teclas de controle e o sinal de -
                MessageBox.Show(" Somente NUmeros !!!", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (e.KeyChar == 13) // Condição para verificar se a tecla enter foi pressionada //
            {
                if (Txt_Numero.Text != "") // Condição para verifica se o numero foi digitado //
                {
                    pnn = int.Parse(Txt_Numero.Text); // A variavel recebe o numero digitado invertido

                    if (pnn == 0) //  Conção para verificar se o numero digitado é zero//
                    {
                        MessageBox.Show("O Numero é Neutro !!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mensagem para verificar se o número é neutro // 

                    }
                    else if (pnn > 0) // Senão se, condição  para verificar se o numero é positivo //
                    {
                        MessageBox.Show("O Numero é Positivo !!!", " Resultado ", MessageBoxButtons.OK, MessageBoxIcon.Information); // Verificando se o numero é positivo // 

                    }
                    else // Caso contrario, se o numero for negativo //
                    {
                        MessageBox.Show("O Número é Negativo !!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);//Mensagem de Resultado //
                    }
                    Txt_Numero.Clear(); //Limpando o numero digitado //
                    Txt_Numero.Focus(); // Posicionnando o cursos //
                }
                else // Caso contrario, se não for digitado o numero //
                {
                    MessageBox.Show("Digite o Numero !!!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); // Verificando se o numero foi digitado //
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
