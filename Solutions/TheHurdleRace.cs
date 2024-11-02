namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/the-hurdle-race/

    class TheHurdleRace
    {
        public static int MySolution(int k, List<int> height)
        {
            var max = height.Max();
            return k >= max ? 0 : max - k;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

            int result = MySolution(k, height);

            Console.WriteLine(result);
        }
    }
}