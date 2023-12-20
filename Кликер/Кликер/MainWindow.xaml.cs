using System.Windows;
using System.Windows.Controls;

namespace Кликер
{
    public partial class MainWindow : Window
    {
        readonly IButtonService buttonClick = new ButtonClick();
        readonly Sounds sounds = new Sounds();
        
        public MainWindow()
        {
            InitializeComponent();
            CheckIsAccount();
        }
        private void CheckIsAccount()
        {
            if(DesignAccount.InAccount) { online.Visibility = Visibility.Visible; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buttonClick.MainButtonClick(HistoryPoint, InfoClick, MaxPoint);
            sounds.MainButtonSounds();
        }
        private void Button_Click_Menu(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            buttonClick.MainClickMenu(this);
        }
        private void Button_Click_Achievements(object sender, RoutedEventArgs e)
        {
            sounds.AllSounds();
            buttonClick.MainAchievementsClick(this);
        }
    }
}
/*
     музыку фон и звуки 
     таймер и историю баллов
     мб окно регистрации через json - в истории тогда инфа кто скок очков получил
     мб вознаграждения - окно с картинками и описанием наград
     мб режимы - на время, без ограничений

     настроить перемещения по клавишам - esc - пробел/enter/левая кнопка мыши


         окна, время, очки, звуки, графика, DB


        сделать невидимым аватар при отсутствии входа в аккаунт, а имя кнопки изменить на выход
        история очков до обнуления 

        общее количество кликов - покупка новых обоев)

     */
