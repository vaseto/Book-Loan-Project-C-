using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer.Controller
{
    class PersonController
    {
        private PersonCollection personCollection;
        private List<Person> personObjects;
        public PersonController()
        {
            personCollection = new PersonCollection();
            
            if (personCollection.PersonsCollection != null)
            {
                personObjects = personCollection.PersonsCollection;
            }
            else
            {
                personObjects = new List<Person>();
            }
            
        }
        /// <summary>
        /// this method create object of type Person
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="postalCode"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
      
        
        public void CreatePerson(string name, string address, string postalCode, string city, string phone)
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 500);
            while (GetPersonByID(id) != null)
            {
                id = rnd.Next(1, 500);
            }

            Person person = new Person( name,  address,  postalCode,  city,  phone, id);
            personObjects.Add(person);
            personCollection.StorePersonsInFile(personObjects);
           
        }
        /// <summary>
        ///  find and remove object of type Person searched by id
        /// </summary>
        /// <param name="id"></param>
        public void RemovePerson(int id)
        {
           
                    personObjects.Remove(GetPersonByID(id));
                    personCollection.StorePersonsInFile(personObjects);
                    
                
            
        }
        /// <summary>
        ///  find and return object of type Person searched by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>p object of type Person or null if there is no person with such id</returns>
        public Person GetPersonByID(int id)
        {
            foreach (Person p in personObjects)
            {
                if (p.ID.Equals(id))
                {
                  
                    return p;
                }
                
            }
            return null;
        }
        
        public void PrintAllPersons()
        {
            foreach (Person p in personObjects)
            {
                Console.WriteLine(p);
            }
            
        }
    }
}
