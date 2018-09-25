using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BusinessObjects
{
    // NOTE: If you change the interface name "IExceptionDemoService" here, you must also update the reference to "IExceptionDemoService" in App.config.
    [ServiceContract]
    public interface IExceptionDemoService
    {
        [OperationContract]
        void ThrowException();
        
        [OperationContract(IsOneWay=true)]
        void ThrowExceptionOneWay();

        [OperationContract()]
        void ThrowSimpleFault();
        
        [OperationContract()]
        [FaultContract(typeof(DemoException))]
        void ThrowStronglyTypedFault();
        
        [OperationContract()]
        void ThrowCultureSpecificFault();
        
        [OperationContract]
        void Foo();
    }
}
