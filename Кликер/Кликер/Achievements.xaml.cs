using System.Windows;
using System.Windows.Input;

namespace Кликер
{
    public partial class Achievements : Window
    {
        private readonly MainWindow mainWindow;

        readonly IButtonService button = new ButtonClick();

        public Achievements(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            if (OnlineCheck.InAccount)
            {
                string userName = PlayerData.GetUserNameWhenLogin();
                DataContext = PlayerData.GetCurrentUserData(userName);
            }
        }
        private void ClickAchievements_Menu(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            button.MainClickMenu(this);
        }
        private void Button_Click_Backward(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            mainWindow.Show();
            this.Close();
        }
        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            Sounds.Aсhievements4Sounds();
        }
        private void StackPanel_MouseEnter_3(object sender, MouseEventArgs e)
        {
            Sounds.Aсhievements3Sounds();
        }
        private void StackPanel_MouseEnter4(object sender, MouseEventArgs e)
        {
            Sounds.Aсhievements1Sounds();
        }
        private void StackPanel_MouseEnter_2(object sender, MouseEventArgs e)
        {
            Sounds.Aсhievements2Sounds();
        }
    }
}
