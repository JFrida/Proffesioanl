using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<int> custCollection = new CustomCollection<int>();
            custCollection.Add(1);
            custCollection.Add(2);
            custCollection.Remove(1);
            //Console.WriteLine(custCollection.Count);
            //Console.WriteLine(custCollection.Contains(2));
            //Console.WriteLine(custCollection.Count);
            Console.ReadLine();
        }
    }
}
