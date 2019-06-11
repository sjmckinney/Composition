using System;

namespace Composition
{
    public class CalcDob
    {
        public static string GetAdultDob()
        {
            DateTime min = DateTime.Now.AddYears(-19);
            DateTime max = DateTime.Now.AddYears(-65);

            return GetRandomDateTime(min, max).ToString("yyyy-MM-ddTHH:mm:ss");
        }

        public static string GetDobFor11MonthsToday()
        {
            int yearsToAdust = 0;
            int monthsToAdjust = 11;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor8Today()
        {
            int yearsToAdust = 8;
            int monthsToAdjust = 0;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor15y11mToday()
        {
            int yearsToAdust = 15;
            int monthsToAdjust = 11;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor16Today()
        {
            int yearsToAdust = 16;
            int monthsToAdjust = 0;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor17Today()
        {
            int yearsToAdust = 17;
            int monthsToAdjust = 0;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);

        }

        public static string GetDobFor17y11mToday()
        {
            int yearsToAdust = 17;
            int monthsToAdjust = 11;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor18Tommorrow()
        {
            int yearsToAdust = 18;
            int monthsToAdjust = 0;
            int daysToAdjust = -1;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor18Today()
        {
            int yearsToAdust = 18;
            int monthsToAdjust = 0;
            int daysToAdjust = 0;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor18y1dToday()
        {
            int yearsToAdust = 18;
            int monthsToAdjust = 0;
            int daysToAdjust = 1;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        public static string GetDobFor18y1mToday()
        {
            int yearsToAdust = 18;
            int monthsToAdjust = 1;
            int daysToAdjust = 1;

            return GetAdjustedDob(yearsToAdust, monthsToAdjust, daysToAdjust);
        }

        private static string GetAdjustedDob(int yearsToAdjust = 0, int monthsToAdjust = 0, int daysToAdjust = 0)
        {
            DateTime today = DateTime.Now;
            return today.AddYears(-yearsToAdjust)
                        .AddMonths(-monthsToAdjust)
                        .AddDays(-daysToAdjust)
                        .ToString("yyyy-MM-ddTHH:mm:ss");
        }

        private static DateTime GetRandomDateTime(DateTime min, DateTime max)
        {
            var range = max - min;
            var rnd = new Random();
            var randomUpperBound = (Int32)range.TotalSeconds;

            if (randomUpperBound <= 0)
                randomUpperBound = rnd.Next(1, Int32.MaxValue);

            var randTimeSpan = TimeSpan.FromSeconds((Int64)(range.TotalSeconds - rnd.Next(0, randomUpperBound)));
            return min.Add(randTimeSpan);
        }
    }

}
