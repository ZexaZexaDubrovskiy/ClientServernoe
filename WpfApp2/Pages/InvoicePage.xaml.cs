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
    /// Interaction logic for InvoicePage.xaml
    /// </summary>
    public partial class InvoicePage : Page
    {
        public InvoicePage()
        {
            InitializeComponent();
            DataContext = this;
            InvoiceGrid.ItemsSource = SourceCore.MyBase.Invoice.ToList();
            InvoiceTextContract_ID.ItemsSource = SourceCore.MyBase.Contract.ToList();
        }
    }
}
