﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кликер
{
    internal static class OnlineCheck
    {
        static private bool inAccount = false;
        static public bool InAccount { get { return inAccount; } } //произведён ли вход пользователем

        static public void SwitchOnline()
        {
            inAccount = true;
        }
    }
}
