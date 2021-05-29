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

namespace WpfApp9
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

        private void but2_Click(object sender, RoutedEventArgs e)
        {

            //string dodaj = Tekst.Text;
            if (Tekst.Text != "piwo" && Tekst.Text !="Piwo" && Tekst.Text != "wino" && Tekst.Text != "Wino")

            {
                Lab1.Content = "Produkty  :" + (List.Items.Add(Tekst.Text) + 1);
            }
            if (Czek2.IsChecked == true && Tekst.Text == "piwo" )
            {
                MessageBox.Show("Nie jestes pelnoletni!!!");
                List.Items.Remove("piwo");
         
            }
            if(Czek2.IsChecked == true && Tekst.Text == "Piwo")
            {
                MessageBox.Show("Nie jestes pelnoletni!!!");
                List.Items.Remove("Piwo");
            }
            if (Czek2.IsChecked == true && Tekst.Text == "Wino")
            {
                MessageBox.Show("Nie jestes pelnoletni!!!");
                List.Items.Remove("Wino");
            }
            if (Czek2.IsChecked == true && Tekst.Text == "wino")
            {
                MessageBox.Show("Nie jestes pelnoletni!!!");
                List.Items.Remove("wino");
            }

          
            

                //Lab1.Content = "Produkty  :" + (List.Items.Add(Tekst.Text)+1);

                
           
            
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                
        }

        private void ricz_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
           
        }
        private void Czek2_Checked(object sender, RoutedEventArgs e)
        {
            

        }

        private void czek_Checked(object sender, RoutedEventArgs e)
        {

            
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {

            List.Items.Remove(Tekst.Text);
              Lab1.Content="Produkty :" +  List.Items.Add(Tekst.Text);

            List.Items.Remove(Tekst.Text);
        }

        private void List_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Tekst_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Tekst_MouseEnter(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Wpisz produkty do zamówienia ");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
               
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            
            



               


            
         

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
           
         
            
                Tekst1.Background = Brushes.Green;
            MessageBox.Show("Opakowanie zielone");

        }

        private void Tekst_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void czerwonyRed_Checked(object sender, RoutedEventArgs e)
        {
            Tekst1.Background = Brushes.Red;
            MessageBox.Show("Opakowanie czerwone");
        

        }
    }
}
