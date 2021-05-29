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

namespace WpfApp7
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal a = decimal.Parse(Text2.Text);
            decimal b = decimal.Parse(Text3.Text);

            decimal c = a + b;


            text1.Text = $" Suma to : { a} + {b} =  {c}";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            decimal a = decimal.Parse(Text2.Text);
            decimal b = decimal.Parse(Text3.Text);

            decimal c = a - b;


            text1.Text = $" Różnica  to : { a} - {b} =  {c}";


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            decimal a = decimal.Parse(Text2.Text);
            decimal b = decimal.Parse(Text3.Text);

            decimal c = a * b;


            text1.Text = $" Iloczyn  to : { a} * {b} =  {c}";


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Text2.Text);
            double b = double.Parse(Text3.Text);

            double c = a / b;


         //  text1.Text = $" Iloraz to  to : { a} / {b} =  {c}";

            if (  a==0 ||b==0)
            { 
                MessageBox.Show("Nie dziel przez zero! ");
                text1.Text = "Nie dziel przez zero!";

            }
         else
            {
                text1.Text = $" Iloraz to  to : { a} / {b} =  {c}";
            }
            

            }

        } 
}
