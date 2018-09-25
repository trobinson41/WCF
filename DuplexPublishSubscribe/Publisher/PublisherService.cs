// © 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Windows.Forms;


namespace Publisher
{
    
    [ServiceContract(Namespace="http://www.deccansoft.com/", CallbackContract=typeof(IPublisherEvents))]
    public interface IPublisherService
    {
        [OperationContract]
        void Subscribe(Guid id);

        [OperationContract]
        void Unsubscribe(Guid id);
    }
    
    //For client to Implement
    public interface IPublisherEvents
    {
        [OperationContract(IsOneWay=true)]
        void Notify(Guid id, DateTime time);
    }


    [ServiceBehavior]
    public class PublisherService: IPublisherService
    {
        public void Subscribe(Guid id)
        {
            IPublisherEvents callback = OperationContext.Current.GetCallbackChannel<IPublisherEvents>();
            PublisherForm f = Application.OpenForms[0] as PublisherForm;
            f.AddSubscriber(id, callback);
        }
        public void Unsubscribe(Guid id)
        {
            IPublisherEvents callback = OperationContext.Current.GetCallbackChannel<IPublisherEvents>();
            PublisherForm f = Application.OpenForms[0] as PublisherForm;
            f.RemoveSubscriber(id, callback);
        }
    }

}
