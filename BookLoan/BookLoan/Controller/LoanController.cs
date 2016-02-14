using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer.Controller
{
    class LoanController
    {
        private List<Loan> loans;
        private LoanCollection loanCollection;
        public LoanController()
        {
            loanCollection = new LoanCollection();
            if (loanCollection.LoanCellection != null)
            {
                loans = loanCollection.LoanCellection;
            }
            else
            {
                loans = new List<Loan>();
            }
               
            
        }
        /// <summary>
        /// create loan and store it to a file
        /// </summary>
        /// <param name="borrowDate"></param>
        /// <param name="period"></param>
      
        public void  CreateLoan(string borrowDate, int period,string copySerialNumber)
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 500);
            while (GetloanByID(id) != null)
            {
                id = rnd.Next(1, 500);
            }
            BookController bookCtrl = new BookController();
            Copy copy = bookCtrl.getCopyOfBookByCopySerialNumber(copySerialNumber);
           
            double price = copy.Price;
            price = price * period;
            copy.State = false;
            Loan loan = new Loan(id, borrowDate, period,price,copySerialNumber);
            loans.Add(loan);
            loanCollection.StoreLoanCollectionToFile(loans);
               
            
        }
        /// <summary>
        /// this method return  object of type Loan searched by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>loan object of type Loan and null if there is no such a object</returns>
        public Loan GetloanByID(int id)
        {
            foreach (Loan loan in loans)
            {
                if (loan.ID.Equals(id))
                {
                    return loan;
                }
            }
            return null;
        }
        /// <summary>
        /// remove loan by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if the loan is removed correctly and false it it is not removed</returns>
        public bool removeLoan(int id)
        {
            if(GetloanByID(id)!= null)
            {
                loans.Remove(GetloanByID(id));
                return true;
            }
            return false;
        }
        public void printAllLoans()
        {
            foreach (Loan l in loans)
            {
                Console.WriteLine(l);
            }
        }
    }
}
