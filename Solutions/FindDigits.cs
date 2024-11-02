namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/find-digits/

    class FindDigits
    {
        public static int MySolution(int n)
        {

            var temp = n;
            var result = 0;

            while (temp > 0)
            {
                var digit = temp % 10;
                temp /= 10;

                if (digit == 0)
                    continue;

                if (n % digit == 0)
                    result++;
            }

            return result;
        }

        public static void Test()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = MySolution(n);

                Console.WriteLine(result);
            }
        }
    }
}