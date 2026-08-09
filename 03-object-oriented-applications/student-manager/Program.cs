using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager stuManager = new StudentManager();
            string filePath = "students.txt";
            bool functioning = true;

            while (functioning)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Save list to file");
                Console.WriteLine("3. Clear current list");
                Console.WriteLine("4. Load students from file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case  1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        double test1 = 0;
                        double test2 = 0;
                        double test3= 0;
                        while (true)
                        {
                            Console.Write("Enter Test 1 score: ");
                            if (double.TryParse(Console.ReadLine(), out test1))
                                break;
                            Console.WriteLine("Invalid number. Try again.");

                            Console.Write("Enter Test 2 score: ");
                            if (double.TryParse(Console.ReadLine(), out test2))
                                break;
                            Console.WriteLine("Invalid number. Try again.");

                            Console.Write("Enter Test 3 score: ");
                            if (double.TryParse(Console.ReadLine(), out test3))
                                break;
                            Console.WriteLine("Invalid number. Try again.");
                        }



                        Student s = new Student
                        {
                            Name = name,
                            Test1 = test1,
                            Test2 = test2,
                            Test3 = test3
                        };
                        stuManager.AddStudent(s);
                        break;

                    case  2:
                        stuManager.SaveToFile(filePath);
                        Console.WriteLine("Student list saved to file.");
                        break;

                    case 3:
                        stuManager = new StudentManager();
                        Console.WriteLine("Student list cleared.");
                        break;

                    case 4:
                        stuManager.LoadFromFile(filePath);
                        Console.WriteLine("Students loaded from file:");
                        stuManager.DisplayStudents();
                        break;

                    case 5:
                         functioning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

         
    }
}
    

