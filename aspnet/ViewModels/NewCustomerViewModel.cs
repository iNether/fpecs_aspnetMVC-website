﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnet.Models;

namespace aspnet.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}