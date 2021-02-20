using System;
using System.Collections.Generic;
using System.Text;
using AbstractInterfaceIntro.Entities;

namespace AbstractInterfaceIntro.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
