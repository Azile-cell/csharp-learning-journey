using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle [] rectangle = new Rectangle[4];
            Box [] box = new Box[4];
            for (int i = 0; i < rectangle.Length; i++)
            {
                Console.WriteLine("-----Rectangle details-----");
             
                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                rectangle[i] = new Rectangle(length, width);

                rectangle[i].display();

                Console.WriteLine("\n-----Box Details-----");
                Console.Write("Enter heigth: ");
                double heigth = Convert.ToDouble(Console.ReadLine());
                box[i] = new Box(length, width, heigth);
                box[i].display();
            }

            Console.ReadKey();
        }
    }
}
