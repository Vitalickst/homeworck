﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternEx
{
    public sealed class Singleton
    {
        private static readonly Singleton instanse = new Singleton();
        private int numberOfInstances = 0;
        //Private constructor is used to prevent 
        //creation of instances with 'new' keyword outside this class
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the privet constructor");
            numberOfInstances++;
            Console.WriteLine("Number of instances = {0}",numberOfInstances);
        }
        public static Singleton Instance
        {
            get 
            {
                Console.WriteLine("We already have an instance now. Use it.");
                return instanse;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Singleton Pattern Demo ***\n");
            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.Read();
        }
    }
}
