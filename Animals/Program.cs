using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Talkable> zoo = new List<Talkable>();

            // Lines to Replace Begin Here
            //zoo.Add(new Dog(true, "Bean"));
            //zoo.Add(new Cat(9, "Charlie"));
            //zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            Console.WriteLine("What type of animal do you want to add to your zoo?");
            Console.WriteLine("1.) Dog");
            Console.WriteLine("1.) Cat");
            Console.WriteLine("1.) Person");
            int response = Convert.ToInt32(Console.ReadLine());
            switch (response) {
                case 1:
                    Console.WriteLine("Is this dog friendly? (Y or N)");
                    string friendly = Console.ReadLine();
                    Console.WriteLine("What is it's name?");
                    string dname = Console.ReadLine();
                    bool f = (friendly == "Y") ? true : false;
                    zoo.Add(new Dog(f,dname));
                    Console.WriteLine("Your Dog, " + dname + ", has been added to the Zoo!");
                    break;
                case 2:
                    Console.WriteLine("How many Mice has your cat caught?");
                    int mice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is your cats name?");
                    string cname = Console.ReadLine();
                    zoo.Add(new Cat(mice, cname));
                    Console.WriteLine("Your Cat, " + cname + ", has been added to the Zoo!");
                    break;
                case 3:
                    Console.WriteLine("How old is your person?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is your persons name?");
                    string pname = Console.ReadLine();
                    zoo.Add(new Cat(age, pname));
                    Console.WriteLine("Your Person, " + pname + ", has been added to the Zoo!");
                    break;
                default:
                    Console.WriteLine("You have chosen poorly");
                    Console.WriteLine("Exiting system...");
                    break;





            }




            foreach (Talkable thing in zoo)
            {
                Console.WriteLine(thing.getName());
            }
            //outFile.fileClose();
            //inFile.fileRead();
            //inFile.fileClose();

            //FileInput indata = new FileInput("animals.txt");
            //String line;
            //while ((line = indata.fileReadLine()) != null)
            //{
            //    System.out.println(line);
            //}
        }

        //public static void printOut(Talkable p)
        //{
        //    System.out.println(p.getName() + " says=" + p.talk());
        //    outFile.fileWrite(p.getName() + " | " + p.talk());
        //}
    }
}

