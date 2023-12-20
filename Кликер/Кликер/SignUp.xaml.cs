using System.Windows;

namespace Кликер
{
    public partial class SignUp : Window
    {
        readonly IButtonService buttonClick = new ButtonClick();

        public SignUp()
        {
            InitializeComponent();
        }
        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            buttonClick.SignSaveClick(UsernameTextBox, PasswordBox, this);
        }
    }
}
