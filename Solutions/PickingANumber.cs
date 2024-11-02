namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/picking-numbers/

    class PickingANumber
    {
        public static int MySolution(List<int> a)
        {
            var numberOccurences = new Dictionary<int, int>();
            var maxSubArrayLength = 0;

            foreach (int i in a)
            {
                if (numberOccurences.ContainsKey(i))
                    numberOccurences[i]++;
                else numberOccurences[i] = 1;
            }

            var sortedNumberOccurences = numberOccurences.OrderBy(pair => pair.Key);

            foreach (var elem in sortedNumberOccurences)
            {
                maxSubArrayLength =
                    numberOccurences.ContainsKey(elem.Key + 1) ?
                    Math.Max(maxSubArrayLength, numberOccurences[elem.Key] + numberOccurences[elem.Key + 1])
                    : Math.Max(maxSubArrayLength, numberOccurences[elem.Key]);

            }

            return maxSubArrayLength;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = MySolution(a);

            Console.WriteLine(result);
        }
    }
}