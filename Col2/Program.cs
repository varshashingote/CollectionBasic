using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Col2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // iterator is faaster than array and arraylist for feching data.
                //becasuse od hashtable work on hashing alogorithm means numeric value that is hashcaode
              //that why it is unordered.
            Hashtable ht= new Hashtable();
            ht.Add("Ename", "varsha");
            ht.Add("id", "varshagunjal01@");
            ht.Add("eno", 8788583058);
            ht.Add("Eid", 01);
            foreach(object key in ht.Keys){
                Console.WriteLine(key + ":" + ht[key]);
                Console.ReadLine();
            }

        }
    }
}
