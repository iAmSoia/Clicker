using System.Windows;

namespace Кликер
{
    public partial class StartWindow : Window
    {
        readonly IButtonService buttonClick = new ButtonClick();

        public StartWindow()
        {
            InitializeComponent();
        }

        private void Start_ButtonClick(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            buttonClick.StartClick(this);
        }
        private void Login_ButtonClick(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            Login login = new Login();
            login.ShowDialog();
        }
        private void Sign_ButtonClick(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
