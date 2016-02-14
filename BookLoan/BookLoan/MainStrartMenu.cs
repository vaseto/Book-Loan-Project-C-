using BookLoanModelLayer.Controller;
using BookLoanModelLayer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookLoanModelLayer
{
    class MainStrartMenu
    {
        static void Main(string[] args)
        {
         

            MainMenu();
        }
        public static void MainMenu()
        {
            bool isTrue = true;
            while (isTrue == true)
            {
                Console.WriteLine("Loan Book - Menu");
                Console.WriteLine();
                Console.WriteLine("1. Loan Menu");   
                Console.WriteLine("2. Person Menu");
                Console.WriteLine("3. Book Menu");
                Console.WriteLine("4. Exit");
                var consoleResult = Console.ReadLine();
                int result = int.Parse(consoleResult);
                switch (result)
                {
                    case 1:LoanMenu loanMenu = new LoanMenu();
                        loanMenu.Strart();
                        break;
                    
                    case 2:PersonMenu personMenu = new PersonMenu();
                        personMenu.start();
                        break;
                    case 3: BookMenu bm = new BookMenu();
                        bm.Strat();
                        break;
                    case 4:
                        isTrue = false;
                        break;
                }
            }
        }
    

    }
}
