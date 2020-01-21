using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountRegisterGUI
{
   public class Account
    {


        //Declare variables / Data members

        private string customerName;
        private string acctNumber;
       
        private double balance;

        //declare properties

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string AcctNumber
        {
            get
            {
                return acctNumber;
            }
            set
            {
                acctNumber = value;
            }
        }

       
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }


        //Constructors
        public Account()
        {
            //default constructor
        }

        //Second constructor
        public void myAccount(string name, string number,  double bal)
        {
            customerName = name;
            acctNumber = number;
            
            balance = bal;
        }



        //Instance methods


        public void Deposit(double depositAmt)
        {
            balance += depositAmt;
        }

        public void Withdraw(double withdrawAmt)
        {
            if (withdrawAmt > balance)
            {
                MessageBox.Show("You do not have enough balance");
                
            }
            else if (withdrawAmt == balance)
            {
                MessageBox.Show("You balance is zero");
                balance -= withdrawAmt;
            }
            else

            {

                //withdraw money
                balance -= withdrawAmt;
            }

        }
        public double CheckBalance()
        {
            return balance;
        }

        //Override the ToString() method

        public override string ToString()
        {
            return "-------------------------------------" +
            "\n--       Account Information       --" +
            "\n -------------------------------------" +
            "\n--  Customer Name  : " + customerName + "     --" +
            "\n--  Account Number : " + acctNumber + "     --" +
            
            "\n--  Account Balance: " + CheckBalance().ToString("C") + "     --" +
            "\n-------------------------------------";
        }



    }//End of Class
}//End of namespace
