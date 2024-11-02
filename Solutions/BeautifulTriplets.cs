namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/beautiful-triplets/

    class BeautifulTriplets
    {
        public static int MySolution(int d, List<int> arr)
        {
            var result = 0;
            var sd = new Dictionary<int, int>();

            arr.ForEach(e =>
            {
                if (sd.ContainsKey(e))
                    sd[e]++;
                else
                    sd.Add(e, 0);
            });

            arr.ForEach(e =>
            {
                if (sd.ContainsKey(e + d) && sd.ContainsKey(e + d + d))
                    result++;
            });

            return result;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MySolution(d, arr);

            Console.WriteLine(result);
        }
    }
}