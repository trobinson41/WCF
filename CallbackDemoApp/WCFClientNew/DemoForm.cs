using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WCFClientNew.localhost;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace WCFClientNew
{
    public partial class DemoForm : Form, localhost.IDemoServiceCallback
    {
        public DemoForm()
        {
            InitializeComponent();
        }
        DemoServiceClient proxy;
        private void DemoForm_Load(object sender, EventArgs e)
        {
            InstanceContext ic;
            ic = new InstanceContext(this);
            proxy = new DemoServiceClient(ic);
        }

        public void OperationCompleted(string message)
        {
           MessageBox.Show(message);
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;            
            proxy.SendEmailAndNotifyCompletion(name,txtToEmailId.Text, txtEmailBody.Text);
            txtToEmailId.Text = "";
            txtEmailBody.Text = "";
        }
    }
}
