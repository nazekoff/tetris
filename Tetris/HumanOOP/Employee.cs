﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HumanOOP
{
    class Employee : Human
    {
        public int salary;

        public Employee(int a, int s)
        {
            age = a;
            salary = s;
        }

        public Employee()
        {

        }

        public override void Write()
        {
            Console.WriteLine($"age : {age}. height: {height}. salary: {salary}");
        }
    }
}
