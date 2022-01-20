using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Customer_WEBAPI_Assign.Model;

namespace Customer_WEBAPI_Assign.Data
{
    public class Customer_WEBAPI_AssignContext : DbContext
    {
        public Customer_WEBAPI_AssignContext (DbContextOptions<Customer_WEBAPI_AssignContext> options)
            : base(options)
        {
        }

        public DbSet<Customer_WEBAPI_Assign.Model.Customer> Customer { get; set; }
    }
}
