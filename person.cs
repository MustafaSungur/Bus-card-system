using System;
using System.Collections.Generic;
using System.Text;

namespace project_1_bus
{
    abstract class person
    {
        protected Date birthdate;
        protected int age;
        protected decimal balance;
        DateTime now = DateTime.Now;
        public person(string firstName, string lastName,Date birthdate)
        {
            FirstName = firstName;
            Lastname = lastName;
            this.birthdate = birthdate;
        }
        public virtual int Age()
        {
            age = now.Year - birthdate.Birthdate.Year;

            return age;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance must be >0");
                }
                balance = value;
            }
        }
        public int Count { get; set; }
        public string FirstName { get; private set; }
        public string Lastname { get; private set; }
        

        public abstract void Payment();
        public virtual void LoadMoney(int money)
        {
            Balance += (decimal)money;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\n" +
                   $"Last Name: {Lastname}\n" +
                   $"Birthday: {birthdate.Birthdate.ToString("d")}\n" +
                   $"Age: {Age()}\n";


        }
    }
}
