using AbstractInterfaceIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceIntro.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
