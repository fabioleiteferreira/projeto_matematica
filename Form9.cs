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
    public partial class Frm_Operacao : Form
    {
        Double n1, n2; // Declarando as variaveis //

        public Frm_Operacao()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Frm_Acesso acesso = new Frm_Acesso();
            acesso.Show();
            Hide();

            
        }

        private void Txt_Numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente Numeros !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Numero1.Text != "")
                {
                    n1 = int.Parse(Txt_Numero1.Text);
                    Txt_Numero2.Focus();
                        
                }
                else
                {
                    MessageBox.Show("Digite o Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void Txt_Numero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente Numeros !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (e.KeyChar == 13)
            {

                if (Txt_Numero2.Text != "")
                {
                    n2 = int.Parse(Txt_Numero2.Text);
                    
                }
                else
                {
                    MessageBox.Show("Digite Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Numero1.Clear();
            Txt_Numero2.Clear();
            Txt_Adicao.Clear();
            Txt_Subtracao.Clear();
            Txt_Multiplicacao.Clear();
            Txt_Divisao.Clear();
        }

        private void Btn_Subtracao_Click(object sender, EventArgs e)
        {
            
            if (Txt_Numero1.Text != "" && Txt_Numero2.Text != "")
            {
                n1 = double.Parse(Txt_Numero1.Text);
                n2 = double.Parse(Txt_Numero2.Text);
                double result = n1 - n2;
                Txt_Subtracao.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Digite o 1º e o 2º Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (Txt_Numero1.Text != "" && Txt_Numero2.Text != "")
            {
                n1 = double.Parse(Txt_Numero1.Text);
                n2 = double.Parse(Txt_Numero2.Text);
                double result = n1 * n2;
                Txt_Multiplicacao.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Digite o 1º e o 2º Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Divisao_Click(object sender, EventArgs e)
        {
            if (Txt_Numero1.Text != "" && Txt_Numero2.Text != "")
            {
                n1 = double.Parse(Txt_Numero1.Text);
                n2 = double.Parse(Txt_Numero2.Text);
                double result = n1 / n2;
                Txt_Divisao.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Digite o 1º e o 2º Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Txt_Numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            if (Txt_Numero1.Text != "" && Txt_Numero2.Text != "")
            {

                n1 = double.Parse(Txt_Numero1.Text);
                n2 = double.Parse(Txt_Numero2.Text);
                double result = n1 + n2;
                Txt_Adicao.Text = result.ToString();

            }
            else
            {
                MessageBox.Show("Digite o 1º e o 2º Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


















        }

            
        }

        

       
    }

