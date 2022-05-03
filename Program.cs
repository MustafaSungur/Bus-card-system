using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace project_1_bus
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //database bağla
                var dates = new List<Date>() {new Date(12, 12, 1950) };
                var persons = new List<person>() {

                new old("Ali", "Yılmaz",dates[0])

            };
               
              
                Console.WriteLine(persons[0].ToString());



                Console.ReadLine();
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
