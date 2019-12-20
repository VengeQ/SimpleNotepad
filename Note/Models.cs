using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    public struct Expenditure
    {
        public readonly DateTime dateTime;
        public readonly Decimal amount;
        public readonly SpendType spendType;

        public Expenditure(DateTime dateTime, Decimal amount, SpendType spendType)
        {
            this.dateTime = dateTime;
            this.amount = amount;
            this.spendType = spendType;
        }
    }

    public enum SpendType
    {
        Rent,
        Food,
        Rest,
        Fit,
        Etc
    }
}
