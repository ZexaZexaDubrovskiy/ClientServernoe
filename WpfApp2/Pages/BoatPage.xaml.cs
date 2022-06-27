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
    /// Interaction logic for BoatPage.xaml
    /// </summary>
    public partial class BoatPage : Page
    {
        public BoatPage()
        {
            InitializeComponent();
            DataContext = this;
            BoatGrid.ItemsSource = SourceCore.MyBase.Boat.ToList();
            BoatDlgLoad(false);
        }

        private int DlgMode = -1;
        private string Model_buf;
        private string BoatType_buf;
        private string NumberOfRowers_buf;
        private string Mast_buf;
        private string Colour_buf;
        private string Wood_buf;
        private string BasePrice_buf;
        private string VAT_buf;

        public void BoatDlgLoad(bool b)
        {
            if (b == true)
            {
                BoatColumnChange.Width = new GridLength(400);
                BoatGrid.IsHitTestVisible = false;
            }
            else
            {
                BoatColumnChange.Width = new GridLength(0);
                BoatGrid.IsHitTestVisible = true;
            }
        }

        private void BoatAdd_Click(object sender, RoutedEventArgs e)
        {
            BoatDlgLoad(true);
            DlgMode = 0;
            BoatGrid.SelectedItem = null;
            BoatLabel.Content = "Добавить лодку";
            BoatAddCommit.Content = "Добавить лодку";
            BoatTextModel.Text = "";
            BoatComboBoxType.Text = "";
            BoatTextNumberOfRowers.Text = "";
            BoatTextMast.Text = "";
            BoatTextColour.Text = "";
            BoatTextWood.Text = "";
            BoatTextBasePrice.Text = "";
            BoatTextVat.Text = "";
        }

        private void BoatCopy_Click(object sender, RoutedEventArgs e)
        {
            if (BoatGrid.SelectedItem != null)
            {
                BoatDlgLoad(true);
                DlgMode = 0;
                BoatLabel.Content = "Копировать лодку";
                BoatAddCommit.Content = "Копировать лодку";
                Model_buf = BoatTextModel.Text;
                BoatType_buf = BoatComboBoxType.Text;
                NumberOfRowers_buf = BoatTextNumberOfRowers.Text;
                Mast_buf = BoatTextMast.Text;
                Wood_buf= BoatTextWood.Text;
                BasePrice_buf = BoatTextBasePrice.Text;
                VAT_buf = BoatTextVat.Text;
                Colour_buf = BoatTextColour.Text;

                BoatGrid.SelectedItem = null;
                BoatTextModel.Text = Model_buf;
                BoatComboBoxType.Text = BoatType_buf;
                BoatTextNumberOfRowers.Text = NumberOfRowers_buf;
                BoatTextMast.Text = Mast_buf;
                BoatTextWood.Text = Wood_buf;
                BoatTextBasePrice.Text = Wood_buf;
                BoatTextVat.Text = VAT_buf;
                BoatTextColour.Text = Colour_buf;
            }
            else
            {
                MessageBox.Show("Не выбрано ни odnoy строки!", "Сообщение", MessageBoxButton.OK);
            }
        }

        private void BoatEdit_Click(object sender, RoutedEventArgs e)
        {
            if (BoatGrid.SelectedItem != null)
            {
                BoatDlgLoad(true);
                BoatLabel.Content = "Изменить лодку";
                BoatAddCommit.Content = "Изменить лодку";
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной строки!", "Сообщение", MessageBoxButton.OK);
            }
        }

        private void BoatDellete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                SourceCore.MyBase.Boat.Remove((Base.Boat)BoatGrid.SelectedItem);
                SourceCore.MyBase.SaveChanges();
            }
        }

        private void BoatAddCommit_Click(object sender, RoutedEventArgs e)
        {
            var NewBoat = new Base.Boat();
            NewBoat.Model = BoatTextModel.Text;
            NewBoat.BoatType = BoatComboBoxType.Text;
            NewBoat.NumberOfRowers = int.Parse(BoatTextNumberOfRowers.Text);
            NewBoat.Mast = BoatTextMast.Text;
            NewBoat.Colour = BoatTextColour.Text;
            NewBoat.Wood = BoatTextWood.Text;
            NewBoat.BasePrice = BoatTextBasePrice.Text;
            NewBoat.VAT = BoatTextVat.Text;
            if (DlgMode == 0)
            {
                SourceCore.MyBase.Boat.Add(NewBoat);
            }
            SourceCore.MyBase.SaveChanges();
            BoatDlgLoad(false);
        }

        private void BoatAddRollback_Click(object sender, RoutedEventArgs e)
        {
            BoatDlgLoad(false);
        }
    }
}
