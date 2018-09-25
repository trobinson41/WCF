using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AccountLibrary
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
    [ServiceContract(SessionMode=SessionMode.Required)]
    public interface IAccoutService
    {
        [OperationContract()]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        void Deposit(int accountId, decimal amount);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        void Withdraw(int accountId);

        [OperationContract]
        int GetCounter();
    }

    
}
