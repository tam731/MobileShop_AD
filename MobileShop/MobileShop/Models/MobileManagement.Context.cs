﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileShop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopMobileManagementEntities : DbContext
    {
        public ShopMobileManagementEntities()
            : base("name=ShopMobileManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<OderDetail> OderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}