
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
        public int MaxPoints { get { return maxPoints; } }
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
            int max = pointHistory.Max();
            MaxPoint.Text = max.ToString();
        }
        void CheckMaxPoint()
        {
            string name = PlayerData.GetUserNameWhenLogin();
            if (maxPoints >= 100 && maxPoints < 200 && DesignAccount.InAccount)
            {
                PlayerData.SwitchBoolProperty(name, 2);
            }
            else if (maxPoints >= 200 && maxPoints < 300 && DesignAccount.InAccount)
            {
                PlayerData.SwitchBoolProperty(name, 3);
            }
            else if (maxPoints >= 300 && DesignAccount.InAccount)
            {
                PlayerData.SwitchBoolProperty(name, 4);
            }
        }
    }
}
