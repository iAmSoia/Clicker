
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;


namespace Кликер
{
    interface IPoint
    {
        int TotalPoints { get; }
        void AddPoint();
        void ResetPoint();
        void AddPointHistory(int point, TextBox HistoryPoint, TextBox MaxPoint);
    }

    internal class Points : IPoint
    {
        int totalPoints = 0;
        static int maxPoints = 0;
        readonly List<int> pointHistory = new List<int>();

        public int TotalPoints { get { return totalPoints; } }
        public void AddPoint()
        {
            totalPoints++;
        }
        public void ResetPoint()
        {
            totalPoints = 0;
        }
        public void AddPointHistory(int point, TextBox HistoryPoint, TextBox MaxPoint)
        {
            if (point != 0)
            {
                pointHistory.Add(point);
                PointDisplayOnTextBlock(point, HistoryPoint);
                MaxOnHistoryPoint(MaxPoint);
                CheckMaxPoint();
            }
        }
        void PointDisplayOnTextBlock(int point, TextBox HistoryPoint)
        {
            HistoryPoint.Text += point.ToString() + Environment.NewLine;
        }
        void MaxOnHistoryPoint(TextBox MaxPoint)
        {
            maxPoints = pointHistory.Max();
            MaxPoint.Text = maxPoints.ToString();
        }

        //меняет значения булевых переменных, связанных с (не)доступностью достижений
        void CheckMaxPoint() //номера 2.3.4 - это порядковый номер панели достижения
        {                           // 100.200.300 - это очки, необходимые для открытия достижений 2.3.4
            string name = PlayerData.GetUserNameWhenLogin();
            if (OnlineCheck.InAccount)
            {
                int switchValue = 0;
                if (maxPoints >= 100 && maxPoints < 200)
                {
                    switchValue = 2;
                }
                else if (maxPoints >= 200 && maxPoints < 300)
                {
                    switchValue = 3;
                }
                else if (maxPoints >= 300)
                {
                    switchValue = 4;
                }
                if (switchValue != 0) { PlayerData.SwitchBoolProperty(name, switchValue); }
            }
        }
    }
}
