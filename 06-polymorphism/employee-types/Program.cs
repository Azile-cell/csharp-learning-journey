using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q3_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Employee []employee = new Employee[2];

            for (int i = 0; i < employee.Length; i++)
            {
                Console.Write("Enter letter to det if  for " + (i + 1)+" C = Contract or P = Permanent: ");
                string c =  Console.ReadLine().ToUpper();
                if (c == "C")
                {
                    ContractEmployee contractEmployee = new ContractEmployee();
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    contractEmployee.GetFullName();
                    contractEmployee.SetFirstName(name);
                    contractEmployee.SetLastName(lastName);


                    Console.Write("Enter basic salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    contractEmployee.GetBasicSalary();
                    contractEmployee.SetBasicSalary(salary);

                    employee[i] = contractEmployee;
                }
                else if (c == "P")
                {
                    PermanentEmployee permanent = new PermanentEmployee();

                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    permanent.GetFullName();
                    permanent.SetFirstName(name);
                    permanent.SetLastName(lastName);

                    Console.Write("Enter basic salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    permanent.GetBasicSalary();
                    permanent.SetBasicSalary(salary);

                    employee[i] = permanent;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                        i--;
                }

            }

            Console.WriteLine("----Employee Information-----");

            foreach (Employee employ in employee)
            {
                employ.DisplayEmployeeDetails();

            }

            Console.ReadKey();

        }
    }

}
