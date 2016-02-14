using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    [Serializable]
    class Copy
    {
        private string serialNumber;
        private string purchaseDate;
        private double price;// price per day
      
        private bool state;  // the state is ture if the copy of the book is free and false otherwise
        public Copy(string serialNumber, string purchaseDate, double purchasePrice, bool state) 
        {
            this.serialNumber = serialNumber;
            this.price = purchasePrice;
            this.purchaseDate = purchaseDate;
            this.state = state;
        }
        public override string ToString()
        {
            return "Copy information: Copy serial number is: \"" + serialNumber + " \",  date of purchase is: \"" + purchaseDate
              + " \", purchase price is: \"" + price  +" \", state of the copy is: \"" + state + " \"";
        }
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }
        public string PurchaseDate
        {
            get
            {
                return purchaseDate;
            }
            set
            {
                purchaseDate = value;
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
                Price = value;
            }
        }
        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
    }
}
