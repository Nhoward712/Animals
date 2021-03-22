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
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

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

