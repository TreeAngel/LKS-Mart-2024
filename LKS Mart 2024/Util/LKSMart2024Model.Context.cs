﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Mart_2024.Util
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LKSMart2024Entities : DbContext
    {
        public LKSMart2024Entities()
            : base("name=LKSMart2024Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_barang> tbl_barang { get; set; }
        public virtual DbSet<tbl_log> tbl_log { get; set; }
        public virtual DbSet<tbl_pelanggan> tbl_pelanggan { get; set; }
        public virtual DbSet<tbl_transaksi> tbl_transaksi { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }
    }
}
