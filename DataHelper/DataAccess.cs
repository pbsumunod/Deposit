using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataHelper
{
    public class DataAccess
    {
        private string accountNumber, fName, lName, midInitial, address, accntType;

        public string AccntType
        {
            get { return accntType; }
            set { accntType = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string MidInitial
        {
            get { return midInitial; }
            set { midInitial = value; }
        }

        public string lastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string firstName
        {
            get { return fName; }
            set { fName = value; }
        }
        private decimal initDeposit, years, interest, balance, tax, totalInterest;

        public decimal Years
        {
            get { return years; }
            set { years = value; }
        }

        public decimal InitDeposit
        {
            get { return initDeposit; }
            set { initDeposit = value; }
        }
        public decimal ComputeInterest()
        {
            decimal rate=0M;
            switch (accntType)
            {
                case "Savings": if (years >= 1 && years <= 5)
                        rate = 0.03M;
                    else if (years >= 6 && years <= 10)
                        rate = 0.045M;
                    else
                        rate = 0.06M;
                    break;
                case "Current": if (years >= 1 && years <= 5)
                        rate = 0.04M;
                    else if (years >= 6 && years <= 10)
                        rate = 0.055M;
                    else
                        rate = 0.07M;
                    break;
            }
            interest = initDeposit * rate * years;
            return interest;
            }
        public decimal ComputeTax()
        {
            
            tax  = interest * 0.20M;
            return tax;
        }
        public decimal ComputeTotal()
        {
             totalInterest = interest - tax;
            return totalInterest;
        }
            
        

    }
}
