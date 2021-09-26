using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        decimal valor1 = 0, valor2 = 0;
        String operacao = "";

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Limpar(object sender, EventArgs e)
        {
            if (lb01.Text != "" && lb02.Text != null || lb02.Text != null)
            {
                lb01.Text = "0";
                lb02.Text = "";
            }
        }

        private void btnNumber(object sender, EventArgs e)
        {
            if(lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 0;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 0;
            }
            else
            {
                lb01.Text += 0;
            }
            
        }

        private void btnNumber1(object sender, EventArgs e)
        {
            if(lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 1;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 1;
            } else
            {
                lb01.Text += 1;
            }
            
        }

        private void btnNumber2(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 2;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 2;
            }
            else
            {
                lb01.Text += 2;
            }
        }

        private void btnNumber3(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 3;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 3;
            } else
            {
                lb01.Text += 3;
            }
        }

        private void btnNumber4(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 4;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 4;
            } else
            {
                lb01.Text += 4;
            }
        }

        private void btnNumber5(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 5;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 5;
            } else
            {
                lb01.Text += 5;
            }
        }

        private void btnNumber6(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 6;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 6;
            } else
            {
                lb01.Text += 6;
            }
        }

        private void btnNumber7(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 7;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 7;
            } else
            {
                lb01.Text += 7;
            }
        }

        private void btnNumber8(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 8;
            }
            else if (lb01.Text == "0.")
            {
                lb01.Text += 8;
            } else
            {
                lb01.Text += 8;
            }
        }

        private void btnNumber9(object sender, EventArgs e)
        {
            if (lb01.Text == "0")
            {
                lb01.Text = null;
                lb01.Text += 9;
            } else if (lb01.Text == "0.") {
                lb01.Text += 9;
            } else
            {
                lb01.Text += 9;
            }
        }

        private void btnPonto(object sender, EventArgs e)
        {
            lb01.Text += ".";
        }

        private void btnResultado(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(lb01.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                lb01.Text = Convert.ToString(valor1 + valor2);
                lb02.Text = valor1 + "+" + valor2 + "=";
            } else if (operacao == "SUB")
            {
                lb01.Text = Convert.ToString(valor1 - valor2);
                lb02.Text = valor1 + "-" + valor2 + "=";
            } else if (operacao == "MULTI")
            {
                lb01.Text = Convert.ToString(valor1 * valor2);
                lb02.Text = valor1 + "x" + valor2 + "=";
            } else
            {
                lb01.Text = Convert.ToString(valor1 / valor2);
                lb02.Text = valor1 + "/" + valor2 + "=";
            }

        }

        private void btnSubtracao(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(lb01.Text, CultureInfo.InvariantCulture);
            lb01.Text = "";
            operacao = "SUB";
            lb02.Text = valor1 + "-";
        }

        private void btnSoma(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(lb01.Text, CultureInfo.InvariantCulture);
            lb01.Text = "";
            operacao = "SOMA";
            lb02.Text = valor1 + "+";
        }

        private void btnMulti(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(lb01.Text, CultureInfo.InvariantCulture);
            lb01.Text = "";
            operacao = "MULTI";
            lb02.Text = valor1 + "x";
        }

        private void Apagar(object sender, EventArgs e)
        {
            if(lb01.Text.Length > 0)
            {
                lb01.Text = lb01.Text.Remove(lb01.Text.Length - 1, 1);
            } 

            if(lb01.Text == "")
            {
                lb01.Text = "0";
            }
        }

        private void btnDiv(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(lb01.Text, CultureInfo.InvariantCulture);
            lb01.Text = "";
            operacao = "DIV";
            lb02.Text = valor1 + "/";
        }
    }
}
