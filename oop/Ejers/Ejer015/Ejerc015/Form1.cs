namespace Ejerc015
{
    public partial class Form1 : Form
    {
        public double? saved;
        public double? ans;
        public string typed;
        public enum operation
        {
            Add,
            Substract,
            Multiply,
            Divide
        }
        public operation? storedop;


        public Form1()
        {
            typed = "";
            saved = null;
            InitializeComponent();
        }

        public void Render(string? text = null)
        {
            textBox1.Text = text ?? typed;
        }
        public void Render(double? text)
        {
            textBox1.Text = text!=null ? Convert.ToString( text ) : typed;
        }

        public void Execop(operation? op)
        {

            if (typed == "")
                storedop = op;
            else
            {
                if (saved == null)
                {
                    storedop = op;
                    saved = Convert.ToDouble(typed);
                    typed = "";
                }

                else
                {
                    switch (storedop) {
                        case operation.Add:
                            saved = saved + Convert.ToDouble(typed);
                            break;
                        case operation.Substract:
                            saved = saved - Convert.ToDouble(typed);
                            break;
                        case operation.Multiply:
                            saved = saved * Convert.ToDouble(typed);
                            break;
                        case operation.Divide:
                            if (Convert.ToDouble(typed)==0)
                            {
                                MessageBox.Show("No se puede dividir por 0");
                                return;
                            }
                            saved = saved / Convert.ToDouble(typed);
                            break;
                        default:
                            break;
                    }
                    storedop = op;
                    typed = "";
                    Render(saved);


                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            typed = typed.Substring(0, typed.Length - 1);
            Render();

        }



        private void num9_Click(object sender, EventArgs e)
        {
            typed = typed + "9";
            Render();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            typed = typed + "8";
            Render();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            typed = typed + "7";
            Render();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            typed = typed + "6";
            Render();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            typed = typed + "5";
            Render();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            typed = typed + "4";
            Render();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            typed = typed + "3";
            Render();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            typed = typed + "2";
            Render();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            typed = typed + "1";
            Render();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (typed != "")
                typed = typed + "0";
            Render();


        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!typed.Contains(Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator))
                typed = typed + Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            Render();
        }

        private void ac_Click(object sender, EventArgs e)
        {
            typed = "";
            storedop = null;
            Render();
        }

        private void times_Click(object sender, EventArgs e)
        {
            Execop(operation.Multiply);
        }

        private void division_Click(object sender, EventArgs e)
        {
            Execop(operation.Divide);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Execop(operation.Add);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Execop(operation.Substract);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            Execop(null);
            ans = saved;
            saved = null;
        }

        private void exp_Click(object sender, EventArgs e)
        {
            if (saved == null && typed==null)
                return;
            Execop(null);
            if (Math.Abs((double)(saved % 1)) < 0.000001)
            {
                long counter = Convert.ToInt64(saved);
                long result = Convert.ToInt64(saved);
                while (counter > 1)
                {
                    counter--;
                    result = result * counter;
                }

            } else
            {
                MessageBox.Show("Debe ser un entero. Funcion gamma no implementada.");
            }

        }

        private void ansb_Click(object sender, EventArgs e)
        {
            //>> def cuil(dni, num):
           //...     x = sum(map(lambda x: x[0] * x[1], zip(list(string(num) + string(dni)), [5, 4, 3, 2, 7, 6, 5, 4, 3, 2])))...     return 11 - round(10 * (x / 11 - x//11))
        }
    }
}