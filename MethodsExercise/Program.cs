﻿using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Xml.Linq;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;
            string place;
            string color;
            Console.WriteLine("Hello!\nI'm working on a story that i could use some help with.\nWhat's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Thanks {name}\nNow, can you name a place?");
            place = Console.ReadLine();
            Console.WriteLine("Awesome!\nNow last thing,can you name a color");
            color = Console.ReadLine();
            Console.WriteLine("Perfect, heres my story");
            Console.WriteLine($"Their was once a person named {name}.\n One day, he decided to go for a walk in the rain and ended up at {place}");
            Console.WriteLine($"When they looked up at the sky, the couldn't belive that the sky was {color}\nThe End.");

            Console.WriteLine(Add(2, 30));
            
            

        }

        //Write a C# program that takes user input and creates a story.
        //Ask the user for things like a name, color, an animal, etc. Make up a story and be creative.

        //Write different methods that use each math operator, but allows you to plug in different integers.
        //public static int Multiply (int x , int y)
        public static int Add(params int[] list)
        {
            int num = 0;
            for (int i = 0; i < list.Length; i++)
            {
                //Console.WriteLine(list[i] + " ");
                num = num + list[i];
            }
            return num;



            //int z;
            //z = x * y;
           // return z;
        }

        public static int Multiply(int x, int y)
        {
            int z;
            z = x * y;
            return z;
        }

        public static int Subtract(int x, int y)
        {
            int z;
            z = x - y;
            return z;
        }

        public static int Divide(int x, int y)
        {
            int z;
            z = x / y;
            return z;
        }

    }
}
