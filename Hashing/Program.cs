using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashing");
            int option = Convert.ToInt32(Console.ReadLine());
            MyMapNode<string, int> mymapnode = new MyMapNode<string, int>(6);
            switch (option)
            {
                case 1:
                    string[] words = { "to", "be", "or", "not", "to", "be" };
                    int count = 1;
                    foreach (string i in words)
                    {
                        count = mymapnode.CheckHash(i);
                        if (count > 1)
                        {
                            mymapnode.Add(i, count);
                        }
                        else
                        {
                            mymapnode.Add(i, 1);
                        }
                    }

                    IEnumerable<string> uniqueItems = words.Distinct<string>();
                    foreach (var i in uniqueItems)
                    {
                        mymapnode.Display(i);
                    }
                    break;
                default:
                    Console.WriteLine("Enter the valid option!!!");
                    break;
            }
        }
    }
}
