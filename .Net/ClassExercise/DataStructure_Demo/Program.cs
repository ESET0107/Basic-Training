namespace DataStructure_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(101, "Anthony Stark", 45);
            student s2 = new student(102, "Steve Rogers", 100);
            student s3 = new student(103, "Bruce Banner", 40);
            student s4 = new student(104, "Bruce Wayne", 45);
            student s5 = new student(105, "Diana Prince", 5000);
            student s6 = new student(106, "Barry Allen", 30);

            List<student> students_list = new List<student>();
            students_list.AddRange(new[] { s1, s2, s3, s4, s5, s6 });
            Console.WriteLine("Student Details are as follows:");
            Console.WriteLine("ID\tName\t\tAge"); Console.WriteLine("-----------------------------------");
            foreach (student s in students_list)
            {
                s.display();
            }
            //List of Dictionaries
            List<Dictionary<int, string>> students_dict_list = new List<Dictionary<int, string>>();
            Dictionary<int, string> student_dict1 = new Dictionary<int, string>
            {
                { 101, "Anthony Stark" },
                { 102, "Steve Rogers" },
                { 103, "Bruce Banner" },
                { 104, "Natasha Romanoff" },
                { 105, "Clint Barton" },
                { 106, "Thor Odinson" }
            };

            Dictionary<int, string> student_dict2 = new Dictionary<int, string>
            {

                { 201, "Bruce Wayne" },
                { 202, "Diana Prince" },
                { 203, "Barry Allen" },
                { 204, "Clark Kent" },
                { 205, "Arthur Curry" },
                { 206, "Hal Jordan"  }
            };
            students_dict_list.AddRange(new[] { student_dict1, student_dict2 });
            Console.WriteLine("\nStudent Details from Dictionary List are as follows:");
            Console.WriteLine("ID\tName"); Console.WriteLine("-----------------------");
            foreach (Dictionary<int, string> dict in students_dict_list)
            {
                foreach (KeyValuePair<int, string> kvp in dict)
                {
                    Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
                }
            }
        }
    }
}
