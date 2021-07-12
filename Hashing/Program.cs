﻿using System;
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
                    string input = "earning to code is learning to create and innovate code , to create easy and learnable code";
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

                default:
                   
                    break;
            }
        }
    }
}
