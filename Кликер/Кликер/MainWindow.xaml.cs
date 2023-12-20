using System.Windows;
using System.Windows.Controls;

namespace Кликер
{
    public partial class MainWindow : Window
    {
        readonly IButtonService buttonClick = new ButtonClick();

        public MainWindow()
        {
            InitializeComponent();
            CheckIsAccount();
        }
        private void CheckIsAccount()
        {
            if (OnlineCheck.InAccount) { online.Visibility = Visibility.Visible; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buttonClick.MainButtonClick(HistoryPoint, InfoClick, MaxPoint);
            Sounds.MainButtonSounds();
        }
        private void Button_Click_Menu(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            buttonClick.MainClickMenu(this);
        }
        private void Button_Click_Achievements(object sender, RoutedEventArgs e)
        {
            Sounds.AllSounds();
            buttonClick.MainAchievementsClick(this);
        }
    }
}
