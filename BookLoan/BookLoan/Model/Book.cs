using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    [Serializable]
    class Book
    {
        private int barcode;
        private String title;
        private String author;
        private String publicationDate;
        private int quantity;
        private List<Copy> copies;
        public Book(int barcode, String title, String author, String publicationDate)
        {
            
            this.barcode = barcode;
            this.title = title;
            this.author = author;
            copies = new List<Copy>();
            this.publicationDate = publicationDate;
          
            this.quantity = copies.Count;
           
        }
        public override String ToString()
        {
            return "Book information: Title is: " + "\"" + title + " \", Author is: \"" + author
                + " \", publicationDate is: \"" + publicationDate + " \", Barcode is: \"" + barcode + " \", quantity is: \"" + quantity + "\"";


        }
        public Copy GetCopyBySerialNumber(string serialNumber)
        {
            foreach (Copy copy in copies)
            {
                if (copy.SerialNumber.Equals(serialNumber))
                {
                    return copy;
                }
            }
            return null;
        }
        public int Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                barcode = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string PublicationDate
        {
            get
            {
                return publicationDate;
            }
            set
            {
                publicationDate = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;

            }
            set
            {
                quantity = value;
            }
        }
        public List<Copy> Copies
        {
            get
            {
                return copies;
            }
        }
    }
    
}
