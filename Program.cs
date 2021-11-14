using System;

namespace BaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BaseEntity baseEntity = new Student(2, "Beia", new CSV());
            baseEntity.Print();

        }
    }
}
