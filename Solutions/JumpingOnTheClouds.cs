namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/jumping-on-the-clouds/

    class JumpingOnTheClouds
    {
        public static int MySolution(List<int> c)
        {

            var pos = 0;
            var steps = 0;

            for (; ; )
            {
                pos += 2;

                if (pos == c.Count - 1 || pos == c.Count)
                    break;

                if (c[pos] == 1)
                    pos--;

                steps++;
            }

            return steps + 1;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = MySolution(c);

            Console.WriteLine(result);
        }
    }
}