﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {
        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<ECommerce.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Tax> Taxes { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Warehouse> Warehouses { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Inventory> Inventories { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.State> States { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.OrderDetailTmp> OrderDetailTmps { get; set; }

    }
}