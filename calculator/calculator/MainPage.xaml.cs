using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundColor = Color.LightCyan;
        }
        private void one(object args,EventArgs e)
        {
            SetConclusion("1",true);
        }
        private void two(object args, EventArgs e)
        {
            SetConclusion("2",true);

        }
        private void three(object args, EventArgs e)
        {
            SetConclusion("3",true);

        }
        private void four(object args, EventArgs e)
        {
            SetConclusion("4",true);

        }
        private void five(object args, EventArgs e)
        {
            SetConclusion("5",true);

        }
        private void six(object args, EventArgs e)
        {
            SetConclusion("6",true);

        }
        private void seven(object args, EventArgs e)
        {
            SetConclusion("7",true);

        }
        private void eight(object args, EventArgs e)
        {
            SetConclusion("8",true);

        }

        private void nine(object args, EventArgs e)
        {
            SetConclusion("9",true);

        }

        private void plus(object args, EventArgs e)
        {
            SetConclusion(" + ",false);

        }
        private void minus(object args, EventArgs e)
        {
            SetConclusion(" - ",false);

        }

        private void multiplication(object args, EventArgs e)
        {
            SetConclusion(" * ",false);

        }
        private void division(object args, EventArgs e)
        {
            SetConclusion(" / ",false);

        }
        private void point(object args, EventArgs e)
        {
            SetConclusion(".", false);
        }
        private void degree(object args, EventArgs e)
        {
            SetConclusion(" ** ", false);
        }
        private void remains(object args, EventArgs e)
        {
            SetConclusion(" % ", false);
        }
        private void reset(object args, EventArgs e)
        {
            ClearConclusion();

        }
        private void result(object args, EventArgs e)
        {
            String[] numbers = conclusion.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int allNumbers = numbers.Length;
           if (allNumbers >= 3)
            {
                double results = 0;
                switch (numbers[1])
                {
                    case "+":
                        results = Convert.ToSingle(numbers[0]) + Convert.ToSingle(numbers[2]);
                        break;
                    case "-":
                        results = Convert.ToSingle(numbers[0]) - Convert.ToSingle(numbers[2]);
                        break;
                    case "/":
                        results = Convert.ToSingle(numbers[0]) / Convert.ToSingle(numbers[2]);
                        break;
                    case "*":
                        results = Convert.ToSingle(numbers[0]) * Convert.ToSingle(numbers[2]);
                        break;
                    case "**":
                        results = Math.Pow(Convert.ToDouble(numbers[0]) ,Convert.ToDouble(numbers[2]));
                        break;
                    case "%":
                        results = Convert.ToSingle(numbers[0]) % Convert.ToSingle(numbers[2]);
                        break;
                    default:
                        results = 0;
                        break;

                }
                conclusion.Text += " = " + results.ToString();
            }
        }
        private void SetConclusion(string conclusion,bool isNumber)
        {
            String[] numbers = this.conclusion.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int allNumbers = numbers.Length;
            if (allNumbers<3 || isNumber)
            {
                 this.conclusion.Text += conclusion;
            }
        }
        private void ClearConclusion()
        {
            conclusion.Text = "";
        }
    }
}
