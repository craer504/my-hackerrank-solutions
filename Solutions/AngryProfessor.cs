namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/angry-professor/

    class AngryProfessor
    {
        public static string MySolution(int k, List<int> a)
        {
            return a.Count(s => s <= 0) >= k ? "NO" : "YES";
        }

        public static void Test()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = MySolution(k, a);

                Console.WriteLine(result);
            }
        }
    }
}