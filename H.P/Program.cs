using System;

namespace H.P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string subject = Console.ReadLine();
            Studdents studdents = new Studdents("Vahid Selimov", subject);
            Studdents studdents1 = new Studdents("Vahid Selimov", subject);
            Console.WriteLine(studdents.Getname(subject) + studdents.Count);
            Console.WriteLine(studdents1.Getname(subject) +studdents1.Count);


            ////burda Id yoxlanisini kecirmisem ki Id var ve her defe artir.

            //Console.WriteLine(studdents.Id);
            //Console.WriteLine(studdents1.Id);


            studdents.getinfo();
        }
    }
}
