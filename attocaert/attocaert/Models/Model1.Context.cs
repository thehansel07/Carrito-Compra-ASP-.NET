﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace attocaert.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_ecommerceEntities1 : DbContext
    {
        public db_ecommerceEntities1()
            : base("name=db_ecommerceEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_invoice> tbl_invoice { get; set; }
        public DbSet<tbl_order> tbl_order { get; set; }
        public DbSet<tbl_product> tbl_product { get; set; }
        public DbSet<tbl_user> tbl_user { get; set; }
    }
}