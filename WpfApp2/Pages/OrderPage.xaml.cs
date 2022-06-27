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

namespace WpfApp2.Pages
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            DataContext = this;
            OrderGrid.ItemsSource = SourceCore.MyBase.Order.ToList();
            OrderTextSalesperson_ID.ItemsSource = SourceCore.MyBase.Sales_Person.ToList();
            OrderTextCustomer_ID.ItemsSource = SourceCore.MyBase.Customers.ToList();
            OrderTextBoat_ID.ItemsSource = SourceCore.MyBase.Boat.ToList();
        }
    }
}
