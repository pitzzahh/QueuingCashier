using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private readonly CashierClass _cashier;
        public QueuingForm()
        {
            InitializeComponent();
            _cashier = new CashierClass();
            new CashierWindowQueueForm().Show(this);
            new CustomerView().Show(this);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = _cashier.CashierGenerateNumber("P - ");
            CashierClass.GetNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.GetNumberInQueue);
        }
    }

    internal class CashierClass
    {
        private int _x;
        public static string GetNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            _x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGenerateNumber(string cashierNumber)
        {
            _x++;
            cashierNumber += _x;
            return cashierNumber;
        }
    }
}
