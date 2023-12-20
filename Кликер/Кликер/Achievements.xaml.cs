using System.Windows;
using System.Windows.Input;

namespace Кликер
{
    public partial class Achievements : Window
    {
        private readonly MainWindow mainWindow;

        readonly ISounds sounds = new Sounds();
        readonly IButtonService button = new ButtonClick();

        //private PlayerData playerData;
        public Achievements(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            bool check = DesignAccount.InAccount;
            if (check)
            {
                string userName = PlayerData.GetUserNameWhenLogin();
                DataContext = PlayerData.GetCurrentUserData(userName);
            }
        }
        private void ClickAchievements_Menu(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            button.MainClickMenu(this);
        }
        private void Button_Click_Backward(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            mainWindow.Show();
            this.Close();
        }
        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            sounds.Aсhievements4Sounds();
        }
        private void StackPanel_MouseEnter_3(object sender, MouseEventArgs e)
        {
            sounds.Aсhievements3Sounds();
        }
        private void StackPanel_MouseEnter4(object sender, MouseEventArgs e)
        {
            sounds.Aсhievements1Sounds();
        }
        private void StackPanel_MouseEnter_2(object sender, MouseEventArgs e)
        {
            sounds.Aсhievements2Sounds();
        }
    }
}
