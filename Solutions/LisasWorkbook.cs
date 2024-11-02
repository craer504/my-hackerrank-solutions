namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/lisa-workbook/

    class LisasWorkbook
    {
        public static int MySolution(int n, int k, List<int> arr)
        {
            var result = 0;
            var page = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                var problems = arr[i];
                var enumerated = 0;

                for (int j = 0; j < problems / k; j++)
                {
                    var temp = enumerated;
                    enumerated += k;
                    page++;

                    if (temp < page && page <= enumerated)
                        result++;

                }

                if (problems % k > 0)
                {
                    var temp = enumerated;
                    enumerated += problems % k;

                    page++;

                    if (temp < page && page <= enumerated)
                        result++;
                }
            }

            return result;
        }

        public static void Test()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MySolution(n, k, arr);

            Console.WriteLine(result);
        }
    }
}