using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Rectangle
    {
         protected double length;
         protected double width;

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;


        }

        public virtual double computePerimeter()
        {
            return 2 * (length + width);
        }

        public virtual bool IsSquare()
        {
            bool found = false;

            if (length == width)
            {
                found = true;
                return true;
            }
            else
            {
                found = false;
            }


             
            if (!found)
            {
                return false;
            }

            return found;
        }

        public virtual void display()
        {
            Console.WriteLine("Length: "+ length);
            Console.WriteLine("Width: "+ width);
            Console.WriteLine("Perimeter: "+ computePerimeter());
            Console.WriteLine("isSquare: "+ IsSquare());
        }
    }

     class Box: Rectangle
    {
        private double heigth;

        public Box(): base()
        {
            heigth = 0;
        }

        public Box(double length, double width, double heigth): base(length, width) 
        {
            this.heigth = heigth;
            
        }
        public override double computePerimeter()
        {
            return 4 * (length + width + heigth);
        }

        public override bool IsSquare()
        {

            bool found = false;
            if (length == width && length == heigth && heigth == length && heigth == width)
            {
                found = true;
                return true;
            }
            else
            {
                found = false;
            }

            if (!found)
            {
                found = false;
                return false;
            }
            return found;
        }

        public override void display()
        {
            Console.WriteLine("Heigth: "+ heigth);

            base.display();
            double totalLength = length + width + heigth;
            Console.WriteLine("Total edge length: "+ totalLength);
            bool found = false;
            if (length == width && length == heigth && heigth == length && heigth == width)
            {
                found = true;
                 
            }
            else
            {
                found = false;
            }

            if (!found)
            {
                found = false;
              
            }
            Console.WriteLine("isCube: "+ found);
        }


    }
}
