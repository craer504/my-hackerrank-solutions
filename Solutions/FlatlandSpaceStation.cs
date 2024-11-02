namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/flatland-space-stations/

    class FlatlandSpaceStation
    {
        class Walker
        {
            public int Station { get; set; }
            public int Distance { get; set; } = 1;
            public static List<int>? City { get; set; }
            public static int Target { get; set; }
            public static int BoundLeft { get; set; }
            public static int BoundRight { get; set; }
            public static int Steps { get; set; }

            public Walker(int start)
            {
                Station = start;
            }

            public void Walk()
            {
                if (Station + Distance < BoundRight && City[Station + Distance] == -1)
                {
                    City[Station + Distance] = Distance;
                    Steps--;
                }

                if (Station - Distance >= BoundLeft && City[Station - Distance] == -1)
                {
                    City[Station - Distance] = Distance;
                    Steps--;
                }

                Distance++;
            }
        }

        public static int MySolution(int n, int[] c)
        {
            var city = new List<int>();
            var walkers = new List<Walker>();
            Walker.City = city;
            Walker.Target = -1;
            Walker.BoundLeft = 0;
            Walker.BoundRight = n;
            Walker.Steps = 0;

            for (int i = 0; i < n; i++)
            {
                city.Add(-1);
                Walker.Steps++;
            }

            foreach (var station in c)
            {
                city[station] = 0;
                Walker.Steps--;
                walkers.Add(new Walker(station));
            }

            while (Walker.Steps > 0)
                foreach (var walker in walkers)
                    walker.Walk();


            return city.Max();
        }

        static void Test()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = MySolution(n, c);

            Console.WriteLine(result);
        }
    }
}