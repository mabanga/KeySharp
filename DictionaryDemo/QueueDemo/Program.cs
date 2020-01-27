using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> stack = new Stack<Student>();
            Queue<Student> qStudent = new Queue<Student>();

            Student student0 = new Student();
            student0.ID = 0;
            student0.Name = "Jan0";

            Student student1 = new Student();
            student1.ID = 1;
            student1.Name = "Jan";

            Student student2 = new Student();
            student2.ID = 2;
            student2.Name = "Jan2";

            Student student3 = new Student();
            student3.ID = 3;
            student3.Name = "Jan3";

            Student student4 = new Student();
            student4.ID = 4;
            student4.Name = "Jan4";

            Student student5 = new Student();
            student5.ID = 5;
            student5.Name = "Jan5";

            qStudent.Enqueue(student1);
            qStudent.Enqueue(student2);
            qStudent.Enqueue(student3);
            qStudent.Enqueue(student4);
            qStudent.Enqueue(student5);
            foreach (Student item in qStudent)
            {
                Console.WriteLine($"Id: {item.ID} - Name: {item.Name}");
            }
            Console.WriteLine(new string('-',15));
            Console.WriteLine($"Count before Dequeue: {qStudent.Count}");
            Student st = qStudent.Dequeue();
            Console.WriteLine($"{st.ID} {st.Name}");
            Console.WriteLine(new string('-', 15));
            Console.WriteLine($"Count after Dequeue: {qStudent.Count}");
            Console.WriteLine($"{st.ID} {st.Name}");
            Console.WriteLine(new string('-', 15));
            Console.WriteLine($"Count before Peek: {qStudent.Count}");
            Student st1 = qStudent.Peek();
            Console.WriteLine($"{st1.ID} {st1.Name}");
            Console.WriteLine(new string('-', 15));
            Console.WriteLine($"Count after Peek: {qStudent.Count}");
            Console.WriteLine($"{st1.ID} {st1.Name}");
            Console.WriteLine(new string('-', 15));
            foreach (Student item in qStudent)
            {
                Console.WriteLine($"Id: {item.ID} - Name: {item.Name}");
            }
            Console.WriteLine(new string('-', 15));
            stack.Push(student0);
            stack.Push(student1);
            stack.Push(student2);
            stack.Push(student3);
            stack.Push(student4);
            stack.Push(student5);
            Console.WriteLine($"{stack.Count}");
            foreach (Student item in stack)
            {
                Console.WriteLine($"Id: {item.ID} - Name: {item.Name}");
            }
            Console.WriteLine(new string('-', 15));
            st = stack.Pop();
            Console.WriteLine($"{stack.Count}");
            foreach (Student item in stack)
            {
                Console.WriteLine($"Id: {item.ID} - Name: {item.Name}");
            }
            Console.ReadKey();
        }
    }
}
