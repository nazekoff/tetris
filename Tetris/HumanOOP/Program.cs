using System;

namespace HumanOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] humen = new Human[2];

            humen[0] = new Employee(29, 100000);
            humen[1] = new Officer(30, "Генерал");

            foreach (Human h in humen)
            {
                h.Write();
            }

            Console.ReadKey();

        }
    }
}
