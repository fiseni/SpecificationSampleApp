using System;
using System.Collections.Generic;
using System.Text;

namespace PozitronDev.SpecSampleApp.Core.ValueObjects
{
    public class CustomerFilter
    {
        public bool LoadChildren { get; set; }
        public bool IsPagingEnabled { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
