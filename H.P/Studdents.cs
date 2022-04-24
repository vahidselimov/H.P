using System;
using System.Collections.Generic;
using System.Text;

namespace H.P
{
    internal  class Studdents
    {
        private static int _id;
        public  int Id { get; set; }
        public string Fullname  { get; set; }
        public string Subject { get; set; }
        private static int _count=1000;
        public  int Count;
        public Studdents(string fullname,string subject)
        {
            _count++;
            Count = _count;
            _id++;
            Id = _id;
            Fullname = fullname;
            Subject = subject;
        }
        public string Getname(string subject )
        {
            if (subject == null)
            {
                
                return null;
 
            }
            
            return char.ToUpper(subject[0]) + char.ToUpper(subject[1]).ToString();
           

        }

        ////Elave olaraq Get info methodu yaradib butun deyerleri ekranda gostermek olar

        public void getinfo()
        {
            Console.WriteLine($"subject:{Subject},Count{Count},Fullname:{Fullname},Id{Id}");
        }
    }
}
