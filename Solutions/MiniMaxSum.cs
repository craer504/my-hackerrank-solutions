namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/mini-max-sum/

    class MiniMaxSUm
    {
        public static void MySolution(List<int> arr)
        {
            var result = arr
                .OrderBy(x => x)
                .Aggregate((min: 0L, max: 0L, count: 0),
                (acc, i) =>
                {
                    if (acc.count == 0)
                    {
                        acc.min += i;
                        acc.count++;
                    }
                    else if (acc.count == 4)
                    {
                        acc.max += i;
                    }
                    else
                    {
                        acc.min += i;
                        acc.max += i;
                        acc.count++;
                    }

                    return acc;
                });

            Console.WriteLine(result.min + " " + result.max);
        }

        public static void Test()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            MySolution(arr);
        }
    }
}