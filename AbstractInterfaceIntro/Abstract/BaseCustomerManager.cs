using AbstractInterfaceIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceIntro.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to database: " + customer.FirstName);
        }
    }
}
