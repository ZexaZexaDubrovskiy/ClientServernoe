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
    /// Interaction logic for Sales_PersonPage.xaml
    /// </summary>
    public partial class Sales_PersonPage : Page
    {
        public Sales_PersonPage()
        {
            InitializeComponent();
            DataContext = this;
            Sales_PersonGrid.ItemsSource = SourceCore.MyBase.Sales_Person.ToList();
        }
    }
}
