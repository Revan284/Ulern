using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    class Expr3_Task
    {
        // Дано время в часах и минутах. Найти угол от часовой
        // к минутной стрелке на обычных часах.
        // Например, 5 часов -> 150 градусов,
        // 20 часов -> 120 градусов. Не использовать циклы.
        internal static int GetAngle(int hour)
        {
            var twelveHourClock = hour % 12;
            var angleOneHour = 30;
            var angleFullCircle = 360;

            var desiredAngle = Math.Min(twelveHourClock * angleOneHour, Math.Abs(angleFullCircle - twelveHourClock * angleOneHour));// ваш код
            return desiredAngle;
        }
    }
}
