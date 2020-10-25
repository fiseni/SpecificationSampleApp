using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PozitronDev.SpecSampleApp.Web.Interfaces;
using PozitronDev.SpecSampleApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PozitronDev.SpecSampleApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerUiService customerUiService;

        public CustomersController(ICustomerUiService customerUiService)
        {
            this.customerUiService = customerUiService;
        }

        [HttpGet("{Id}")]
        public async Task<CustomerUiModel> Get(int Id)
        {
            return await customerUiService.GetCustomer(Id);
        }

        [HttpGet("{name}")]
        public async Task<CustomerUiModel> Get(string name)
        {
            return await customerUiService.GetCustomer(name);
        }

        [HttpGet]
        public async Task<List<CustomerUiModel>> Get([FromQuery] CustomerFilterUiModel filter)
        {
            filter = filter ?? new CustomerFilterUiModel();

            // Here you can decide if you want the collections as well

            filter.LoadChildren = true;
            filter.IsPagingEnabled = false;

            return await customerUiService.GetCustomers(filter);
        }
    }
}
