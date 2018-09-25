
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Subscriber.localhost;
using System.ServiceModel;
using System.Threading;

namespace Subscriber
{
    public partial class Form1 : Form, IPublisherServiceCallback
    {

        private localhost.PublisherServiceClient m_proxy = null;

        public Form1()
        {
            InitializeComponent();

            InstanceContext callbackInstance = new InstanceContext(this);
            m_proxy = new localhost.PublisherServiceClient(callbackInstance);

        }

        private Guid m_myGuid = Guid.NewGuid();

        private void cmdSubscribe_Click(object sender, EventArgs e)
        {
            m_proxy.Subscribe(this.m_myGuid);
        }

        private void cmdUnsubscribe_Click(object sender, EventArgs e)
        {
            m_proxy.Unsubscribe(this.m_myGuid);
        }

        //Method in IPublisherServiceCallback
        public void Notify(Guid id, DateTime time)
        {
            MessageBox.Show(string.Format("Hello {0} \nServer Time is {1}",id.ToString(),time.ToLongTimeString()));
        }

    }
}