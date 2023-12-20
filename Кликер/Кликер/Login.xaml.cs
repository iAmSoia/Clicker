using System.Windows;
using System.Windows.Controls;

namespace Кликер
{
    public partial class Login : Window
    {
        readonly ISounds sound = new Sounds();
        readonly IButtonService button = new ButtonClick();
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            sound.AllSounds();
            button.LoginClick(UsernameTextBox, PasswordBox, this);
        }
    }
}
