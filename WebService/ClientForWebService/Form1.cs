﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransferUID_Click(object sender, EventArgs e)
        {
            string UID = txtUID.Text;
            float amount = float.Parse( txtAmountUID.Text);
            float pricePage = (float)0.10;

            ServiceReference1.IService1 client = new ServiceReference1.Service1Client();

            var person = client.AddAmount(UID, amount);
            txtResUID.Text = person.UID;
            txtResUsername.Text = person.username;
            txtResOldAmount.Text = (person.quota-(double)amount).ToString();
            txtResNewAmount.Text = person.quota.ToString();
            txtResQuota.Text = ((int)(person.quota/pricePage)).ToString();
        }

        private void btnTransferUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
