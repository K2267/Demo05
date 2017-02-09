using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Persons (collection)
            Persons myFriends = new Persons();

            //create new person objects
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocailSecuritynumber = "1212212-1234" };
            Person person2 = new Person { Firstname = "Timo", Lastname = "Toinei", SocailSecuritynumber = "1299912-2224" };
            Person person3 = new Person { Firstname = "Simo", Lastname = "Siivonen", SocailSecuritynumber = "8882212-1111" };

            //add Person objects to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //get one person
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("There is no person at that position!!!!!!!!!!");
            }
            //print collection
            myFriends.PrintData();

            //find person
            string socialSecurityNumber = "1212212 - 1234";
            Console.WriteLine("Find Person with ssn : " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Cant find person with that ssn");
            }
        }
    }
}
