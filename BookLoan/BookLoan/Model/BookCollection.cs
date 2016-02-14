using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    class BookCollection
    {
        private string fileName;
        private List<Book> bookCollection;
        private ReadAndWriteToFile<Book> rw;
        public BookCollection()
        {
            rw = new ReadAndWriteToFile<Book>();
            fileName = "Books.ser";
            bookCollection = new List<Book>();
        }
        private void GetBookCollectionFromFile()
        {
            
            bookCollection = rw.GetObjectsFromFile(fileName);
        }
        public void StoreBookCollectionToFile(List<Book> bookCollection)
        {
            rw.StoreObjectsToFile(bookCollection, fileName);
        }
        public List<Book> GetBookCollection
        {
            get
            {
                GetBookCollectionFromFile();
                return bookCollection;
            }
        }

    }
}
