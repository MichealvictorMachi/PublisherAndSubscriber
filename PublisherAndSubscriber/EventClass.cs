using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherAndSubscriber
{
        /// 
        /// PUBLISHER CLASS
        /// 
    internal class Bank
    {
                //DELEGATE CREATED TO NOTIFY CUSTOMER
        public delegate void NotifyCustomer();
                //EVENT CREATED
        public event NotifyCustomer NotifyOtherClasses;
       
                // EVENT RAISED
        protected virtual void OnSalaryPayment()
        {
            NotifyOtherClasses?.Invoke();
        }
            //SALARY PAYMENT DETECTION ACTION
        public void SalaryPayment()
        {
            Console.WriteLine("Salary payment in progress");
            System.Threading.Thread.Sleep(10000);
            OnSalaryPayment();

        }
    }
        /// 
        /// SUBSCRIBER CLASS
        /// 
    public class Employee   
    {
        public void ActOnSalaryPayment()
        {
            var Bk = new Bank();
            Bk.NotifyOtherClasses += SalaryPaymentPlans;
            Bk.NotifyOtherClasses += () => Console.WriteLine("send a mail or text message");
            Bk.SalaryPayment();
            
        }

        public void SalaryPaymentPlans()
        {
            Console.WriteLine("send a mail or text message");
            System.Threading.Thread.Sleep(10000);
            
        }
        public void SalaryRecieved()
        {
            Console.WriteLine("make withdrawals");
            Console.ReadLine();
        }

    }
}
