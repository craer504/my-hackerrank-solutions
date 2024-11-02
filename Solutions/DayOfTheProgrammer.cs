namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/day-of-the-programmer/

    class DayOfTheProgrammer
    {
        public static string MySolution(int year)
        {
            int day = 13;
            int month = 9;

            if (year == 1918)
            {
                day = 26;
                month = 9;
            }
            else if (year >= 1700 && year <= 1917 && year % 4 == 0 || year >= 1919 && year <= 2700 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0))
            {
                day -= 1;
            }

            return new DateTime(year, month, day).ToString("dd.MM.yyyy");
        }

        public static void Test()
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = MySolution(year);

            Console.WriteLine(result);
        }
    }
}