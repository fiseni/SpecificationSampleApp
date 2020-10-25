using PozitronDev.SpecSampleApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PozitronDev.SpecSampleApp.Web.Interfaces
{
    public interface ICustomerUiService
    {
        Task<CustomerUiModel> GetCustomer(int customerId);
        Task<CustomerUiModel> GetCustomer(string customerName);
        Task<CustomerUiModel> GetCustomerWithStores(string customerName);

        Task<List<CustomerUiModel>> GetCustomers(CustomerFilterUiModel filterUiModel);
    }
}
