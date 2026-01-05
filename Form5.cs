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
    public partial class Frm_Antecessor : Form
    {
        int Numero, antecessor, sucessor; // Declarando Variaveis//
        public Frm_Antecessor()
        {
            InitializeComponent();
        }

        private void Btn_Esquerda_Click(object sender, EventArgs e)
        {
            Numero = int.Parse(Txt_Inteiro.Text); // A variavel recebe o numero digitado e convertido para inteiro //
            antecessor = Numero - 1; //A variavel recebe o calculo do antecessor
            Lbl_Ante.Text = antecessor.ToString(); // O Label recebe o resultado da variável ja convertido para string //
        }

        private void Btn_Sucessor_Click(object sender, EventArgs e)
        {
            Numero = int.Parse(Txt_Inteiro.Text); // A Variavel recebe o numero digitado e convertido para inteiro //
            sucessor = Numero + 1; // A variavel recebe o calculo do sucessor//
            Lbl_Sucessor.Text = sucessor.ToString(); // O Label recebe o resultado da variável ja convertido para string //
        }

        private void Btn_Lixeira_Click(object sender, EventArgs e)
        {
            Txt_Inteiro.Clear(); // Limpar o numero digitado //
            Txt_Inteiro.Focus(); // Posição do cursor //
            Lbl_Sucessor.Text = "?"; // Retornando o Label para o Padrão //
            Lbl_Ante.Text = "?";  // Retornando o Label para o Padrão //
        }

        private void Frm_Antecessor_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Antecessor_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Frm_Acesso acesso = new Frm_Acesso();
            acesso.Show();
            Hide();

            
            
           

        }

        private void Txt_Inteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Condição para verificar se foi digitado numeros
            {
                e.Handled = true; // Verifica e confirma atecla pressionada foi o numero
                MessageBox.Show("Digite o numero !!!", " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(e.KeyChar ==13)//Condição se o enter enter foi pressionada 
            {

            if (Txt_Inteiro.Text=="") // Condição para verificar se a caixa esta vazia
            {
                MessageBox.Show("Digite o Numero !!!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);  //Mensagem de erro //
            }
            else // Caso contrário , se se for digitado o numero
                {
                    MessageBox.Show("Clique nos Botões Abaixo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Txt_Inteiro_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Inteiro.Text != "") // Condição para verificar se a numero 
            {

                Btn_Sucessor.Visible = true; // Mostrar o Botão Direita//
                Btn_Antecessor.Visible = true;// Mostrar o Botão Esquerda//
                Btn_Lixeira.Visible = true; // Mostrar o Botão Lixeira//
                Lbl_Ante.Visible = true; // Mostrar o Botão Antecessor//
                Lbl_Sucessor.Visible = true;  // Mostrar o Botão Sucessor//
            }
            else
            {
                Btn_Sucessor.Visible = false ; // Mostrar o Botão Direita//
                Btn_Antecessor.Visible = false  ;// Mostrar o Botão Esquerda//
                Btn_Lixeira.Visible = false ; // Mostrar o Botão Lixeira//
                Lbl_Ante.Visible = false ; // Mostrar o Botão Antecessor//
                Lbl_Sucessor.Visible = false  ;  // Mostrar o Botão Suc

            }
        }
        
        
        
        

        
        
         
    }
}

        
    