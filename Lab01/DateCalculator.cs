using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    static class DateCalculator
    {
        private static readonly string[] westernZodiacs = {"The Sea-goat", "The Water Bearer", "The Fish", "The Ram", "The Bull", "The Twins", 
            "The Crab", "The Lion", "The Virgin", "The Scales", "The Scorpion", "The Archer"};
        private static readonly string[] chineseZodiacs = {"Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
            "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"};

        public static int GetAge(DateTime date)
        {
            int result = DateTime.Now.Year - date.Year;
            if(DateTime.Now.Month < date.Month)
            {
                result--;
            }
            else if(DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)
            {
                result--;
            }
            return result;
        }

        public static bool IsDateCorrect(DateTime date)
        {
            int age = GetAge(date);
            return age >= 0 && age <= 135;
        }

        public static bool IsBirthday(DateTime date)
        {
            return DateTime.Now.Month == date.Month && DateTime.Now.Day == date.Day;
        }

        public static string GetChineseZodiac(DateTime date)
        {
            return chineseZodiacs[CalculateChineseZodiac(date)];
        }

        public static string GetWesternZodiac(DateTime date)
        {
            return westernZodiacs[CalculateWesternZodiac(date)];
        }

        private static int CalculateChineseZodiac(DateTime date)
        {
            return date.Year % 12;
        }

        private static int CalculateWesternZodiac(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                    return date.Day <= 20 ? 0 : 1;
                case 2:
                    return date.Day <= 19 ? 1 : 2;
                case 3:
                    return date.Day <= 20 ? 2 : 3;
                case 4:
                    return date.Day <= 20 ? 3 : 4;
                case 5:
                    return date.Day <= 20 ? 4 : 5;
                case 6:
                    return date.Day <= 21 ? 5 : 6;
                case 7:
                    return date.Day <= 22 ? 6 : 7;
                case 8:
                    return date.Day <= 22 ? 7 : 8;
                case 9:
                    return date.Day <= 22 ? 8 : 9;
                case 10:
                    return date.Day <= 22 ? 9 : 10;
                case 11:
                    return date.Day <= 22 ? 10 : 11;
                case 12:
                    return date.Day <= 21 ? 11 : 0;
                default:
                    return 1;
            }
        }

    }
}
