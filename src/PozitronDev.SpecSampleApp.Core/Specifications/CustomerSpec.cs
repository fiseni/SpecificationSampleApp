using PozitronDev.QuerySpecification;
using PozitronDev.SpecSampleApp.Core.Entitites.CustomerAggregate;
using PozitronDev.SpecSampleApp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PozitronDev.SpecSampleApp.Core.Specifications
{
    public class CustomerSpec : Specification<Customer>
    {
        public CustomerSpec(CustomerFilter filter)
        {
            if (filter.IsPagingEnabled)
                Query.Skip(PaginationHelper.CalculateSkip(filter.PageSize, filter.Page))
                     .Take(PaginationHelper.CalculateTake(filter.Page));

            if (!string.IsNullOrEmpty(filter.Name))
                Query.Where(x => x.Name == filter.Name);

            if (!string.IsNullOrEmpty(filter.Email))
                Query.Where(x => x.Email == filter.Email);

            if (!string.IsNullOrEmpty(filter.Address))
                Query.Search(x => x.Address, filter.Address);
        }
    }
}
