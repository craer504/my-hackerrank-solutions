namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/time-conversion/

    class TimeConversion
    {
        public static string MySolution(string s)
        {
            int hour = int.Parse(s.Substring(0, 2));

            if (hour == 12) hour = 0;
            if (s.Contains("PM")) hour += 12;

            return $"{hour:D2}{s.Substring(2, 6)}";
        }

        public static void Test()
        {
            string s = Console.ReadLine();

            string result = MySolution(s);

            Console.WriteLine(result);
        }
    }
}