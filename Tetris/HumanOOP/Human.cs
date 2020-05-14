using System;
using System.Collections.Generic;
using System.Text;

namespace HumanOOP
{
    abstract class Human
    {
        protected int age;
        protected int height;

        public void Set(int a)
        {
            age = a;
        }

        public void Set(int a, int h)
        {
            age = a;
            height = h;
        }

        //public virtual void Write()
        //{
        //    Console.WriteLine($"age : {age}. height: {height}");
        //}

        public abstract void Write();
    }
}
