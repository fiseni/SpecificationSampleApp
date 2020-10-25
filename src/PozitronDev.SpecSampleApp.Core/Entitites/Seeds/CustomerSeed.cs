using PozitronDev.SpecSampleApp.Core.Entitites.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace PozitronDev.SpecSampleApp.Core.Entitites.Seeds
{
    public static class CustomerSeed
    {
        public static List<Customer> Seed()
        {
            var customer1 = new Customer("Customer1", "Email1@local", "Customer 1 address");
            customer1.AddStore(new Store("Store1-1", "Store 1-1 address"));
            customer1.AddStore(new Store("Store1-2", "Store 1-2 address"));

            var customer2 = new Customer("Customer2", "Email2@local", "Customer 2 address");
            customer2.AddStore(new Store("Store2-1", "Store 2-1 address"));
            customer2.AddStore(new Store("Store2-2", "Store 2-2 address"));

            var customer3 = new Customer("Customer3", "Email3@local", "Customer 3 address");
            customer3.AddStore(new Store("Store3-1", "Store 3-1 address"));
            customer3.AddStore(new Store("Store3-2", "Store 3-2 address"));
            
            var customer4 = new Customer("Customer4", "Email4@local", "Customer 4 address");
            customer4.AddStore(new Store("Store4-1", "Store 4-1 address"));
            customer4.AddStore(new Store("Store4-2", "Store 4-2 address"));

            return new List<Customer>()
            {
                customer1,
                customer2,
                customer3,
                customer4
            };
        }
    }
}
