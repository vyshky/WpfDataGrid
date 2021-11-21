using System;
using System.Windows;

namespace WpfListBox
{
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {

            if (!Int32.TryParse(TextBoxPassword.Text, out int password)) { return; }

            User newUser = new User
            {
                FirstName = TextBoxFirstName.Text,
                Lastname = TextBoxLastName.Text,
                Password = password
            };
            MainWindow.AddToList(newUser);
        }
    }
}
