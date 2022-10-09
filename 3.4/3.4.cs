using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboop3.4
{
    internal class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private double PDW = 0.2;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double CalculateValueOrder()
        {
            int choose = 0;
            Console.Write("0 без ПДВ, 1 з ПДВ:");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    return account;
                case 1:
                    return (account * PDW)+account;
            }
            return 0;
        }
    }
}