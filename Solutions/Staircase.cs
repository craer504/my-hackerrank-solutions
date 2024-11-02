namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/staircase/

    class Staircase
    {
        public static void MySolution(int n)
        {

            for (int i = 0; i < n; i++)
                Console.WriteLine(new string(' ', n - i - 1) + new string('#', i + 1));
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            MySolution(n);
        }
    }
}