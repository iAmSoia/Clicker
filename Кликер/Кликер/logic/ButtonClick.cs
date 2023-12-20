using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Кликер
{
    public interface IButtonService
    {
        void MainButtonClick(TextBox historyPoint, Label infoClick, TextBox maxPoint);
        void MainClickMenu(Window mainWindow);
        void StartClick(Window startWindow);
        void SignSaveClick(TextBox usernameTextBox, PasswordBox password, Window window);
        void LoginClick(TextBox usernameTextBox, PasswordBox password, Window window);
        void MainAchievementsClick(MainWindow window);
    }

    public class ButtonClick : IButtonService
    {
        readonly IPoint point = new Points();
        readonly TimeCheck timeCheck = new TimeCheck();

        public void MainButtonClick(TextBox HistoryPoint, Label InfoClick, TextBox MaxPoint)
        {
            if (timeCheck.CheckedTimeClick())
            {
                point.AddPointHistory(point.TotalPoints, HistoryPoint, MaxPoint);
                point.ResetPoint();
                InfoClick.Foreground = Brushes.Red;
            }
            else
            {
                InfoClick.Foreground = Brushes.Black;
                point.AddPoint();
            }
            InfoClick.Content = "CLICKS - " + point.TotalPoints;
        }
        public void MainClickMenu(Window mainWindow)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            mainWindow.Hide();
            mainWindow.Close();
        }
        public void StartClick(Window startWindow)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            startWindow.Hide();
            startWindow.Close();
        }
        public void SignSaveClick(TextBox usernameTextBox, PasswordBox password, Window window)
        {
            PlayerData player = new PlayerData();
            if (player.RegisterUser(usernameTextBox.Text, password.Password))
            {
                MessageBox.Show("Регистрация прошла успешно!");
                window.Close();
            }
            else MessageBox.Show("Возникла ошибка :(");
        }
        public void LoginClick(TextBox usernameTextBox, PasswordBox password, Window window)
        {
            PlayerData player = new PlayerData();
            if (player.AuthenticateUser(usernameTextBox.Text, password.Password))
            {
                window.Close();
                MessageBox.Show("Добро пожаловать!");
                OnlineCheck.SwitchOnline();
                player.SaveUserNameWhenLogin(usernameTextBox.Text);
            }
            else MessageBox.Show("Возникла ошибка :(");
        }
        public void MainAchievementsClick(MainWindow window)
        {
            Achievements achievements = new Achievements(window);
            achievements.Show();
            window.Hide();
        }
    }
}
