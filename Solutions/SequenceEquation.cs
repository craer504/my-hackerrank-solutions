namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/permutation-equation/

    class SequenceEquation
    {
        public static List<int> MySolution(List<int> p)
        {
            var result = new List<int>();

            for (int i = 1; i <= p.Count; i++)
            {
                result.Add(p.IndexOf(p.IndexOf(i) + 1) + 1);
            }

            return result;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

            List<int> result = MySolution(p);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}