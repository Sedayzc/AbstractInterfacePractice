using AbstractInterfaceIntro.Abstract;
using AbstractInterfaceIntro.Adapters;
using AbstractInterfaceIntro.Concrete;
using AbstractInterfaceIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractInterfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager (new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1994, 11, 5), FirstName = "Seda", LastName = "Yazıcı", NationalityId = "25447713654" });
            Console.ReadLine();
        }
    }
}
