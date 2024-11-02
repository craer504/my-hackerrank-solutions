namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/

    class JumpingOnTheCloudsRevisited
    {
        public static int MySolution(int[] c, int k)
        {
            var e = 100;
            var pos = 0;

            do
            {
                pos = (pos + k) % c.Length;

                _ = c[pos] == 1 ? e -= 3 : e--;

            } while (pos > 0);

            return e;
        }

        public static void Test()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = MySolution(c, k);

            Console.WriteLine(result);
        }
    }
}