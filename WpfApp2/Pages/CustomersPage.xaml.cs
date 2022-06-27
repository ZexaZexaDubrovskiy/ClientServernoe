using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for CustomersPage.xaml
    /// </summary>
    public partial class CustomersPage : Page
    {
        public CustomersPage()
        {
            InitializeComponent();
            DataContext = this;
            CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Первоначальная настройка фильтра данных для быстрого поиска,
            // при этом из фильтрации нужно исключить столбец "Управление"
            // Создание собствнного списка заголовков столбцов
            List<String> Columns = new List<string>();
            // Перебор и добавление в новый список только необходимых заголовков
            // Исключен столбец 4
            for (int i = 0; i < 10 ; i++)
            {
                Columns.Add(CustomersGrid.Columns[i].Header.ToString());
            }
            CustomersFilterComboBox.ItemsSource = Columns;
            CustomersFilterComboBox.SelectedIndex = 0;
            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in CustomersGrid.Columns)
            {
                Column.CanUserSort = false;
            }

        }

        private void CustomersFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (CustomersFilterComboBox.SelectedIndex)
            {
                case 0:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.FistName.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.FamilyName.Contains(textbox.Text)).ToList();
                    break;
                case 2:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => ((string)ConverterValue.Instanse.Convert(q.DateOfBirth, typeof(string), null, CultureInfo.CurrentCulture)).Contains(textbox.Text)).ToList();
                    break;
                case 3:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.OrganisationName.Contains(textbox.Text)).ToList();
                    break;
                case 4:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.Address.Contains(textbox.Text)).ToList();
                    break;
                case 5:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.City.Contains(textbox.Text)).ToList();
                    break;
                case 6:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.email.Contains(textbox.Text)).ToList();
                    break;
                case 7:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.Phone.Contains(textbox.Text)).ToList();
                    break;
                case 8:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.IDNumber.Contains(textbox.Text)).ToList();
                    break;
                case 9:
                    CustomersGrid.ItemsSource = SourceCore.MyBase.Customers.Where(q => q.IDDocumentName.Contains(textbox.Text)).ToList();
                    break;
            }

        }
    }
}
