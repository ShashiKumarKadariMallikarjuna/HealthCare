using System;

namespace HealthCare
{
    //abstract class called heathplan
    abstract class HealthPlan
    {
        //abstract class called GetPlan
        public abstract string GetPlan();

        //abstract class called getAnnualCharge
        public abstract int getAnnualCharge();

        //abstract class called getDeducationAmount.
        public abstract int getDeductionAmount();

    }
}
