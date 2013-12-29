using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // represent an operation to be performed on the elements of an object structure
    // visitor lets you define a new operation without
    // changing the classes of the elements on which it operates
    class Program
    {
        // calculating the assests of a person without knowing the specifics
        static void Main(string[] args)
        {
            var person = new Person();

            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            var netWorthVisitor = new NetWorthVisitor();
            var incomeVisitor = new IncomeVisitor();

            person.Accept(incomeVisitor);
            person.Accept(netWorthVisitor);

            Console.WriteLine("Networth: {0}", netWorthVisitor.Total);
            Console.WriteLine("Monthly Income: {0}", incomeVisitor.Amount);


            // doing it without the visitor pattern

            //person.BankAccounts.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            //person.BankAccounts.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            //person.RealEstates.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            //person.Loans.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            //int netWorth = 0;

            //foreach (var bankAcc in person.BankAccounts)
            //{
            //    netWorth += bankAcc.Amount;
            //}

            //foreach (var realEstate in person.RealEstates)
            //{
            //    netWorth += realEstate.EstimatedValue;
            //}

            //foreach (var loan in person.Loans)
            //{
            //    netWorth -= loan.Owed;
            //}

            //Console.WriteLine(netWorth);
        }
    }
}
