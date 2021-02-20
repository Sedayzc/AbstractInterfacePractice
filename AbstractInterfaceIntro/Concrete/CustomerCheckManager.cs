using AbstractInterfaceIntro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceIntro.Concrete
{
    class CustomerCheckManager
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
