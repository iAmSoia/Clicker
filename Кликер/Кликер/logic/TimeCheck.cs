using System;

namespace Кликер
{
    internal class TimeCheck
    {
        DateTime lastTime = DateTime.MaxValue; //по дефолту - значение, которое не может быть достигнуто
        TimeSpan distinctionOnClick = TimeSpan.Zero; //"расстояние" во времени между нажатиями
        TimeSpan maxDistinction = TimeSpan.FromSeconds(1);
        //проверка на задержку между нажатиями
        //если значение True, то значение очков необходимо обнулить
        public bool CheckedTimeClick()
        {
            if (lastTime != DateTime.MaxValue)
            {
                distinctionOnClick = DateTime.Now - lastTime;
                if (CheckDistinction())
                {
                    lastTime = DateTime.Now;
                    return true;
                }
                lastTime = DateTime.Now;
            }
            else { lastTime = DateTime.Now; }
            return false;
        }
        bool CheckDistinction()
        {
            if (distinctionOnClick > maxDistinction) { return true; }
            else return false;
        }
    }
}
