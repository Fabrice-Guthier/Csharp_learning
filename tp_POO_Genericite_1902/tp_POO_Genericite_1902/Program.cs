using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Genericite_1902
{
    class Program
    {
        public static void Main(string[] args)
        {

            ListFifo<int> test = new ListFifo<int>();

            test.Add(3);
        }
        

        public void MethodeGenerique<T>(List<T> myList)
        {
            int lenghtList = myList.Count;
            Random randomPick = new Random();
            int index = randomPick.Next(0, lenghtList);

            Console.WriteLine(index.ToString());
        }
    }
}
