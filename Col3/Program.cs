using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); 
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            //print element usinf for loop
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]+"");
                Console.ReadLine();
            }

            //using foreachloop
            foreach(int i in list)
                Console.WriteLine(i+"");
            Console.ReadLine();

            //adding item
            list.Insert(1, 10); foreach (int i in list)
            Console.WriteLine(i + "");
            Console.ReadLine();

            //removing item
            list.Remove(10);

            foreach (int i in list)
            Console.WriteLine(i + "");
            Console.ReadLine();


        }
    }
}
