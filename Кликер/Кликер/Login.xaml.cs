using System.Windows;
using System.Windows.Controls;

namespace Кликер
{
    public partial class Login : Window
    {
        readonly IButtonService button = new ButtonClick();
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            button.LoginClick(UsernameTextBox, PasswordBox, this);
        }
    }
}
