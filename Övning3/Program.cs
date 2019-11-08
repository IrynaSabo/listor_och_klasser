using System;
using System.Collections.Generic;

namespace Övning3
{
    class Person{
        private string name;
        private string surename;
        private int age;
        private string town;
        private string work;

        public Person(string name, string surename, int age, string town, string work){
           this.name = name;
           this.surename = surename;
           this.age = age;
           this.town = town;
           this.work = work;
        }
        public string Name {set{ name = value; }}
        public string Surename {set{ surename = value;}}
        public int Age {set{ age = value;}}
        public string Town {set{ town = value;}}
        public string Work {set{ work = value;}}

        public void userInfo(){
         Console.WriteLine($"{name} {surename} är {age} år gammal. Hen är {work} och bor i {town} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Skriva ett konsolprogram som ställer en rad olika frågor till användaren om en viss person...
Vad heter personen? För- och efternamn. (spara dessa separat)
Vilken ålder har personen?
Vart i världen bor personen?
Vilken sysselsättning har personen?
När alla frågor har svarats på ska informationen sparas i ett objekt av en lämplig klass som du skapat.
Programmet ska sen rensa konsolen och presentera informationen man matat in på ett snyggt sätt.*/
          Console.Write("Ange ditt namn: ");
          string userName = Console.ReadLine();

          Console.Write("Ange ditt efternamn: ");
          string userSurename = Console.ReadLine();

          Console.Write("Ange din ålder: ");
          int userAge = Convert.ToInt32(Console.ReadLine());

          Console.Write("Var bor du ? ");
          string userTown = Console.ReadLine();

          Console.Write("Vilken sysselsättning har du? ");
          string userWork = Console.ReadLine();

          Person user = new Person(userName, userSurename, userAge, userTown, userWork);
          Console.Clear();
          
          user.userInfo();
        }
    }
}
