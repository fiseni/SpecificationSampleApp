using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PozitronDev.SpecSampleApp.Web.Models
{
    public class CustomerUiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<StoreUiModel> Stores { get; set; } = new List<StoreUiModel>();
    }
}
