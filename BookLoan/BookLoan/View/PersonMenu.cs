using BookLoanModelLayer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer.View
{
    class PersonMenu
    {
        private PersonController personCtrl;
        public PersonMenu()
        {
            personCtrl = new PersonController();
        }
        public void start()
        {
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("Person Menu");
                Console.WriteLine();
                Console.WriteLine("1. Create Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. See all Persons");
                Console.WriteLine("4. Back");
                Console.WriteLine("5. Exit");
                var consoleResult = Console.ReadLine();
                int result = int.Parse(consoleResult);
                switch (result)
                {
                    case 1:
                        CreatePerson();
                        break;
                    case 2: RemovePerson();
                        break;
                    case 3: SeeAllPersons();
                        break;
                    case 4: 
                        MainStrartMenu.MainMenu();
                        break;
                    case 5:
                       Environment.Exit(0);
                        break;
                }
            }
        }
        private void SeeAllPersons()
        {
            personCtrl.PrintAllPersons();
        }
        private void RemovePerson()
        {
            Console.WriteLine("Please input the id of the person who will be removed");
            int id = int.Parse(Console.ReadLine());
            personCtrl.RemovePerson(id);
        }
        private void CreatePerson()
        {
            Console.WriteLine("Please input the name");
            var name = Console.ReadLine();
            Console.WriteLine("Please input the address");
            var address = Console.ReadLine();
            Console.WriteLine("Please input the postal code");
            var postalCode = Console.ReadLine();
            Console.WriteLine("Please input the city");
            var city = Console.ReadLine();
            Console.WriteLine("Please input the phone");
            var phone = Console.ReadLine();
            personCtrl.CreatePerson(name, address, postalCode, city, phone);

        }
    }
}
