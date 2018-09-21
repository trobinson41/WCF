using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMathService" in both code and config file together.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Sub(int a, int b);
    }
}
