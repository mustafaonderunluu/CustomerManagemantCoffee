using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace customer_management_system_for_coffee_shops.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {

            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                //true dönerse kaydet
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person "); 
            }

        }
    }
}
