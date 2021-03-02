using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment111
{
	class Account
	{
		private int accountNumber;
		private string accountName;
		private double balance;
		private Address address;
		



		public Account(int accountNumber, string accountName, double balance, Address address)
		{
			this.accountNumber = accountNumber;
			this.accountName = accountName;
			this.balance = balance;
			this.address = address;
		}
		public int AccountNumber
		{
			set { this.accountNumber = value; }
			get { return this.accountNumber; }
		}

		public string AccountName
		{
			get { return this.accountName; }
			set { this.accountName = value; }
		}
		public double Balance
		{
			get { return this.balance; }
			set { this.balance = value; }
		}
		public Address Address
		{
			get { return this.address; }
			set { this.address = value; }
		}
		public void PrintAccount()
		{
			//Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
			Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
			this.address.PrintAddress();
		}
		public void Withdraw()
		{
			//while (chances >= 0)
			//{ 
		 

		Console.WriteLine("Please Enter 1 for your Withdraw\n");
			Console.WriteLine("Please Enter 2 for your Deposit\n");
			Console.WriteLine("Please Enter 3 for your Transfer");
			int options = Convert.ToInt32(Console.ReadLine());

			Console.ReadKey();
			if (options == 1)
			{
				Console.WriteLine("How much would you like to withdraw?");
				double amount=Convert.ToDouble(Console.ReadLine());
				//Console.ReadKey();
				if (amount<=6000.00) 
				{
					balance -= amount;
					Console.WriteLine("your balance is" + balance);
				}
				else
				{
					Console.WriteLine("SORRY!! ");

				}
			}


			// }
		}

		public void Deposit(int options)
		{
			if (options == 2)
			{
				Console.WriteLine("How much would you like to deposit?");
				double amount = Convert.ToDouble(Console.ReadLine());
				balance += amount;
				Console.WriteLine("your balance is" + balance);
			}
		}
		public void Transfer(int options)
		{
			if (options == 3)
			{
				Console.WriteLine("How much would you like to transfer?");
				Console.WriteLine("In Which account you want to transfer?");
				double amount = Convert.ToDouble(Console.ReadLine());
				balance -= amount;
			}
		}
		public void ShowAccountInformation()
		{
			Console.WriteLine("Account Information");

			PrintAccount();
		}
	}
}
