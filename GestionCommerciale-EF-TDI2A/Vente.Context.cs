﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCommerciale_EF_TDI2A
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VenteEntities : DbContext
    {
        public VenteEntities()
            : base("name=VenteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Detail> Details { get; set; }
    }
}
