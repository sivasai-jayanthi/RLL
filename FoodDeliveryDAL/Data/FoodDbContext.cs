﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryApplicationUI.Models;

namespace FoodDeliveryDAL.Data
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(): base("FoodDelivery")
        {
            
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role>Roles { get; set; }   
        public DbSet<Cart> Carts { get; set; }

        public DbSet<CustomerModel> CustomerModels { get; set; }
    }

}
