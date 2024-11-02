namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/migratory-birds/

    class MigratoryBirds
    {
        public static int MySolution(List<int> arr)
        {
            return arr
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .First()
                .Key;
        }

        public static void Test()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MySolution(arr);

            Console.WriteLine(result);
        }
    }
}