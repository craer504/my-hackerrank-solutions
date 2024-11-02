namespace MyHackerRankSolutions.Solutions
{
    // https://www.hackerrank.com/challenges/grading/

    static class MyExtension
    {
        public static List<T> ModifyEach<T>(this List<T> list, Action<T, int> act)
        {
            for (int i = 0; i < list.Count; i++)
            {
                act(list[i], i);
            }

            return list;
        }
    }

    class GradingStudents
    {
        public static List<int> MySolution(List<int> grades)
        {
            int difference = 0;

            return grades.ModifyEach((grade, index) =>
            {
                difference = 5 - grades[index] % 5;

                if (grades[index] <= 37) { }
                else if (difference < 3)
                    grades[index] += difference;

            });
        }

        public static void Test()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = MySolution(grades);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
