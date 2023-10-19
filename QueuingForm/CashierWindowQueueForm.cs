using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    
        private void DisplayCashierQueue(Queue<string> cashierQueue)
        {
            listCashierQueue.Items.Clear();
            foreach (var queue in cashierQueue)
            {
                listCashierQueue.Items.Add(queue);
            }
        }
    }
}