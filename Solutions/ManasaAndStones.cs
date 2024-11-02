namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/manasa-and-stones/

    class ManasaAndStones
    {
        public static List<int> MySolution(int n, int a, int b)
        {
            var stone = new SortedSet<int>();

            for (int i = 0; i < n; i++)
            {
                var current = 0;

                current += a * (n - 1 - i) + b * i;

                if (current > 0)
                    stone.Add(current);
            }

            return stone.ToList();
        }

        public static void Test()
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int a = Convert.ToInt32(Console.ReadLine().Trim());

                int b = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> result = MySolution(n, a, b);

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}