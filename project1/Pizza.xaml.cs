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
using System.Windows.Shapes;

namespace project1
{
    /// <summary>
    /// Interaction logic for Pizza.xaml
    /// </summary>
    public partial class Pizza : Window
    {
        public int sizePrice = 0;
        public int addon = 0;
        public int counter = 0; 
      
        public Pizza()
        {
            InitializeComponent();

            welcomeLbl.Content = "The age is " + MainWindow.name;
        }

        public void addAddon() {
            Console.WriteLine("checked");

           
            counter++;



            if (counter > 3)
            {
                int extras = counter - 3;

                addon = extras * 1;

            }
            else
            {
                addon = 0;
            }

            totalLbl.Content = (sizePrice + addon).ToString();

 
        }

        public void removeAddon() {

            Console.WriteLine("unchecked");
            
            Console.WriteLine("before removing " + counter);
            counter--;

            Console.WriteLine("after removing " + counter);


            if (counter > 3)
            {
                int extras = counter - 3;

                addon = extras * 1;

            }
            else
            {
                addon = 0;
            }

            totalLbl.Content = (sizePrice + addon).ToString();

 
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 5;
            totalLbl.Content = sizePrice.ToString();
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 7;
            totalLbl.Content = sizePrice.ToString();
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 10;
            totalLbl.Content = sizePrice.ToString();
        }


        private void chk1_Checked(object sender, RoutedEventArgs e)
        {
            if (chk1.IsChecked == true) {
                addAddon();
            }
            else
            {
               
                removeAddon();
            }

        }

        private void chk2_Checked(object sender, RoutedEventArgs e)
        {

            if (chk2.IsChecked == true)
            {
               
               addAddon();
            }
            else
            {
               removeAddon();
            }
        }

        private void chk3_Checked(object sender, RoutedEventArgs e)
        {
            if (chk3.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }

        }

        private void chk4_Checked(object sender, RoutedEventArgs e)
        {
            if (chk4.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void chk6_Checked(object sender, RoutedEventArgs e)
        {
            if (chk6.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }

        private void chk5_Checked(object sender, RoutedEventArgs e)
        {
            if (chk5.IsChecked == true)
            {
                addAddon();
            }
            else
            {
                removeAddon();
            }
        }
    }
}
