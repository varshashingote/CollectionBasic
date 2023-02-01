using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adding arraylist elememt
            ArrayList al=new ArrayList();   
            al.Add(1);
            al.Add(2);
            al.Add(3);
            Console.WriteLine(al.Capacity);
            al.Add(4);
            al.Add(5);
            al.Add(6);
            //shows capacity
           Console.WriteLine(al.Capacity);
            foreach (int i in al)
                Console.WriteLine(i);
                Console.ReadLine();

            Console.WriteLine(al.Capacity);
            //insetng element

            al.Insert(1, 100);
            al.Insert(2, 150);
            foreach (int i in al)
                Console.WriteLine(i);
            Console.ReadLine();
            //remove element
            al.Remove(3);
            foreach (int i in al)
                Console.WriteLine(i);
            Console.ReadLine();




        }
    }
}
