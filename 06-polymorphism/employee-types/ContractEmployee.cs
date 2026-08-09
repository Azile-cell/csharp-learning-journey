using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Summative
{
    internal class ContractEmployee: Employee
    {
        private int contractMonths;

        public void SetContractMonths(int months)
        {
            if (months < 0)
                contractMonths = 0;
            else
                contractMonths = months;
        }

        public int GetContractMonths()
        {
            return contractMonths;
        }
        public int ContractMonths
        {
            get { return this.contractMonths; } 
            set { this.contractMonths = value; }
        }

        public ContractEmployee()
        {
           contractMonths = 0;
        }
        public override double calculateBonus()
        {
            double bonus = 0;
            if (contractMonths > 12)
            {
                return bonus = 0.10 * GetBasicSalary();

            }
            else
            {
                return bonus = 0.05 * GetBasicSalary();

            }
        
        }

    }
}
