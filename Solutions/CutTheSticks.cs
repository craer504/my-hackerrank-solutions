namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/cut-the-sticks/

    class CutTheSticks
    {
        public static List<int> MySolution(List<int> arr)
        {
            var result = new List<int>();

            while (arr.Count > 0)
            {
                var currentMin = arr.Min();
                var counter = 0;

                for (var i = 0; i < arr.Count; i++)
                {
                    if (arr[i] == 0)
                        continue;

                    arr[i] -= currentMin;
                    counter++;
                }

                result.Add(counter);
                arr.RemoveAll(x => x == 0);
            }

            return result;
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = MySolution(arr);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}