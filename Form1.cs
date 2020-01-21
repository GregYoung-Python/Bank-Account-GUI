using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountRegisterGUI
{
    public partial class FrmBankRegister : Form
    {

       

        Account myAccount = new Account();


        public FrmBankRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }


        private void btnCreateAccount_Click(object sender, EventArgs e)

            
        {
         
           
            double balance;
       


            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is empty! Please re-enter");
                txtName.Clear();
                txtName.Focus();
            }

            else if (double.TryParse(txtOriginalDeposit.Text, out balance) == false)
            {
                MessageBox.Show("Invalid amount! Please re-enter");
                txtOriginalDeposit.Clear();
                txtOriginalDeposit.Focus();
            }
            else
            {


                txtAccountNo.Text = "255568";
                txtWithdraw.Visible = true;
                lblWithdraw.Visible = true;
                lblDeposit.Visible = true;
                txtDeposit.Visible = true;
                btnUpdateAccount.Visible = true;
                lblAccountNo.Visible = true;
                txtAccountNo.Visible = true;
                btnCreateAccount.Visible = false;

                myAccount.CustomerName = txtName.Text;

                myAccount.Balance = balance;


            }



        }






        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            //declare variables


        
            
            double deposit;
            double withdraw;

            //get user input
            
             if (double.TryParse(txtDeposit.Text, out deposit) == false)
            {
                MessageBox.Show("Invalid amount! Please enter valid amount.");
                txtDeposit.Clear();
                txtDeposit.Focus();
            }
            else if (double.TryParse(txtWithdraw.Text, out   withdraw) == false)
            {
                MessageBox.Show("Invalid amount! Please enter valid amount.");
                txtWithdraw.Clear();
                txtWithdraw.Focus();
               

            }
            
             
               
                
             

            else
            {



                myAccount.Deposit(deposit);
                myAccount.Withdraw(withdraw);
                
                txtOriginalDeposit.Text = myAccount.Balance .ToString("c");
                txtDeposit.Clear();
                txtWithdraw.Clear();





            }


        }
    }
}
