using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Persons
    {
        // Persons collection stores person objects
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }
        /// <summary>
        /// Add person to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null; 
        }

        public Person FindPerson(string SocialSecurityNumber)
        {
            foreach(Person person in persons)
            {
                //Compare two strings
                if (SocialSecurityNumber.Equals(person.SocailSecuritynumber))
                {
                    return person;
                }
            }
            return null; // person with search socials.. not found in collection
        }

        public void PrintData()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
                
            }
        }

    }
}
