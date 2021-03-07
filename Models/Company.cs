using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class Company
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public CompanyAddress CompanyAddress { get; set; }
    }
}
