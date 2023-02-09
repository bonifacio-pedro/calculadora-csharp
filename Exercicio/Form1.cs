namespace Exercicio
{
    public partial class Calculadora : Form
    {
        private int n1;
        private int n2;
        private int resultado;
        private string funcao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void VerificaValorEAdiciona(string val)
        {
            if(saida.Text == resultado.ToString())
            {
                saida.Text = "";
                saida.Text += val;
            }
            else
            {
                saida.Text += val;
            }
        }


        private void RecebeValor1LimpaInput()
        {
            n1 = Convert.ToInt32(saida.Text);
            saida.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            VerificaValorEAdiciona("0");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            RecebeValor1LimpaInput();
            funcao = "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            RecebeValor1LimpaInput();
            funcao = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            RecebeValor1LimpaInput();
            funcao = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            RecebeValor1LimpaInput();
            funcao = "/";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            
            if (n1 != 0)
            {
                if (saida.Text != "")
                {
                    n2 = Convert.ToInt32(saida.Text);
                    switch (funcao)
                    {
                        case "+":
                            saida.Text = Convert.ToString(n1 + n2);
                            resultado = n1 + n2;
                            break;
                        case "-":
                            saida.Text = Convert.ToString(n1 - n2);
                            resultado = n1 - n2;
                            break;
                        case "*":
                            saida.Text = Convert.ToString(n1 * n2);
                            resultado = n1 * n2;
                            break;
                        case "/":
                            saida.Text = Convert.ToString(n1 / n2);
                            resultado = n1 / n2;
                            break;
                        default:
                            break;
                    }
                }
                
            }
            
        }

    }
}