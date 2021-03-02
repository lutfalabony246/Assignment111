using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment111
{
	class Program
	{
		static void Main(string[] args)
		{
			Account account1 = new Account(1001, "Shakib", 10000, new Address("5"," 7", "Chittagong","dhaka"));
			account1.Withdraw();
			account1.Deposit(2);
			account1.Transfer(3);
			
			account1.ShowAccountInformation();

		}
	}
}
