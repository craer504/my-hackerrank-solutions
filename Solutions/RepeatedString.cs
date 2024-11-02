namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/repeated-string/ 

    class RepeatedStrings
    {
        public static long MySolution(string s, long n)
        {
            var result = 0L;

            var remainder = n % s.Length;
            var quotient = n / s.Length;

            if (quotient > 0)
            {
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a')
                        result++;
                }

                result *= quotient == 0 ? 1 : quotient;
            }

            for (var i = 0; i < remainder; i++)
            {
                if (s[i] == 'a')
                    result++;
            }

            return result;
        }

        public static void Test()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = MySolution(s, n);

            Console.WriteLine(result);
        }
    }
}