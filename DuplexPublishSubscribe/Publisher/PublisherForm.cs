

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Threading;

namespace Publisher
{
    public partial class PublisherForm : Form
    {
        ServiceHost m_host;
        public Dictionary<Guid, IPublisherEvents> m_listCallbacks = new Dictionary<Guid, IPublisherEvents>();

        public PublisherForm()
        {
            InitializeComponent();

            m_host = new ServiceHost(typeof(PublisherService));
            m_host.Open();
        }
         
        public void AddSubscriber(Guid id, IPublisherEvents subscriber)
        {
            if (!m_listCallbacks.ContainsKey(id))
            {
                m_listCallbacks.Add(id, subscriber);
                lstSubscribers.Items.Add(id);
            }
        }
        
        public void RemoveSubscriber(Guid id, IPublisherEvents subscriber)
        {
            if (m_listCallbacks.ContainsKey(id))
            {
                m_listCallbacks.Remove(id);
                this.lstSubscribers.Items.Remove(id);
            }
        }

        private void PublisherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_host.Close();
        }

        private void cmdNotifyAll_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Guid, IPublisherEvents> obj in this.m_listCallbacks)
            {
                obj.Value.Notify(obj.Key, DateTime.Now);
            }
        }
    }
}