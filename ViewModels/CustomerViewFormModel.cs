using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidyl.Models;

namespace Vidyl.ViewModels
{
    public class CustomerViewFormModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}