using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    [Serializable]
    class Loan
    {
        private int id;
        private string borrowDate;
        private int period;
        private double price;
        private string copySerialNumber;
        /**
        true if the book is retunred on time  and false otherwise
        */
      
        public Loan(int id, string borrowDate, int period, double price, string copySerialNumber)
        {
            this.id = id;
            this.borrowDate = borrowDate;
            this.period = period;
            this.price = price;
            this.copySerialNumber = copySerialNumber;
          

        }
        public override string ToString()
        {
            return "Loan information: Loan ID is: \"" + id + " \", the borrow date is: \"" + borrowDate 
              + " \", period of renting is: \"" + period + " \", price is: \"" + price + " \", copy Serial Number is: \"" + copySerialNumber + " \"";
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public string BorrowDate
        {
            get
            {
                return borrowDate;
            }
            set
            {
                borrowDate = value;
            }
        }
        public int Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
            }
        }
       public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string CopySerialNumber
        {
            get
            {
                return copySerialNumber;
            }
        }
    }

     

}
