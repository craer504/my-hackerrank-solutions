namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/kangaroo/

    class NumberLineJumps
    {
        public static string MySolution(int x1, int v1, int x2, int v2)
        {
            return (double)(x2 - x1) / (v1 - v2) >= 0 && Math.Abs((double)(x2 - x1) / (v1 - v2) % 1) <= double.Epsilon * 100 ? "YES" : "NO";
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = MySolution(x1, v1, x2, v2);

            Console.WriteLine(result);
        }
    }
}