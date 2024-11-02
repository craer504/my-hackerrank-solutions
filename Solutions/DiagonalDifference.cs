namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/diagonal-difference/

    class DiagonalDifference
    {
        public static int MySolution(List<List<int>> arr)
        {
            int leftSlanted = 0, rightSlanted = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                leftSlanted += arr[i][i];
                rightSlanted += arr[arr.Count - i - 1][i];
            }

            return Math.Abs(leftSlanted - rightSlanted);
        }

        public static void Test()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = MySolution(arr);

            Console.WriteLine(result);
        }
    }
}