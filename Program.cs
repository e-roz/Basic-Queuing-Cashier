namespace Basic_Queuing_Cashier
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Create all three forms
            var queuingForm = new QueuingForm();
            var cashierWindow = new CashierWindowQueueForm();
            var customerView = new CustomerView();
            
            // Set up communication between forms
            cashierWindow.SetCustomerView(customerView);
            
            // Show all forms
            queuingForm.Show();
            cashierWindow.Show();
            customerView.Show();
            
            Application.Run(queuingForm);
        }
    }
}