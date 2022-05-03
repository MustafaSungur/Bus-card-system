using System;
using System.Collections.Generic;
using System.Text;

namespace project_1_bus
{
    public class Date
    {
        public DateTime Birthdate = new DateTime();
        public Date(int day, int month, int year)
        {
            Birthdate = new DateTime(year, month, day);
        }
        


    }
}
