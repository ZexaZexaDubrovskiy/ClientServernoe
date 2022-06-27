using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private Base.Entities1 Database;

        public RegistrationWindow(Base.Entities1 DataBase)
        {
            InitializeComponent();
            this.Database = DataBase;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Base.Users User = new Base.Users();
            User.Login = LoginTextBox.Text;
            PasswordTextBox.Text = PasswordPasswordBox.Password;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            var isValidated = hasNumber.IsMatch(PasswordTextBox.Text) && hasUpperChar.IsMatch(PasswordTextBox.Text) && hasMinimum8Chars.IsMatch(PasswordTextBox.Text);

            if (isValidated)
            {
                User.Password = PasswordPasswordBox.Password != "" ? PasswordPasswordBox.Password : PasswordTextBox.Text;
                Database.Users.Add(User);
                Database.SaveChanges();
                Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Пароль должен содержать заглавные буквы, цифры и быть не менее 8 символов!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private static bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            String Password = PasswordPasswordBox.Password;
            Visibility Visibility = PasswordPasswordBox.Visibility;
            double Width = PasswordPasswordBox.ActualWidth;
            PasswordButton.Content = Visibility == Visibility.Visible ? "Скрыть" : "Показать";
            PasswordPasswordBox.Password = PasswordTextBox.Text;
            PasswordPasswordBox.Visibility = PasswordTextBox.Visibility;
            PasswordPasswordBox.Width = PasswordTextBox.Width;
            PasswordTextBox.Text = Password;
            PasswordTextBox.Visibility = Visibility;
            PasswordTextBox.Width = Width;

        }
    }
}
