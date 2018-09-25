using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        localhost.MathServiceClient ms = new localhost.MathServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text = ms.Add(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtResult.Text = ms.Sub(int.Parse(txtN1.Text), int.Parse(txtN2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ms.ClientStarted(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ms.ClientStopped(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
        }
    }
}
