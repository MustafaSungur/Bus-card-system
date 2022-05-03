using System;
using System.Collections.Generic;
using System.Text;

namespace project_1_bus
{
    class FullPerson:person
    {
        public FullPerson(string firstName, string lastName, Date birthday)
            : base(firstName, lastName,birthday)
        {
        }
        public override void Payment()
        {
            if (Balance - 6.50M < 0)
            {
                throw new Exception("Balance is not enough");
            }
            Balance -= 6.50M;
            Count++;
        }
        public override void LoadMoney(int money)
        {
            if (money <= 0)
            {
                throw new Exception("Loading money must be >0");
            }
            Balance += (decimal)money;
        }
        public override string ToString()
        {
            return base.ToString() + $"Balance: {Balance}"; 
        }
    }
}
