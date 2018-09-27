using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                localhost.Service1Client proxy = new localhost.Service1Client();
                int count = 1;
                proxy.SendMessage($"This is {count} message from client.");
                count++;
                proxy.SendMessage($"This is {count} message from client.");
                count++;
                proxy.SendMessage($"This is {count} message from client.");
                count++;
                proxy.SendMessage($"This is {count} message from client.");
                count++;
                proxy.SendMessage($"This is {count} message from client.");

                //ts.Complete();
            }
        }
    }
}
