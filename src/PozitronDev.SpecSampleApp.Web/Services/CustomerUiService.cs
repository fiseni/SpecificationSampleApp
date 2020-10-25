using AutoMapper;
using PozitronDev.SpecSampleApp.Core.Entitites.CustomerAggregate;
using PozitronDev.SpecSampleApp.Core.Interfaces;
using PozitronDev.SpecSampleApp.Core.Specifications;
using PozitronDev.SpecSampleApp.Core.ValueObjects;
using PozitronDev.SpecSampleApp.Web.Interfaces;
using PozitronDev.SpecSampleApp.Web.Models;
using PozitronDev.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PozitronDev.SpecSampleApp.Web.Services
{
    public class CustomerUiService : ICustomerUiService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Customer> customerRepository;

        public CustomerUiService(IMapper mapper, IRepository<Customer> customerRepository)
        {
            this.mapper = mapper;
            this.customerRepository = customerRepository;
        }


        // Here I'm just writing various usages, not necessarilly you'll need all of them.

        public async Task<CustomerUiModel> GetCustomer(int customerId)
        {
            var customer = await customerRepository.GetByIdAsync(customerId);

            customer.ValidateFor().NotFound(customerId);

            return mapper.Map<CustomerUiModel>(customer);
        }

        public async Task<CustomerUiModel> GetCustomer(string customerName)
        {
            var customer = await customerRepository.GetBySpecAsync(new CustomerByNameSpec(customerName));

            customer.ValidateFor().NotFound(customerName);

            return mapper.Map<CustomerUiModel>(customer);
        }

        public async Task<CustomerUiModel> GetCustomerWithStores(string customerName)
        {
            var customer = await customerRepository.GetBySpecAsync(new CustomerByNameWithStoresSpec(customerName));

            customer.ValidateFor().NotFound(customerName);

            return mapper.Map<CustomerUiModel>(customer);
        }

        public async Task<List<CustomerUiModel>> GetCustomers(CustomerFilterUiModel filterUiModel)
        {
            var spec = new CustomerSpec(mapper.Map<CustomerFilter>(filterUiModel));
            var customer = await customerRepository.ListAsync(spec);

            return mapper.Map<List<CustomerUiModel>>(customer);
        }
    }
}
