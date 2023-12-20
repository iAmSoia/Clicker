using System.Windows;

namespace Кликер
{
    public partial class StartWindow : Window
    {
        readonly IButtonService buttonClick = new ButtonClick();
        readonly ISounds sounds = new Sounds();

        public StartWindow()
        {
            InitializeComponent();
        }

        private void Start_ButtonClick(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            buttonClick.StartClick(this);
        }
        private void Login_ButtonClick(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            Login login = new Login();
            login.ShowDialog();
        }
        private void Sign_ButtonClick(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
