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

                case 2:

                    MyMapNode<string, int> map = new MyMapNode<string, int>(10);
                    string[] Paragraph;
                    string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    Paragraph = input.Split(' ');
                    //Given string input

                    int counts = 1;
                    foreach (string i in Paragraph)
                    {
                        counts = map.CheckHash(i);
                        if (counts > 1)
                        {
                            map.Add(i, counts);
                        }
                        else
                        {
                            map.Add(i, 1);
                        }
                    }
                    Console.WriteLine("\n---------Frequency of words in paragraph---------\n");
                    IEnumerable<string> distinct = Paragraph.Distinct<string>();
                    foreach (var i in distinct)
                    {
                        map.Display(i);
                    }

                    break;

                case 3:
                    MyMapNode<string, int> myMap1 = new MyMapNode<string, int>(10);
                    string[] paragraph1;
                    string input1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    paragraph1 = input1.Split(' ');

                    int count1 = 1;
                    foreach (string i in paragraph1)
                    {
                        counts = myMap1.CheckHash(i);
                        if (count1 > 1)
                        {
                            myMap1.Add(i, counts);
                        }
                        else
                        {
                            myMap1.Add(i, 1);
                        }
                    }
                    IEnumerable<string> unique = paragraph1.Distinct<string>();
                    Console.WriteLine("\nEnter the word which you want to remove in paragraph");
                    string removeWord = Console.ReadLine();
                    myMap1.Removal(removeWord);
                    foreach (var i in unique)
                    {
                        myMap1.Display(i);
                    }
                    break;

                default:
                   
                    break;
            }
        }
    }
}
