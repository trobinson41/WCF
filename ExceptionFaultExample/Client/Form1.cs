using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.localhost;
using System.ServiceModel;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ExceptionDemoServiceClient proxy;
        private void btnCreateNewProxyInstance_Click(object sender, EventArgs e)
        {
            proxy = new ExceptionDemoServiceClient();
            MessageBox.Show("New Instance is created");
        }

        private void btnThrowException_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.ThrowException();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.GetType() + "\nMessage: " + ex.Message + "\nCode Name: " + ex.Code.Name);
            }
        }

        private void btnThrowExceptionOneWay_Click(object sender, EventArgs e)
        {
            proxy.ThrowExceptionOneWay();            
        }

        private void btnThrowSimpleFault_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.ThrowSimpleFault();
            }
            catch (FaultException ex)
            {                
                MessageBox.Show(ex.GetType() + "\nMessage: " + ex.Message + "\nCode Name: " + ex.Code.Name);
            }
        }
        
        private void btnCultureFault_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.ThrowCultureSpecificFault();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.GetType() + "\n" + ex.Message);
            }
        }

        private void btnStronglyTypedFault_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.ThrowStronglyTypedFault();
            }
            catch (FaultException<DemoException> ex)
            {
                DemoException de = ex.Detail;
                MessageBox.Show(de.GetType() + "\n" + de.Message + " " + de.Value);
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.GetType() + "\nMessage: " + ex.Message + "\nCode Name: " + ex.Code.Name);
            }
        }
        
        private void btnIsProxyAlive_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.Foo();
                MessageBox.Show("Proxy is alive");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + "\n" + ex.Message);
            }
        }

    }
}
