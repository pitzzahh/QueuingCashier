using System;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CustomerView : Form
    {
        private string _currentNumber;
        public CustomerView()
        {
            InitializeComponent();
            var timer  = new Timer();
            timer.Interval = 2000;
            timer.Tick += (sender, args) =>
            {
                lblServingNumber.Text = _currentNumber;
                try
                {
                    _currentNumber = CashierClass.CashierQueue.Peek();
                }
                catch (Exception)
                {
                    // ignored
                }
            };
            timer.Start();
        }
    }
}