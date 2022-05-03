using System;
using System.Collections.Generic;
using System.Text;

namespace project_1_bus
{
    class old:person
    {
        public old(string firstName, string lastName, Date birthday)
              : base(firstName,lastName, birthday)
        {

        }
        public override int Age()
        {
            if (DateTime.Now.Year - birthdate.Birthdate.Year<=65 &&(DateTime.Now.Month>birthdate.Birthdate.Month || DateTime.Now.Day>birthdate.Birthdate.Day))
            {
                throw new Exception("person are not older 65");
            }

            return age = DateTime.Now.Year - birthdate.Birthdate.Year;
        }
        public override void Payment()
        {
            
        }
        public override void LoadMoney(int money)
        {
            throw new Exception("Older 65 years old people can not load money");
        }
        public override string ToString()
        {
            return base.ToString()+"Balance: free";
        }

    }
}
