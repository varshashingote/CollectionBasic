using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers= new List<Customer>();
             Customer C1 = new Customer { Custid = 101, Name = "varsha", Address = "pune", City = "punecity", Country = "India", PostalCode = "436", Region = "hindi" };
             Customer C2 = new Customer { Custid = 102, Name = "vasu", Address = "pune", City = "Ahmednagar", Country = "India", PostalCode = "436", Region = "hindi" };
             Customer C3 = new Customer { Custid = 102, Name = "suraj", Address = "sangamner", City = "punecity", Country = "India", PostalCode = "436", Region = "hindi" };

             Customer C4 = new Customer { Custid = 104, Name = "rani", Address = "nagpur", City = "punecity", Country = "India", PostalCode = "436", Region = "hindi" };


             Customer C5= new Customer { Custid = 105, Name = "varshu", Address = "pune", City = "punecity", Country = "India", PostalCode = "436", Region = "hindi" };
             customers.Add(C1);
             customers.Add(C2);
             customers.Add(C3);
             customers.Add(C4);
             customers.Add(C5);
             foreach(Customer obj in customers)
             {
                 Console.WriteLine(obj.Custid +" "+obj.Region+" "+obj.Name+" "+obj.City+" "+obj.Country+" "+obj.Phone);

             }
             Console.ReadLine();

        
        

        }
    }
}
