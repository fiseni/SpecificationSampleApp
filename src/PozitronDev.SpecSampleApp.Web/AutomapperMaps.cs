using AutoMapper;
using PozitronDev.SpecSampleApp.Core.Entitites.CustomerAggregate;
using PozitronDev.SpecSampleApp.Core.ValueObjects;
using PozitronDev.SpecSampleApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PozitronDev.SpecSampleApp.Web
{
    public class AutomapperMaps : Profile
    {
        public AutomapperMaps()
        {
            CreateMap<Customer, CustomerUiModel>();
            CreateMap<Store, StoreUiModel>();
            CreateMap<CustomerFilterUiModel, CustomerFilter>().ReverseMap();
        }
    }
}
