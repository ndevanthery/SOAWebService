using System;
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

            PrinterService.MS_SQLClient client = new PrinterService.MS_SQLClient();

            float newAmount = client.AddAmount(UID,amount);

            txtResUID.Text = UID;
            txtResUsername.Text = "TO DEVELOP";
            txtResOldAmount.Text = "TO DEVELOP";
            txtResNewAmount.Text = newAmount.ToString();
            txtResQuota.Text = (newAmount/pricePage).ToString();
        }

        private void btnTransferUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
