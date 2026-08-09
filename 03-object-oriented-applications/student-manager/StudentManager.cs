using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class StudentManager
    {
        private Student[] students = new Student[100];
        private int count = 0;

        public void AddStudent(Student stu)
        {
            if (count < students.Length)
            {
                students[count] = stu;
                count = count + 1;
            }
              
        }

        public void SaveToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine(students[i].Name + "," + students[i].Test1 + "," + students[i].Test2 + "," + students[i].Test3);

                    Console.WriteLine(students[i].Name + ": Final Mark = " + students[i].ComputeFinalMark());
                }
            }
        }

        public void LoadFromFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found: " + path);
                return;
            }

            string[] lines = File.ReadAllLines(path);
            count = 0;
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Student s = new Student();

                s.Name = parts[0];
                s.Test1 = Convert.ToDouble(parts[1]);
                s.Test2 = Convert.ToDouble(parts[2]);
                s.Test3 = Convert.ToDouble(parts[3]);
                
                AddStudent(s);
            }
        }

        public void DisplayStudents()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i].Name + ": Final Mark = " + students[i].ComputeFinalMark());
            }


        }
    }
}
