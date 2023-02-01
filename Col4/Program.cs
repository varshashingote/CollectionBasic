using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String,object> dt=new Dictionary<String,object>();
            dt.Add("Eid", 001);
            dt.Add("Ename", "varsha");
            dt.Add("Eno", 877745435);

            foreach(String key in dt.Keys)
            {
                Console.WriteLine(key + ":" + dt[key]);
                Console.ReadLine();

            }
        }
    }
}
