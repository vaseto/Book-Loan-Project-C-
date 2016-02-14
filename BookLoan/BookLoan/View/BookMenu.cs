using BookLoanModelLayer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer.View
{
    class BookMenu
    {
        private BookController bookCtrl;
        public BookMenu()
        {
            bookCtrl = new BookController();
        }
        public void Strat()
        {
            while (true)
            {
                Console.WriteLine("Book Menu");
                Console.WriteLine();
                Console.WriteLine("1. Create Book");
                Console.WriteLine("2. Create Copy of given Book");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. See all Books");
                Console.WriteLine("5. See all Copies of each Book");
                Console.WriteLine("6. Back");
                Console.WriteLine("7. Exit");
                var consoleResult = Console.ReadLine();
                int result = int.Parse(consoleResult);
                switch (result)
                {
                    case 1:
                        CreateBook();
                        break;
                    case 2:
                       CreateCopy();
                        break;
                    case 3:
                       RemoveBook();
                        break;
                    case 4:
                        showAllBooks();
                        break;
                    case 5:
                        showAllCopies();
                        break;
                    case 6:
                        MainStrartMenu.MainMenu();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        
        }
        private void showAllCopies()
        {
            bookCtrl.showAllCopiesForEachBook();
        }
        private void showAllBooks()
        {
            bookCtrl.showAllBooks();
        }
        private void RemoveBook()
        {
            Console.WriteLine("Please input the barcode of the book which should be removed");
            int barcode = int.Parse(Console.ReadLine());
            bookCtrl.RemoveBookByBarcode(barcode);
        }
        private void CreateCopy()
        {
            Console.WriteLine("Please input the barcode of the book");
            int barcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the purchase date");
            var purchaseDate = Console.ReadLine();
            Console.WriteLine("Please input the price per day");
            double purchasePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input the state(true if the copy of the book is free and false otherwise");
            bool state = bool.Parse(Console.ReadLine());
            bookCtrl.CreateCopyOfBook(barcode, purchaseDate, purchasePrice, state);
        }
        private void CreateBook()
        {
            Console.WriteLine("Please input the title");
            var title = Console.ReadLine();
            Console.WriteLine("Please input the author");
            var author = Console.ReadLine();
            Console.WriteLine("Please input the publication date");
            var publicationDate = Console.ReadLine();
            bookCtrl.createBook(title, author, publicationDate);
        }
    }
}
