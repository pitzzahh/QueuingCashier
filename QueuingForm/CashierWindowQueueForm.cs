using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        private int _listCount;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += btnRefresh_Click;
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _listCount = CashierClass.CashierQueue.Count;
            if (_listCount <= listCashierQueue.Items.Count) return;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            catch (Exception)
            {
                MessageBox.Show(@"No customer in queue");
            }
        }
    }
}