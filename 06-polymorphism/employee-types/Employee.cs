using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Summative
{
    internal abstract class Employee
    {
        private string firstName;
        private string lastName;
        private double basicSalary;

        protected Employee()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            basicSalary = 0;
        }

        public abstract double calculateBonus();

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine("Full name: "+ firstName+" "+ lastName);
            Console.WriteLine("Salary: "+ basicSalary);
 
        }

        public void SetFirstName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                firstName = char.ToUpper(name[0]) + name.Substring(1);
            }

        }
        public void SetLastName(string lnm)
        {
            lastName = char.ToUpper(lnm[0]) + lnm.Substring(1);
        }

        public void SetBasicSalary(double  basicSalary)
        {
            if (basicSalary < 4000)
            {
                this.basicSalary = 4000;
            }
            else
            {
                this.basicSalary = basicSalary;
            }

        }
        public string GetFullName()
        {
            return firstName+ " "+lastName;
        }

       public double GetBasicSalary()
       {
            return basicSalary;
       }

    }
	 
}
