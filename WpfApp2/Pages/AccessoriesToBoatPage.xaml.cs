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
    /// Interaction logic for AccessoriesToBoatPage.xaml
    /// </summary>
    public partial class AccessoriesToBoatPage : Page
    {
        public AccessoriesToBoatPage()
        {
            InitializeComponent();
            DataContext = this;
            AccessoriesToBoatGrid.ItemsSource = SourceCore.MyBase.AccessoriesToBoat.ToList();
            AccessoriesToBoatTextAccessory_ID.ItemsSource = SourceCore.MyBase.Accessory.ToList();
            AccessoriesToBoatTextBoat_ID.ItemsSource = SourceCore.MyBase.Boat.ToList();
        }

        private int DlgMode;
        private string Accessory_ID_buf;
        private string Boat_ID_buf;

        public void AccessoriesToBoatDlgLoad(bool b)
        {
            if (b == true)
            {
                AccessoriesToBoatColumnChange.Width = new GridLength(400);
                AccessoriesToBoatGrid.IsHitTestVisible = false;
            }
            else
            {
                AccessoriesToBoatColumnChange.Width = new GridLength(0);
                AccessoriesToBoatGrid.IsHitTestVisible = true;
            }
        }





        private void AccessoriesToBoatAddCommit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccessoriesToBoatAddRollback_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccessoriesToBoatAdd_Click(object sender, RoutedEventArgs e)
        {
            AccessoriesToBoatDlgLoad(true);
            DlgMode = 0;
            AccessoriesToBoatGrid.SelectedItem = null;
            AccessoriesToBoatLabel.Content = "Добавить аксекссуар к лодке";
            AccessoriesToBoatAddCommit.Content = "Добавить аксекссуар к лодке";
            AccessoriesToBoatTextAccessory_ID.Text = "";
            AccessoriesToBoatTextBoat_ID.Text = "";

        }

        private void AccessoriesToBoatCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccessoriesToBoatEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccessoriesToBoatDellete_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
