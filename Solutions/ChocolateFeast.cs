namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/chocolate-feast/

    class ChocolateFeast
    {
        public static int MySolution(int n, int c, int m)
        {
            var eaten = 0;
            var wrapper = n / c;

            eaten += wrapper;

            while (wrapper >= m)
            {
                var leftover = wrapper % m;

                wrapper = (wrapper - leftover) / m;
                eaten += wrapper;

                wrapper += leftover;
            }

            return eaten;
        }

        public static void Test()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int c = Convert.ToInt32(firstMultipleInput[1]);

                int m = Convert.ToInt32(firstMultipleInput[2]);

                int result = MySolution(n, c, m);

                Console.WriteLine(result);
            }
        }
    }
}