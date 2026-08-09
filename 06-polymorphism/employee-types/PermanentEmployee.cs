using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Summative
{
    internal class PermanentEmployee: Employee
    {
        private double performanceRating;

        public void SetPerformanceRating(int rating)
        {
            if (rating < 0 || rating > 100)
                performanceRating = 0;
            else
                performanceRating = rating;

        }
        public double GetPerformanceRating() 
        { return performanceRating; }
        public PermanentEmployee(): base()
        {
            performanceRating = 0;
            
        }

        public override double calculateBonus()  
        {
         
            double bonus = 0;

             if ( performanceRating >= 90)
             {
                return bonus = 0.25 * GetBasicSalary();
             }
            else if ( performanceRating >= 75 ||  performanceRating < 90)
            {
                return bonus = 0.15 * GetBasicSalary();
            }
            else
            {

                return bonus = 0.05 * GetBasicSalary();
            }
            

        }
        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine("Perfomance rating: "+ performanceRating+ " Bonus: "+ calculateBonus());
        }



    }
}
