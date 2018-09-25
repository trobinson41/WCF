using System;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace WCFLibrary
{
    [ServiceContract (CallbackContract = typeof(ICallbackService))]
    public interface IDemoService
    {
        [OperationContract(IsOneWay = true)]
        void SendEmailAndNotifyCompletion(string name,string toEmailId,string body);
    }

    public interface ICallbackService
    {
        [OperationContract(IsOneWay = true)]
        void OperationCompleted(string message);
    }

}
