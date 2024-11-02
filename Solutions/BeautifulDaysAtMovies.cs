namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/

    class BeautifulDaysAtMovies
    {
        public static int MySolution(int i, int j, int k)
        {
            var digits = new List<int>();
            var result = 0;

            foreach (var day in Enumerable.Range(i, j - i + 1))
            {
                var temp = day;

                while (temp != 0)
                {
                    digits.Add(temp % 10);
                    temp /= 10;
                }

                var reverse = 0;

                for (int l = 0; l < digits.Count; l++)
                {
                    reverse += (int)(digits[l] * Math.Pow(10, digits.Count - l - 1));
                }

                if ((day - reverse) % k == 0)
                    result++;

                digits.Clear();
            }

            return result;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int i = Convert.ToInt32(firstMultipleInput[0]);

            int j = Convert.ToInt32(firstMultipleInput[1]);

            int k = Convert.ToInt32(firstMultipleInput[2]);

            int result = MySolution(i, j, k);

            Console.WriteLine(result);
        }
    }
}