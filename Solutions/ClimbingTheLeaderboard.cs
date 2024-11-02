namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/climbing-the-leaderboard/

    class ClimbingTheLeaderboard
    {
        public static List<int> MySolution(List<int> ranked, List<int> player)
        {
            var leaderboard = ranked.Distinct().ToArray();
            var result = new List<int>();

            foreach (var p in player)
            {
                var pos = Array.BinarySearch(leaderboard, p, Comparer<int>.Create((x, y) => y.CompareTo(x)));

                if (pos < 0)
                    pos = ~pos;

                result.Add(pos + 1);
            }

            return result;
        }

        public static void Test()
        {
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = MySolution(ranked, player);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}