using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCoursework
{
    class BankAccount
    {
       
        //The account balance
        public decimal Balance { get; set; }

        //Add money to the account
        public void Credit(decimal amount)
        {
            Balance += amount;
        }

        //Remove money from the account
        public void Debit(decimal amount)
        {
            Balance -= amount;
            //See if there is enough money
            if (Balance < amount)
            {
                //Not enough money, raise the Overdrawn event
                if (overdrawn != null)
                {
                    OverdrawnEventsArg arg = new OverdrawnEventsArg();
                    arg.currentBalance = Balance;
                    arg.invalidBalance = Balance - amount;
                    overdrawn(this, arg);
                }
            }
            else
            {
                //There's enough money
                Balance -= amount;
            }
        }

        //Define the OverdrawnEventsArg type
        public class OverdrawnEventsArg
        {
            public decimal currentBalance, invalidBalance;
        }

        //Define the OverdrawnEventsArg delegate type
        public delegate void OverdrawnEventsHandler(object sender, OverdrawnEventsArg arg);


        //Declare the Overdrawn event
        public event OverdrawnEventsHandler overdrawn;
    }
}
