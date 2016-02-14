using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer.Controller
{
    class BookController
    {
        private List<Book> books;
        private BookCollection bookCollection;
        public BookController()
        {
            bookCollection = new BookCollection();
            books = new List<Book>();
            if(bookCollection.GetBookCollection != null)
            {
                books = bookCollection.GetBookCollection;
            }
            
        }
        /// <summary>
        /// this method create a object of type Book
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="publicationDate"></param>
       
        public void createBook( string title, string author, string publicationDate)
        {
            Random rnd = new Random();
            int barcode = rnd.Next(1, 500);
            while (GetBookByBarcode(barcode) != null)
            {
                barcode = rnd.Next(1, 500);
            }
            Book book = new Book(barcode,title,author,publicationDate);
            books.Add(book);
            bookCollection.StoreBookCollectionToFile(books);
           
        }
        /// <summary>
        /// find and return object of type Book searched by barcode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns> book object or null if there is no book with this barcode </returns>

        public Book GetBookByBarcode(int barcode)
        {
            try {
                foreach (Book book in books)
                {
                    if (book.Barcode.Equals(barcode))
                    {
                        return book;
                    }
                }
            }
            catch ( NullReferenceException ex)
            {
                Console.WriteLine(ex.StackTrace);
               
            }
            return null;


        }
        /// <summary>
        /// remove book from the collection searched by barcode
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>true if it is removed successfully and false otherwise</returns>

        public bool RemoveBookByBarcode(int barcode)
        {
            try
            {
                books.Remove(GetBookByBarcode(barcode));
                bookCollection.StoreBookCollectionToFile(books);
                return true;
            }catch(Exception ex)
            {
                
                ex.GetBaseException();
                return false;
            }
          
        }
        /// <summary>
        /// create copy of given book searched by barcode and increase its quantity with 1
        /// </summary>
        /// <param name="bookBarcode">the barcode of the book </param>
        /// <param name="serialNumber"></param>
        /// <param name="purchaseDate"></param>
        /// <param name="purchasePrice"></param>
        /// <returns>true if the copy is created successfully and false otherwise </returns>
        public bool CreateCopyOfBook(int bookBarcode, string purchaseDate, double purchasePrice, bool state)
        {
            Book book = GetBookByBarcode(bookBarcode);
            Random random = new Random();
            int index = random.Next(1, 500);
            String serialNumber = index.ToString();
            while(book.GetCopyBySerialNumber(serialNumber)!= null)
            {
                index = random.Next(1, 500);
                serialNumber = index.ToString();

            }
            if(book != null )
            {
                Copy copy = new Copy(serialNumber,purchaseDate,purchasePrice,state );
                book.Copies.Add(copy);
                book.Quantity += 1;
                bookCollection.StoreBookCollectionToFile(books);
                return true;
            }
            return false;
        }
        /// <summary>
        /// found copy of book by serialn number of the copy and return it
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns>copy if there is match at the serial number and null otherwise</returns>
        public Copy getCopyOfBookByCopySerialNumber(string serialNumber)
        {
            foreach (Book book in books)
            {
                foreach (Copy copy in book.Copies)
                {
                    if (copy.SerialNumber.Equals(serialNumber))
                    {
                        return copy;
                    }

                }
            }
            return null;
        }
       
        
        public void showAllBooks()
        {
            foreach(Book b in books)
            {
                Console.WriteLine(b);
            }
        }
        public void showAllCopiesForEachBook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
                Console.WriteLine();
                foreach (Copy copy in book.Copies)
                {
                    Console.WriteLine(copy);

                }
                Console.WriteLine();
            }
        }
    }
    
}
