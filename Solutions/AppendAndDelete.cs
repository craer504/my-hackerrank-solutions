namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/append-and-delete/

    class AppendAndDelete
    {
        public static string MySolution(string s, string t, int k)
        {
            var commons = 0;
            var count = s.Length < t.Length ? s.Length : t.Length;

            for (int i = 0; i < count; i++)
            {
                if (s[i] != t[i])
                    break;
                else
                    commons++;
            }

            var operations = s.Length - commons + (t.Length - commons);

            return k >= s.Length + t.Length || k >= operations && (k - operations) % 2 == 0 ? "Yes" : "No";
        }

        public static void Test()
        {

            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = MySolution(s, t, k);

            Console.WriteLine(result);

        }
    }
}