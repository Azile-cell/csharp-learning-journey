using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Student
    {
        public string Name;
        public double Test1, Test2, Test3;

        public Student()
        {
            Name = string.Empty;
            Test1 = 0;
            Test2 = 0;
            Test3 = 0;
        }
       
        public double ComputeFinalMark()
        {
            return (Test1 * 0.3) + (Test2 * 0.3) + (Test3 * 0.4);
        }
      
    }
}
