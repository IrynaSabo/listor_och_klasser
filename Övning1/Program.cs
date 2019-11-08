using System;
using System.Collections.Generic;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> animalsNames = new List<string>();
            for(var i=0; i<5; i++)
            {
                Console.Write("Skriv ett namn på ett djur: ");
                string usersAnswer = Console.ReadLine();
                Console.Clear();
                animalsNames.Add(usersAnswer);
            }
                
            foreach (var djurnamn in animalsNames)
            {
                Console.WriteLine(djurnamn);
            }
            Console.ReadLine();
        }
    }
}
