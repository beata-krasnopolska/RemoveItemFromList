using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveItemFromListLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program removes items from List using remove function");
            List<string> itemsList = new List<string>() {"q","w","e","r","t","y" };

            Console.WriteLine("The list of items:");
            foreach(var p in itemsList)
            {
                Console.WriteLine(p);
            }
            string newString = itemsList.FirstOrDefault(p => p == "w");
            itemsList.Remove(newString);

            Console.WriteLine("The list of items after removing 'w' from the list");
            foreach (var mp in itemsList)
            {
                Console.WriteLine(mp);
            }
            Console.ReadKey();
        }
    }
}
