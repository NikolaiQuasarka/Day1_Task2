using System.Globalization;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(a_textBox.Text, out double a) & Double.TryParse(b_textBox.Text, out double b) &
            CountDigits(a)>=4 & CountDigits(b)>=4   )

            {
                double f = Math.Atan((Math.Cos(2*Math.PI*Math.Pow(b,2))+Math.Pow(a,3))/
                    (Math.Sqrt(1.87+Math.Pow(a,2)/(b+Math.Cos(3.42*Math.Pow(b,2))))));
                f_textBox.Text=f.ToString();
            }
        }

        public static int CountDigits(double number)
        {
           
            string numberString = number.ToString(CultureInfo.InvariantCulture);

            
            numberString = numberString.Replace("-", "").Replace(CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator, "");

            int digitCount = 0;
            foreach (char c in numberString)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }

    }
}
