using System;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Витя", "Алёша", "Мира", "Андрей", 
                "Виктория", "Олег", "Кира" };
            MyClassEnumer names = new MyClassEnumer(name);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
