using System.Collections;
using Timer = System.Windows.Forms.Timer;

namespace Basic_Queuing_Cashier
{
    public partial class CashierWindowQueueForm : Form
    {
        private CustomerView? customerView;
        private Timer timer;

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 1 * 1000 // 1 sec.
            };
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void timer1_tick(object? sender, EventArgs e)
        {
            // Automatically refresh the queue display
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void SetCustomerView(CustomerView view)
        {
            customerView = view;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();
                if (CashierClass.CashierQueue.Contains(nextNumber))
                {
                    CashierClass.CashierQueue.Dequeue();
                    DisplayCashierQueue(CashierClass.CashierQueue);

                    // Update CustomerView 
                    if (customerView != null)
                    {
                        customerView.UpdateNowServing(nextNumber);
                    }
                }
            }
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
    }
}
