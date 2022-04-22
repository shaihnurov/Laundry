using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry
{
    internal class Calculator
    {
        public List<string> Calculations { get; set; } = new List<string>()
        {
            "футболка", "носки", "нижнее белье", "штаны", "пальто", "шорты", "толстовка", "полотенце", "постельное белье", "юбка", "шапка", "колготки"
        };

        internal double Calc(double valueUnder, string inUnderwear)
        {

            if (inUnderwear == "футболка")
                return valueUnder * (double)130;

            if (inUnderwear == "носки")
                return valueUnder * (double)55;

            if (inUnderwear == "нижнее белье")
                return valueUnder * (double)80;

            if (inUnderwear == "штаны")
                return valueUnder * (double)290;

            if (inUnderwear == "пальто")
                return valueUnder * (double)780;

            if (inUnderwear == "шорты")
                return valueUnder * (double)180;

            if (inUnderwear == "толстовка")
                return valueUnder * (double)220;

            if (inUnderwear == "полотенце")
                return valueUnder * (double)70;

            if (inUnderwear == "постельное белье")
                return valueUnder * (double)1100;

            if (inUnderwear == "юбка")
                return valueUnder * (double)110;

            if (inUnderwear == "шапка")
                return valueUnder * (double)35;

            if (inUnderwear == "колготки")
                return valueUnder * (double)44;

            return 0;

        }
    }
}