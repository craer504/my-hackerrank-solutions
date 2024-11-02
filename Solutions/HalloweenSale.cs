namespace MyHackerRankSolutions.Solutions
{
    //  https://www.hackerrank.com/challenges/halloween-sale/

    class HalloweenSale
    {
        public static int MySolution(int p, int d, int m, int s)
        {

            if (s < p)
                return 0;

            var games = 0;

            while (p < s && p >= m)
            {
                games++;
                s -= p;
                p -= d;
            }

            while (p < s && s >= m)
            {
                games++;
                s -= m;
            }

            return games;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int p = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            int m = Convert.ToInt32(firstMultipleInput[2]);

            int s = Convert.ToInt32(firstMultipleInput[3]);

            int answer = MySolution(p, d, m, s);

            Console.WriteLine(answer);
        }
    }
}