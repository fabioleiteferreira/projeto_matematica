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
    public partial class Frm_Maior : Form
    {
        double n1, n2;



        public Frm_Maior()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Frm_Acesso _Acesso = new Frm_Acesso();
            _Acesso.Show();
            Hide();

        }

        private void Txt_Primeiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Segundo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_Segundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber (e.KeyChar )&&!char.IsControl (e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite somente números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Primeiro.Text != "" && Txt_Segundo.Text != "")
                {
                    n1 = double.Parse(Txt_Primeiro.Text);
                    n2 = double.Parse(Txt_Segundo.Text);

                    if (n1 > n2 )
                    {
                        MessageBox.Show("O 1º número é maior!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lbl_Sinais.Text = ">";
                    }
                    else if (n1 == n2)
                    {
                        MessageBox.Show("Os números são iguais. Digite números diferentes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        Txt_Segundo.Clear();
                        
                        Txt_Segundo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("O 2º número é maior!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lbl_Sinais.Text = "<";
                    }
                }
                else
                {
                MessageBox.Show("Digite os dois números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }






            }
            

            
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Primeiro.Clear();
            Txt_Segundo.Clear();
            Lbl_Sinais.Text = "?";
            Txt_Primeiro.Focus();

        }

        private void Frm_Maior_Load(object sender, EventArgs e)
        {

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
                    n1 = double.Parse(Txt_Primeiro.Text);
                    Txt_Segundo.Focus();


                }
                else
                {
                    MessageBox.Show("Digite um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   
            }
        }

    }

}
                
               
                
                   

                
            
        

        
        

        

       
        
           
          
        

        
        

        
    

