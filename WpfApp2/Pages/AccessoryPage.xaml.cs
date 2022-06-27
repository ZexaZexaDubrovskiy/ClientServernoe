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
using System.Collections.ObjectModel;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Interaction logic for AccessoryPage.xaml
    /// </summary>
    public partial class AccessoryPage : Page
    {
        //new
        public AccessoryPage()
        {
            InitializeComponent();
            UpdateGrid(null);
            AccessoryDlgLoad(false, "");
            DataContext = this;
            AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.ToList();
            AccessoryTextPartner_ID.ItemsSource = SourceCore.MyBase.Partner.ToList();
        }

        //new
        private int DlgMode = -1;
        public Base.Accessory SelectedAccessory;
        public ObservableCollection<Base.Accessory> Accessory;

        //new
        public void AccessoryDlgLoad(bool b, string DlgModeContent)
        {
            if (b == true)
            {
                AccessoryColumnChange.Width = new GridLength(400);
                AccessoryGrid.IsHitTestVisible = false;
                AccessoryLabel.Content = DlgModeContent;
                AccessoryAddCommit.Content = DlgModeContent; //chto eto&
                AccessoryAdd.IsEnabled = false;
                AccessoryCopy.IsEnabled = false;
                AccessoryEdit.IsEnabled = false;
                AccessoryDellete.IsEnabled = false;
            }
            else
            {
                AccessoryColumnChange.Width = new GridLength(0);
                AccessoryGrid.IsHitTestVisible = true;
                AccessoryAdd.IsEnabled = true;
                AccessoryCopy.IsEnabled = true;
                AccessoryEdit.IsEnabled = true;
                AccessoryDellete.IsEnabled = true;
                DlgMode = -1;
            }

        }
        //new
        private void AccessoryAdd_Click(object sender, RoutedEventArgs e)
        {
            AccessoryDlgLoad(true, "Добавить Аксекссуар");
            DataContext = null; 
            DlgMode = 0;
        }
        //new
        private void AccessoryCopy_Click(object sender, RoutedEventArgs e)
        {
            if (AccessoryGrid.SelectedItem != null)
            {
                AccessoryDlgLoad(true, "Копировать Аксекссуар");
                SelectedAccessory = (Base.Accessory)AccessoryGrid.SelectedItem;
                //text
                AccessoryTextAccName.Text = SelectedAccessory.AccName;
                AccessoryTextDescriptionOfAccessory.Text = SelectedAccessory.DescriptionOfAccessory;
                AccessoryTextPrice.Text = SelectedAccessory.Price;
                AccessoryTextVAT.Text = SelectedAccessory.VAT;
                AccessoryTextInventory.Text = SelectedAccessory.Inventory.ToString();
                AccessoryTextOrderLevel.Text = SelectedAccessory.OrderLevel.ToString();
                AccessoryTextOrderBatch.Text = SelectedAccessory.OrderBatch.ToString();
                //combo
                AccessoryTextPartner_ID.Text = SelectedAccessory.Partner.Name;

                DlgMode = 0;
            }
            else
            {
                MessageBox.Show("Не выбрано ниодной строки!", "Сообщение", MessageBoxButton.OK);
            }

        }
        //new
        private void AccessoryEdit_Click(object sender, RoutedEventArgs e)
        {
            if (AccessoryGrid.SelectedItem != null)
            {
                AccessoryDlgLoad(true, "Изменить Аксекссуар");
                SelectedAccessory = (Base.Accessory)AccessoryGrid.SelectedItem;
                //text
                AccessoryTextAccName.Text = SelectedAccessory.AccName;
                AccessoryTextDescriptionOfAccessory.Text = SelectedAccessory.DescriptionOfAccessory;
                AccessoryTextPrice.Text = SelectedAccessory.Price;
                AccessoryTextVAT.Text = SelectedAccessory.VAT;
                AccessoryTextInventory.Text = SelectedAccessory.Inventory.ToString();
                AccessoryTextOrderLevel.Text = SelectedAccessory.OrderLevel.ToString();
                AccessoryTextOrderBatch.Text = SelectedAccessory.OrderBatch.ToString();
                //combo
                AccessoryTextPartner_ID.Text = SelectedAccessory.Partner.Name;

            }
            else
            {
                MessageBox.Show("Не выбрано ни одной строки!", "Сообщение", MessageBoxButton.OK);
            }
        }
        //new с определения новой позиции указателя   
        private void AccessoryDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Внимание", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {

                try
                {
                    // Ссылка на удаляемую Accessory
                    Base.Accessory DeletingAccessory = (Base.Accessory)AccessoryGrid.SelectedItem;
                    // Определение ссылки, на которую должен перейти указатель после удаления
                    if (AccessoryGrid.SelectedIndex < AccessoryGrid.Items.Count - 1)
                    {
                        AccessoryGrid.SelectedIndex++;
                    }
                    else
                    {
                        if (AccessoryGrid.SelectedIndex > 0)
                        {
                            AccessoryGrid.SelectedIndex--;
                        }
                    }
                    Base.Accessory SelectingAccessory = (Base.Accessory)AccessoryGrid.SelectedItem;
                    SourceCore.MyBase.Accessory.Remove(DeletingAccessory);
                    SourceCore.MyBase.SaveChanges();
                    UpdateGrid(SelectingAccessory);
                }
                catch
                {

                    MessageBox.Show("Невозможно удалить запись, так как она используется в других справочниках базы данных.",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.None);
                }
            }
        }
        //new
        private void AccessoryAddRollback_Click(object sender, RoutedEventArgs e)
        {
            AccessoryDlgLoad(false, "");
            UpdateGrid(SelectedAccessory);
        }

        //new update dodelat
        public void UpdateGrid(Base.Accessory Accessory)
        {
            if ((Accessory == null) && (AccessoryGrid.ItemsSource != null))
            {
                Accessory = (Base.Accessory)AccessoryGrid.SelectedItem;
            }

            ObservableCollection<Base.Accessory>  Accessorys = new ObservableCollection<Base.Accessory>(SourceCore.MyBase.Accessory);
            AccessoryGrid.ItemsSource = Accessorys;
            AccessoryGrid.SelectedItem = Accessory;
            AccessoryTextPartner_ID.ItemsSource = SourceCore.MyBase.Partner.ToList();

        }

        //вообще не трогай
        public Boolean Proverka()
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(AccessoryTextAccName.Text))
                errors.AppendLine("Укажите название AccName");
            if (string.IsNullOrEmpty(AccessoryTextDescriptionOfAccessory.Text))
                errors.AppendLine("Укажите название AccName");
            if (string.IsNullOrEmpty(AccessoryTextPrice.Text))
                errors.AppendLine("Укажите название Price");
            if (string.IsNullOrEmpty(AccessoryTextVAT.Text))
                errors.AppendLine("Укажите название VAT");
            if (int.TryParse(AccessoryTextVAT.Text, out int number))
            {
                if (int.Parse(AccessoryTextVAT.Text) < 0 || int.Parse(AccessoryTextVAT.Text) > 1)
                    errors.AppendLine("значение должно быть <= x <= 1");
            }
            if (string.IsNullOrEmpty(AccessoryTextInventory.Text))
                errors.AppendLine("Укажите название Inventory");
            if (string.IsNullOrEmpty(AccessoryTextOrderLevel.Text))
                errors.AppendLine("Укажите название OrderLevel");
            if (string.IsNullOrEmpty(AccessoryTextOrderBatch.Text))
                errors.AppendLine("Укажите название OrderBatch");
            if ((Base.Partner)AccessoryTextPartner_ID.SelectedItem == null)
                errors.AppendLine("Укажите Partner");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }
            return true;
        }
        //new
        private void AccessoryAddCommit_Click(object sender, RoutedEventArgs e)
        {
            if (!Proverka())
                return;

            if (DlgMode == 0)
            {
                //text
                var NewAccessory = new Base.Accessory();
                NewAccessory.AccName = AccessoryTextAccName.Text;
                NewAccessory.DescriptionOfAccessory = AccessoryTextDescriptionOfAccessory.Text;
                NewAccessory.Price = AccessoryTextPrice.Text;
                NewAccessory.VAT = AccessoryTextVAT.Text;
                NewAccessory.Inventory = int.Parse(AccessoryTextInventory.Text);
                NewAccessory.OrderLevel = int.Parse(AccessoryTextOrderLevel.Text);
                NewAccessory.OrderBatch = int.Parse(AccessoryTextOrderBatch.Text);

                //ComboBox
                NewAccessory.Partner = AccessoryTextPartner_ID.SelectedItem as Base.Partner;
                SourceCore.MyBase.Accessory.Add(NewAccessory);
                SelectedAccessory = NewAccessory;
            }
            else
            {
                var EditAccessory = new Base.Accessory();
                EditAccessory = SourceCore.MyBase.Accessory.First(p => p.Accessory_ID == SelectedAccessory.Accessory_ID);
                EditAccessory.AccName = AccessoryTextAccName.Text;
                EditAccessory.DescriptionOfAccessory = AccessoryTextDescriptionOfAccessory.Text;
                EditAccessory.Price = AccessoryTextPrice.Text;
                EditAccessory.VAT = AccessoryTextVAT.Text;
                EditAccessory.Inventory = int.Parse(AccessoryTextInventory.Text);
                EditAccessory.OrderLevel = int.Parse(AccessoryTextOrderLevel.Text);
                EditAccessory.OrderBatch = int.Parse(AccessoryTextOrderBatch.Text);
            }

            try
            {
                SourceCore.MyBase.SaveChanges();
                AccessoryDlgLoad(false, "");
                UpdateGrid(SelectedAccessory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //delete
        private void AccessoryTextOrderLevel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        //today
        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<String> Columns = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                Columns.Add(AccessoryGrid.Columns[i].Header.ToString());
            }
            AccessoryFilterComboBox.ItemsSource = Columns;
            AccessoryFilterComboBox.SelectedIndex = 0;

            // Запрет на управление сортировкой щелчком по заголовку столбца
            foreach (DataGridColumn Column in AccessoryGrid.Columns)
            {
                Column.CanUserSort = false;
            }

        }
        private void AccessoryToBoaFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = sender as TextBox;
            switch (AccessoryFilterComboBox.SelectedIndex)
            {
                case 0:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.AccName.Contains(textbox.Text)).ToList();
                    break;
                case 1:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.DescriptionOfAccessory.Contains(textbox.Text)).ToList();
                    break;
                case 2:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.Price.Contains(textbox.Text)).ToList();
                    break;
                case 3:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.VAT.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 4:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.Inventory.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 5:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.OrderLevel.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 6:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.OrderBatch.ToString().Contains(textbox.Text)).ToList();
                    break;
                case 7:
                    AccessoryGrid.ItemsSource = SourceCore.MyBase.Accessory.Where(q => q.Partner.Name.Contains(textbox.Text)).ToList();
                    break;
            }

        }
    }
}
