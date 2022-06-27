using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Partner2.xaml
    /// </summary>
    public partial class Partner2 : Page
    {
        public ObservableCollection<Base.Partner> Partner;
        public Partner2()
        {
            InitializeComponent();
            Partner = new ObservableCollection<Base.Partner>(SourceCore.MyBase.Partner);
            PartnerGrid.ItemsSource = Partner;

        }
    }
}
