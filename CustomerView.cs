namespace Basic_Queuing_Cashier
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        public void UpdateNowServing(string queueNumber)
        {
            lblNowServing.Text = queueNumber;
        }
    }
}
