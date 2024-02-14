using customer_management_system_for_coffee_shops.Abstract;
using customer_management_system_for_coffee_shops.Adapters;
using customer_management_system_for_coffee_shops.Concrete;
using customer_management_system_for_coffee_shops.Entities;
using System;

namespace customer_management_system_for_coffee_shops
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2002, 8, 9),
                FirstName = "Mustafa Önder",
                LastName = "Ünlü",
                NationalityId = "19373243068"
            });


            Console.ReadLine();
        }
    }

    
}
