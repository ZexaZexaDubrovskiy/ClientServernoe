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
    /// Interaction logic for CopyPage.xaml
    /// </summary>
    public partial class CopyPage : Page
    {
        public ObservableCollection<Base.Sales_Person> Sales_Persons;
        public CopyPage()
        {
            InitializeComponent();
            Sales_Persons = new ObservableCollection<Base.Sales_Person>(SourceCore.MyBase.Sales_Person);
            SalesPersonGrid.ItemsSource = Sales_Persons;
        }

        

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (FilterComboBox.SelectedIndex)
            {
                case 0:
                    SalesPersonGrid.ItemsSource = SourceCore.MyBase.Sales_Person.Where(q => q.FirstName.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    SalesPersonGrid.ItemsSource = SourceCore.MyBase.Sales_Person.Where(q => q.FamilyName.Contains(textbox.Text)).ToList();
                    break;
                
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Первоначальная настройка фильтра данных для быстрого поиска,
            // при этом из фильтрации нужно исключить столбец "Управление"
            // Создание собствнного списка заголовков столбцов
            List<String> Columns = new List<string>();
            // Перебор и добавление в новый список только необходимых заголовков
            // Исключен столбец 4
            for (int i = 0; i < 2; i++)
            {
                Columns.Add(SalesPersonGrid.Columns[i].Header.ToString());
            }
            FilterComboBox.ItemsSource = Columns;
            FilterComboBox.SelectedIndex = 0;
            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in SalesPersonGrid.Columns)
            {
                Column.CanUserSort = false;
            }

        }
    }
}
