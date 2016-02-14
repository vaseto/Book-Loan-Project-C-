using BookLoanModelLayer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer.View
{
    class LoanMenu
    {
        private LoanController loanCtrl;
        public LoanMenu()
        {
            loanCtrl = new LoanController();
        }
        public void Strart()
        {
            while (true)
            {
                Console.WriteLine("Loan Menu");
                Console.WriteLine();
                Console.WriteLine("1. Create Loan");
                Console.WriteLine("2. Remove Loan");
                Console.WriteLine("3. See all Loans");            
                Console.WriteLine("4. Back");
                Console.WriteLine("5. Exit");
                var consoleResult = Console.ReadLine();
                int result = int.Parse(consoleResult);
                switch (result)
                {
                    case 1:
                        CreateLoan();
                        break;
                    case 2:
                       RemoveLoan();
                        break;
                    case 3:
                        loanCtrl.printAllLoans();
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

        private void RemoveLoan()
        {
            Console.WriteLine("Please input the id of the loan which should be removed");
            int id = int.Parse(Console.ReadLine());
            loanCtrl.removeLoan(id);
        }
        private void CreateLoan()
        {
            Console.WriteLine("Please input the borrow date");
            var borrowDate = Console.ReadLine();
            Console.WriteLine("Please input the period");
            int period = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the serial number of the copy");
            var copySerialNumber = Console.ReadLine();
            loanCtrl.CreateLoan(borrowDate, period, copySerialNumber);
        }
    }
}
