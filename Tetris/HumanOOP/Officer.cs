using System;
using System.Collections.Generic;
using System.Text;

namespace HumanOOP
{
    class Officer : Human
    {
        public string rank;

        public Officer(int a, string r)
        {
            age = a;
            rank = r;
        }

        public override void Write()
        {
            Console.WriteLine($"age : {age}. height: {height}. rank: {rank}");
        }
    }
}
