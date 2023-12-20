using System.Windows;

namespace Кликер
{
    public partial class SignUp : Window
    {
        readonly IButtonService buttonClick=new ButtonClick();
        readonly ISounds sounds = new Sounds();

        public SignUp()
        {
            InitializeComponent();
        }
        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            buttonClick.SignSaveClick(UsernameTextBox, PasswordBox, this);

        }
    }
}
