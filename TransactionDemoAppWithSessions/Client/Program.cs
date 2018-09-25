using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                localhost.AccoutServiceClient proxy = new Client.localhost.AccoutServiceClient();
                proxy.Deposit(1, 500);
                proxy.Withdraw(2);
                Console.WriteLine(proxy.GetCounter().ToString());
                proxy.Close();
                ts.Complete();
            }
            Console.ReadKey();
        }

    }
}
