namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/save-the-prisoner/

    class Result
    {

        public static int MySolution(int n, int m, int s)
        {
            int result = (s + m - 1) % n;
            return result == 0 ? n : result;
        }

        public static void Test()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int s = Convert.ToInt32(firstMultipleInput[2]);

                int result = MySolution(n, m, s);

                Console.WriteLine(result);
            }
        }
    }
}