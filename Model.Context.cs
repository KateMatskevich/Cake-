﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cake
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CakeEntities : DbContext
    {
        public CakeEntities()
            : base("name=CakeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Berries> Berries { get; set; }
        public virtual DbSet<Biscuit> Biscuit { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cream> Cream { get; set; }
        public virtual DbSet<Custom_cake> Custom_cake { get; set; }
        public virtual DbSet<Decoration> Decoration { get; set; }
        public virtual DbSet<Nuts> Nuts { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_cake> Order_cake { get; set; }
        public virtual DbSet<Order_status> Order_status { get; set; }
        public virtual DbSet<Promotional_code> Promotional_code { get; set; }
        public virtual DbSet<dt_user> User { get; set; }
    }
}
