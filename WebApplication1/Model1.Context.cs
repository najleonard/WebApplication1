﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class trackerwebdbEntities : DbContext
    {
        public trackerwebdbEntities()
            : base("name=trackerwebdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<dept> depts { get; set; }
        public virtual DbSet<file> files { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<ItemOrder> ItemOrders { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<site> sites { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<todo> todoes { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<InventoryView> InventoryViews { get; set; }
        public virtual DbSet<LLInventoryView> LLInventoryViews { get; set; }
        public virtual DbSet<LLInventoryView2> LLInventoryView2 { get; set; }
        public virtual DbSet<LLInventoryView3> LLInventoryView3 { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
