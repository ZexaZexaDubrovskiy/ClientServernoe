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
    /// Interaction logic for ContractPage.xaml
    /// </summary>
    public partial class ContractPage : Page
    {
        public ContractPage()
        {
            InitializeComponent();
            DataContext = this;
            ContractGrid.ItemsSource = SourceCore.MyBase.Contract.ToList();
            ContractTextOrder_ID.ItemsSource = SourceCore.MyBase.Order.ToList();
            ContractDlgLoad(false);
        }

        private int DlgMode = -1;
        private string AccName_buf;
        private string DescriptionOfAccessory_buf;
        private string Price_buf;
        private string VAT_buf;
        private string Inventory_buf;
        private string OrderLevel_buf;
        private string OrderBatch_buf;
        private string Partner_ID_buf;

        public void ContractDlgLoad(bool b)
        {
            if (b == true)
            {
                ContractColumnChange.Width = new GridLength(400);
                ContractGrid.IsHitTestVisible = false;
            }
            else
            {
                ContractColumnChange.Width = new GridLength(0);
                ContractGrid.IsHitTestVisible = true;
            }
        }
    }
}
