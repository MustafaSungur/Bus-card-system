using System;
using System.Collections.Generic;
using System.Text;

namespace project_1_bus
{
    class student:person
    {        
        public student(string firstName, string lastName, Date birthday,string school)
             : base(firstName, lastName,birthday)
        {
            School = school;
        }
        public string School { get; private set; }
        public override void Payment()
        {
            if (Balance - 2.20M <0)
            {
                throw new Exception("Balance is not enough");
            }
            Balance -= 2.20M;
            Count++;
        }
        public override void LoadMoney(int money)
        {
            if (money<=0)
            {
                throw new Exception("Loading money must be >0");
            }
            Balance += (decimal)money;
        }
        public override string ToString()
        {
            return base.ToString()+$"School Name: {School}\n" +
                                    $"Balance: {Balance}";
        }
    }
}
