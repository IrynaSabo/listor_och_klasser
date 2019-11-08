using System;
using System.Collections.Generic;

namespace Övning2
{
    class Cat
    {
       public string name;
       public int age;

       public Cat (string name, int age)
       {
           this.name = name;
           this.age = age;
       }
       public void Talk()
       {
         Console.WriteLine( name + " är " + age + " år gammal och säger: Mjau.");
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Missy",4);
            myCat.Talk();
            Cat grannensCat = new Cat("Polly",6);
            grannensCat.Talk();
        }
    }
}
