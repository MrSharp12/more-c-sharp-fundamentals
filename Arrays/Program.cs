﻿using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            ////Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers.Length);
            //Console.ReadLine();

            int[] numbers = new int[] {4, 8, 15, 16, 23, 42};

            string[] names = new string[] { "eddie", "alex", "michael", "david" };


            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            string zig = "you can get what you want out of life";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

        }
    }
}
