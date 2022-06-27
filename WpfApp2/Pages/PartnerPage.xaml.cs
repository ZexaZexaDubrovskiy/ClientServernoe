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
    /// Interaction logic for PartnerPage.xaml
    /// </summary>
    public partial class PartnerPage : Page
    {
        public PartnerPage()
        {
            InitializeComponent();
            DataContext = this;
            PartnerGrid.ItemsSource = SourceCore.MyBase.Partner.ToList();
            PartnerDlgLoad(false);
        }

        private int DlgMode = -1;
        private string Name_buf;
        private string Address_buf;
        private string City_buf;


        public void PartnerDlgLoad(bool b)
        {
            if (b == true)
            {
                PartnerColumnChange.Width = new GridLength(400);
                PartnerGrid.IsHitTestVisible = false;
            }
            else
            {
                PartnerColumnChange.Width = new GridLength(0);
                PartnerGrid.IsHitTestVisible = true;
            }
        }

        private void PartnerAdd_Click(object sender, RoutedEventArgs e)
        {
            PartnerDlgLoad(true);
            DlgMode = 0;
            PartnerGrid.SelectedItem = null;
            PartnerLabel.Content = "Добавить партнера";
            PartnerAddCommit.Content = "Добавить партнера";
            PartnerTextName.Text = "";
            PartnerTextAddress.Text = "";
            PartnerTextCity.Text = "";

        }

        private void PartnerCopy_Click(object sender, RoutedEventArgs e)
        {
            if (PartnerGrid.SelectedItem != null)
            {
                PartnerDlgLoad(true);
                DlgMode = 0;
                PartnerLabel.Content = "Копировать партнера";
                PartnerAddCommit.Content = "Копировать партнера";
                Name_buf = PartnerTextName.Text;
                Address_buf = PartnerTextAddress.Text;
                City_buf = PartnerTextCity.Text;

                PartnerGrid.SelectedItem = null;
                PartnerTextName.Text = Name_buf;
                PartnerTextAddress.Text = Address_buf;
                PartnerTextCity.Text = City_buf;
            }
            else
            {
                MessageBox.Show("Не выбрано ни odnoy строки!", "Сообщение", MessageBoxButton.OK);
            }

        }

        private void PartnerEdit_Click(object sender, RoutedEventArgs e)
        {
            if (PartnerGrid.SelectedItem != null)
            {
                PartnerDlgLoad(true);
                PartnerLabel.Content = "Изменить Партнера";
                PartnerAddCommit.Content = "Изменить Партнера";
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной строки!", "Сообщение", MessageBoxButton.OK);
            }

        }

        private void PartnerDellete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                SourceCore.MyBase.Partner.Remove((Base.Partner)PartnerGrid.SelectedItem);
                SourceCore.MyBase.SaveChanges();
            }
        }

        private void PartnerAddCommit_Click(object sender, RoutedEventArgs e)
        {
            var NewPartner = new Base.Partner();
            NewPartner.Name = PartnerTextName.Text;
            NewPartner.Address = PartnerTextAddress.Text;
            NewPartner.City = PartnerTextCity.Text;
            if (DlgMode == 0)
            {
                SourceCore.MyBase.Partner.Add(NewPartner);
            }
            SourceCore.MyBase.SaveChanges();
            PartnerDlgLoad(false);
        }

        private void PartnerAddRollback_Click(object sender, RoutedEventArgs e)
        {
            PartnerDlgLoad(false);
        }
    }
}
