using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    class LoanCollection
    {
        private List<Loan> loanCollection;
        private ReadAndWriteToFile<Loan> rw;
        private string fileName;
        public LoanCollection()
        {
            rw = new ReadAndWriteToFile<Loan>();
            loanCollection = new List<Loan>();
            fileName = "Loans.ser";
        }
        private void GetLoanObjects()
        {
           loanCollection = rw.GetObjectsFromFile(fileName);
        }
        public void StoreLoanCollectionToFile(List<Loan> loanCollection)
        {
            rw.StoreObjectsToFile(loanCollection, fileName);
        }
        public List<Loan> LoanCellection
        {
            get
            {
                GetLoanObjects();
                return loanCollection;
            }
        }

    }
}
