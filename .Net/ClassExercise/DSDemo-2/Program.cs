namespace DSDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            
            Console.WriteLine("\nList demo");
            Console.WriteLine("Student Details are as follows:");
            foreach (Student s in students)
            {
                Console.WriteLine(s.id + "\t" + s.name + "\t" + s.marks);
            }

            // Access a specific object by index
            Console.WriteLine($"Second student is: {students[1].name}");

            //Dictionay Example
            Console.WriteLine("\nDictionary demo");
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);

            Console.WriteLine("Student Details are as follows:");
            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.id + "\t" + student.Value.name+ "\t" + student.Value.marks);
            }


            //Hashset Example
            Console.WriteLine("\nHashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            Console.WriteLine("Student Details are as follows:");
            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id + "\t" + student.name + "\t" + student.marks);
            }


            //StackDemo

            Console.WriteLine("\nStack demo");
            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Console.WriteLine("Student Details are as follows:");
            while (students_stack.Count > 0)
            {
                Student pop_stack = students_stack.Pop();
                Console.WriteLine(pop_stack.id + "\t" + pop_stack.name + "\t" + pop_stack.marks);
            }
            


            //Queue demo
            Console.WriteLine("\nQueue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine("Student Details are as follows:");
            while (students_queue.Count > 0)
            {
                Student dequeue_student = students_queue.Dequeue();
                Console.WriteLine(dequeue_student.id + "\t" + dequeue_student.name + "\t" + dequeue_student.marks);
            }

            //LinkedList demo
            LinkedList<Student> students_linkedlist = new LinkedList<Student>();
            students_linkedlist.AddLast(first);
            students_linkedlist.AddLast(second);
            students_linkedlist.AddLast(third);
            Console.WriteLine("\nLinkedList demo");
            Console.WriteLine("Student Details are as follows:");
            foreach (Student student in students_linkedlist)
            {
                Console.WriteLine(student.id + "\t" + student.name + "\t" + student.marks);
            }

            //Tuple demo
            Tuple<int, string, int> student_tuple = new Tuple<int, string, int>(1, "Alice", 10);
            Tuple<int, string, int> student_tuple2 = new Tuple<int, string, int>(2, "Bob", 90);
            Tuple<int, string, int> student_tuple3 = new Tuple<int, string, int>(3, "Charlie", 78);
            List<Tuple<int, string, int>> students_tuple_list = new List<Tuple<int, string, int>>();
            students_tuple_list.Add(student_tuple);
            students_tuple_list.Add(student_tuple2);
            students_tuple_list.Add(student_tuple3);
            Console.WriteLine("\nTuple demo");
            Console.WriteLine("Student Details are as follows:");
            foreach (Tuple<int, string, int> student in students_tuple_list)
            {
                Console.WriteLine(student.Item1 + "\t" + student.Item2 + "\t" + student.Item3);
            }



        }
    }
}
