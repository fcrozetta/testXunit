using System;
using Program.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            System.Console.WriteLine(a.bark());
            Animal b = new Cat();
            System.Console.WriteLine(b.bark());
        }
    }
}
