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
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Login().Show();
            Close();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = Password1Box.Password;
            var password2 = Password2Box.Password;
            var email = EmailTextBox.Text;

            if (!Validator.IsValidName(username))
            {
                MessageBox.Show("Ошибка валидации имени!");
                return;
            }

            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Ошибка валидации e-mail!");
                return;
            }

            if (!Validator.IsValidPassword(password))
            {
                MessageBox.Show("Ошибка валидации пароля!");
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            Hide();
            new MainEmpty().Show();
            Close();
        }
    }
}
