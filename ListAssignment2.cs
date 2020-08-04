using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment2
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;

        public Person()
        { }
        public Person(int _age, string _fname, string _lname, string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }

        public void Displayperson()
        {
            Console.WriteLine("age : {0} ||firstname : {1} || last name : {2} || city:{3}", age, fname, lname, city);
            Console.WriteLine("---------------------------------------------------------------------------");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Per = new List<Person>();
            Person p1 = new Person(21, "Likitha", "Raj", "Vijayawada");
            Person p2 = new Person(22, "Jaya", "Krishna", "Machilipatnam");
            Person p3 = new Person(25, "Tushara", "Vunnava", "Gosala");
            Person p4 = new Person(20, "Hemasree", "Naidu", "Pamarru");
            Person p5 = new Person(22, "Aishwarya", "Velchuri", "Jaggaipet");
            Per.Add(p1);
            Per.Add(p2);
            Per.Add(p3);
            Per.Add(p4);
            Per.Add(p5);
            foreach (var p in Per)
            {
                 p.Displayperson();
            }
        }


    }
    
}
