using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare
{
    //class ObamaCare inherits HealthPlan class
    class ObamaCare : HealthPlan
    {
        //private variable called planType
        static private string planType;

        //private variable called annualCharge that is immutable
        static private int annualCharge;

        //private variable called deductionAmount that is immutable
        static private int deductionAmount;

        //overriding the abstract method called GetPlan which returns the name of the plan chosen.
        public override string GetPlan()
        {
            return planType;
        }

        //overloaded constructor that takes in annual charge and deducation amount and assigns it to this class.
        public ObamaCare(int annualCharge1, int deductionAmount1)
        {
            planType = "Obama Care";
            annualCharge = annualCharge1;
            deductionAmount = deductionAmount1;
        }

        //overriding the abstract method called getAnnualCharge which returns the annualCharge of this plan
        public override int getAnnualCharge()
        {
            return annualCharge;
        }

        //overriding the abstract method called getDeductionAmount which returns the DeductionAmount of this plan
        public override int getDeductionAmount()
        {
            return deductionAmount;
        }
    }
}
