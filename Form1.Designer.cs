namespace BankAccountRegisterGUI
{
    partial class FrmBankRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblOriginalDeposit = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOriginalDeposit = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblOriginalDeposit
            // 
            this.lblOriginalDeposit.AutoSize = true;
            this.lblOriginalDeposit.Location = new System.Drawing.Point(28, 146);
            this.lblOriginalDeposit.Name = "lblOriginalDeposit";
            this.lblOriginalDeposit.Size = new System.Drawing.Size(109, 17);
            this.lblOriginalDeposit.TabIndex = 1;
            this.lblOriginalDeposit.Text = "Original Deposit";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtOriginalDeposit
            // 
            this.txtOriginalDeposit.Location = new System.Drawing.Point(230, 146);
            this.txtOriginalDeposit.Name = "txtOriginalDeposit";
            this.txtOriginalDeposit.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalDeposit.TabIndex = 3;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(28, 316);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(134, 80);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create \r\nAccount";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(28, 90);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(85, 17);
            this.lblAccountNo.TabIndex = 5;
            this.lblAccountNo.Text = "Account No:";
            this.lblAccountNo.Visible = false;
            this.lblAccountNo.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(173, 90);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(157, 22);
            this.txtAccountNo.TabIndex = 6;
            this.txtAccountNo.Visible = false;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            this.txtAccountNo.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(28, 185);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(56, 17);
            this.lblDeposit.TabIndex = 7;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.Visible = false;
            this.lblDeposit.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            this.lblDeposit.Click += new System.EventHandler(this.lblDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(28, 218);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 22);
            this.txtDeposit.TabIndex = 8;
            this.txtDeposit.Visible = false;
            this.txtDeposit.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(230, 185);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(66, 17);
            this.lblWithdraw.TabIndex = 9;
            this.lblWithdraw.Text = "Withdraw";
            this.lblWithdraw.Visible = false;
            this.lblWithdraw.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(233, 218);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(100, 22);
            this.txtWithdraw.TabIndex = 10;
            this.txtWithdraw.Visible = false;
            this.txtWithdraw.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(230, 316);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(134, 80);
            this.btnUpdateAccount.TabIndex = 11;
            this.btnUpdateAccount.Text = "Update\r\nAccount";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Visible = false;
            this.btnUpdateAccount.VisibleChanged += new System.EventHandler(this.btnCreateAccount_Click);
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // FrmBankRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 417);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtOriginalDeposit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOriginalDeposit);
            this.Controls.Add(this.lblName);
            this.Name = "FrmBankRegister";
            this.Text = "Banking Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOriginalDeposit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOriginalDeposit;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Button btnUpdateAccount;
    }
}

