using BookLoanModelLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    class PersonCollection
    {
        private List<Person> personCollection;
        private string fileName;
        private ReadAndWriteToFile<Person> rw;
        public PersonCollection()
        {
            rw = new ReadAndWriteToFile<Person>();
            personCollection = new List<Person>();
            fileName = "Persons.ser";
        }
        private void GetPersonsFromFile()
        {
            personCollection=rw.GetObjectsFromFile(fileName);
          
        }
        public void StorePersonsInFile(List<Person> personCollection)
        {
            rw.StoreObjectsToFile(personCollection, fileName);
            
        }
        public List<Person> PersonsCollection
        {
            get
            {
                GetPersonsFromFile();
                return personCollection;
            }
           
        }
    }
}
