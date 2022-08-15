namespace PublisherAndSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ActOnSalaryPayment();
            employee.SalaryRecieved();
        }
    }
}