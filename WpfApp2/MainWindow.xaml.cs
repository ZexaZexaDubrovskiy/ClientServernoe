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
using System.Collections.ObjectModel;
namespace WpfApp2
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

        private void AccessoriesToBoatButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.AccessoriesToBoatPage());
        }

        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.CustomersPage());
        }

        private void ContractButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.ContractPage());
        }

        private void InvoiceButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.InvoicePage());
        }

        private void SalesPersonButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.Sales_PersonPage());
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.OrderPage());
        }

        private void BoatButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.BoatPage());
        }

        private void OrderdetailsButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.OrderDetailsPage());
        }

        private void AccessoryButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.AccessoryPage());
        }

        private void ParnerButton_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.PartnerPage());
        }

        private void AccessoryButton2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PartnerButton2_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.Partner2());
        }

        private void CopyPage_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.CopyPage());
        }
    }
}
