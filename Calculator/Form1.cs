using System.Collections.Specialized;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Calculator
{
    public partial class Calculator : Form
    {
        bool is_First = true;
        bool first_deci = false;
        bool is_shift=false;
        float Opr1 = 0;
        float Opr2=0;
        char op;
        public Calculator()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
                      
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "1";
                is_First =false; 
            }
            else
            {
                PrintScreen.Text += "1";
            }
            is_shift = false;

        }

        private void PrintScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "2";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "2";
            }
            is_shift = false;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "3";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "3";
            }
            is_shift = false;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "4";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "4";
            }
            is_shift = false;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "5";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "5";
            }
            is_shift = false;

        }

        private void six_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "6";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "6";
            }
            is_shift = false;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "7";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "7";
            }
            is_shift = false;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "8";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "8";
            }
            is_shift = false;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "9";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "9";
            }
            is_shift = false;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += "0";
                is_First = false;
            }
            else
            {
                PrintScreen.Text += "0";
            }
            is_shift = false;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Opr1 = float.Parse(PrintScreen.Text);
            op = '+';
            PrintScreen.Text = "";
            is_shift = false;
            first_deci = false;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Opr1 = float.Parse(PrintScreen.Text);
            op = '-';
            PrintScreen.Text = "";
            is_shift = false;
            first_deci = false;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Opr1 = float.Parse(PrintScreen.Text);
            op = '/';
            PrintScreen.Text = "";
            is_shift = false;
            first_deci = false;
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Opr1 = float.Parse(PrintScreen.Text);
            op = 'x';
            PrintScreen.Text = "";
            is_shift = false;
            first_deci = false;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Opr2 = float.Parse(PrintScreen.Text);
            is_shift = false;
            switch(op)
            {
                case '+':
                    
                    PrintScreen.Text = ((Opr1 + Opr2)).ToString();

                    break;
                case '-':
                    PrintScreen.Text = (Opr1 - Opr2).ToString();
                    break;
                case '/':
                    PrintScreen.Text = (Opr1 / Opr2).ToString();
                    break;
                case 'x':
                    PrintScreen.Text = (Opr1 * Opr2).ToString();
                    break;
                case '%':
                    int x = ((int)Opr1);
                    int y = ((int)Opr2);
                    PrintScreen.Text = (x % y).ToString();
                    break;
                case '^':
                             // Opr1 is base value and Op2 is exponential value
                    PrintScreen.Text = (Math.Pow(Opr1 , Opr2)).ToString();
                    break;
            }

        }

        private void CLR_Click(object sender, EventArgs e)
        {
            PrintScreen.Text = "";
            Opr1 = 0;
            Opr2 = 0;
            op = ' ';
            first_deci = false;
            is_shift = false;
        }

        private void decemal_Click(object sender, EventArgs e)
        {
            if (is_First == true && first_deci==false)
            {
                PrintScreen.Text = "";
                PrintScreen.Text += ".";
                is_First = false;
                first_deci = true;
            }
            else if(first_deci == false)
            {
                PrintScreen.Text += ".";
                first_deci = true;
            }
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            Opr1 = float.Parse(PrintScreen.Text);
            op = '%';
            first_deci = false;
            PrintScreen.Text = "";
        }

        private void Sine_Click(object sender, EventArgs e)
        {
            double ans;
            Opr1 = float.Parse(PrintScreen.Text);
            if(is_shift==true)
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                double radians = Opr1 * (Math.PI / 180);
                ans = ((float)Math.Sinh(radians));
                is_shift=false;
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            else
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                double radians = Opr1 * (Math.PI / 180);
                ans = ((float)Math.Sin(radians));
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            

        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double ans;
            Opr1 = float.Parse(PrintScreen.Text);
            if(is_shift== true) 
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }


                double radians = Opr1 * (Math.PI / 180);
                ans = ((float)Math.Cosh(radians));
                is_shift = false;
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            else
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }


                double radians = Opr1 * (Math.PI / 180);
                ans = ((float)Math.Cos(radians));
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            

        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double ans;
            Opr1 = float.Parse(PrintScreen.Text);
            if (is_shift==true)
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }
                double radians = Opr1 * (Math.PI / 180);
                ans = ((float)Math.Tanh(radians));
                is_shift = false;
                PrintScreen.Text = string.Format("{0:}", ans);

            }
            else
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                if (Opr1 == (float)90 || Opr1 == (float)270)
                {
                    PrintScreen.Text = "Math error";
                    return;
                }
                double radians = Opr1 * (Math.PI / 180);
                ans = ((float)Math.Tan(radians));
                PrintScreen.Text = string.Format("{0:}", ans);

            }
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            double ans;
            Opr1 = float.Parse(PrintScreen.Text);
            if (is_shift == true)
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                
                double radians = Opr1 * (Math.PI / 180);
                ans = (1.0 / (Math.Tanh(radians)));
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            else
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                if (Opr1 == (float)90 || Opr1 == (float)270)
                {
                    PrintScreen.Text = "Math error";
                    return;
                }
                double radians = Opr1 * (Math.PI / 180);
                ans = (1.0 / (Math.Tan(radians)));
                PrintScreen.Text = string.Format("{0:}", ans);

            }


        }

        private void Cosec_Click(object sender, EventArgs e)
        {
            double ans;
            Opr1 = float.Parse(PrintScreen.Text);
            if (is_shift == true)
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }
                double radians = Opr1 * (Math.PI / 180);
                ans = (1.0 / (Math.Sinh(radians)));
                is_shift = false;
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            else
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }
                double radians = Opr1 * (Math.PI / 180);
                ans = (1.0 / (Math.Sin(radians)));
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            
            double ans;
            Opr1 = float.Parse(PrintScreen.Text);
            if(is_shift==true)
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                double radians = Opr1 * (Math.PI / 180);
                ans = (1.0 / (Math.Cosh(radians)));
                is_shift = false;
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            else
            {
                if (Opr1 > (float)360)
                {
                    Opr1 = Opr1 - (float)360;
                }

                double radians = Opr1 * (Math.PI / 180);
                ans = (1.0 / (Math.Cos(radians)));
                PrintScreen.Text = string.Format("{0:}", ans);
            }
            
        }

        private void Power_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
            }
            else
            {
                Opr1 = float.Parse(PrintScreen.Text);
                op = '^';
                PrintScreen.Text = "";
            }
        }
        private int factorial(int n) 
        {
            int  f= 1;
            for(int i=1;i<=n;i++)
            {
                f *= i;
            }

            return f;
        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            if (is_First == true)
            {
            }
            else
            {
                Opr1 = float.Parse(PrintScreen.Text);
                int ans=(int)Opr1;
                ans = factorial(ans);
                PrintScreen.Text = string.Format("{0:0}", ans);
            }
        }

        private void Log_Click(object sender, EventArgs e)
        {
            Opr1 = float.Parse(PrintScreen.Text);
            double ans =0;
            
            
                    // Ln with base e  -> Math.Log = Ln
                if (is_shift == true)
                {
                    ans = (double)Math.Log(Opr1);
                    PrintScreen.Text = string.Format("{0:}", ans);
                    is_shift = false;
                    return;
                }
                  // Log with base 10 ->Math.Log10
                else
                {
                    ans = (double)Math.Log10(Opr1);
                    PrintScreen.Text = string.Format("{0:}", ans);
                    return;
                }
            
            
        }

        private void Shft_Click(object sender, EventArgs e)
        {
            is_shift = true;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if(PrintScreen.Text!="")
            {
                string x = PrintScreen.Text;
                x = x.Substring(0, x.Length - 1);
                PrintScreen.Text = x;
            }
            
        }

        private void Ln_Click(object sender, EventArgs e)
        {

        }
    }
}




