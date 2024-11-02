namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/drawing-book/

    class DrawingBook
    {
        public static int MySolution(int n, int p)
        {
            return p / 2 < n / 2 - p / 2 ? p / 2 : n / 2 - p / 2;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = MySolution(n, p);

            Console.WriteLine(result);
        }
    }
}