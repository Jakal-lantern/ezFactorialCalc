using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactorialCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            Factorial();
            Permutations();
            Combinations();

        }

        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 24;
            xAnswerBlock.Text = factorial.ToString();
        }


        public void Permutations()
        {
            //TODO: Write Formulate to out put the permutation of 2 numbers. Be sure to utilize the code from the Factorial() above to help you solve the problem. 
            double n = Convert.ToDouble(xNObjects.Text);
            double r = Convert.ToDouble(xRSample.Text);
            double topNum, botNum, number;

            topNum = CalculateFactorial(n);
            botNum = CalculateFactorial(n - r);

            number = topNum / botNum;

            xPermutationAnswer.Text = number.ToString();
        }

        public void Combinations()
        {
            //TODO: Write Formulate to out put the combination of 2 numbers. Be sure to utilize the code from the Factorial() above to help you solve the problem.
            double n = Convert.ToDouble(xNObjects.Text);
            double r = Convert.ToDouble(xRSample.Text);
            double topNum, botNum, number;

            topNum = CalculateFactorial(n);
            botNum = CalculateFactorial(r) * CalculateFactorial(n - r);

            number = topNum / botNum;

            xCombinationAnswer.Text = number.ToString();
        }

        // Returns any number's factorial
        public double CalculateFactorial(double number)
        {
            double factorial = 1;
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }
            return factorial;
        }


        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
