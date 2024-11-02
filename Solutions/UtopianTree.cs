namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/utopian-tree/  

    class UtopianTree
    {
        public static int MySolution(int n)
        {
            return n == 0 ? 1 : n % 2 == 0 ? MySolution(n - 1) + 1 : MySolution(n - 1) * 2;
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