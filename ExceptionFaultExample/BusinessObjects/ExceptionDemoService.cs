using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BusinessObjects
{
    public class ExceptionDemoService : IExceptionDemoService
    {
        public void Foo()
        { }
        public void ThrowException()
        {
            throw new NotImplementedException();
        }
        public void ThrowExceptionOneWay()
        {
            throw new NotImplementedException();
        }       
        public void ThrowSimpleFault()
        {
            throw new FaultException("This method is not implemented", new FaultCode("NotImplemented"));
        }
        public void ThrowStronglyTypedFault()
        {
            try
            {
                var x = 1;
                var y = 0;
                var z = x/y; 
            }
            catch (Exception e)
            {
                DemoException ex = new DemoException() { Message = e.Message, Value = 1 };
                throw new FaultException<DemoException>(ex);
            }
        }
        public void ThrowCultureSpecificFault()
        {
            List<FaultReasonText> lstReasons = new List<FaultReasonText>();
            lstReasons.Add(new FaultReasonText("This is in english", new System.Globalization.CultureInfo("en-US")));
            lstReasons.Add(new FaultReasonText("This is in french", new System.Globalization.CultureInfo("fr-FR")));
            lstReasons.Add(new FaultReasonText("This is in hindi", new System.Globalization.CultureInfo("hi-IN")));
            FaultReason reason = new FaultReason(lstReasons);
            throw new FaultException(reason, new FaultCode("SomeError"));
        }
    }

    public class DemoException
    {
        public string Message;
        public int Value;
    }
}
