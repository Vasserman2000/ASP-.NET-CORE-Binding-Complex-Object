using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.ViewModels
{
    public class CompanyViewModel
    {
        public Company Company { get; set; }
        public bool IsActive { get; set; }
    }
}
