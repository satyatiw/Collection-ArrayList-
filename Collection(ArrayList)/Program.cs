using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Add Elements in an Array.
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5);

            
            IList arryList2 = new ArrayList()
{
    100, 200
};
            //Add Elements using AddRange Function 
            arryList1.AddRange(arryList2);
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
                Console.ReadLine();

            //Remove from particular index.
            arryList1.RemoveAt(1);
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
            Console.ReadLine();

           // Remove a particular element
            arryList1.Remove(100);
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
            Console.ReadLine();

            // Remove element (0,4)--> 0 defines the starting point and 4 defines the no. of elements from that stating point to be removed.
            arryList1.RemoveRange(0, 4);
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
            Console.ReadLine();


            
            arryList1.Add(300);
            arryList1.Add(200);
            arryList1.Add(100);
            arryList1.Add(500);
            arryList1.Add(400);

            Console.WriteLine("Original Order:");
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
            Console.ReadLine();

            //Reverse a given ArrayList
            arryList1.Reverse();
            Console.WriteLine("Reverse Order:");
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
            Console.ReadLine();

            //Sorting on a given arrayList
            arryList1.Sort();
            Console.WriteLine("Ascending Order:");
            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
            Console.ReadLine();



        }
    }
}


