﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StadisticJCE.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JCEEntities : DbContext
    {
        public JCEEntities()
            : base("name=JCEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBM_Ciudadanos> TBM_Ciudadanos { get; set; }
        public virtual DbSet<TBM_Estatus> TBM_Estatus { get; set; }
        public virtual DbSet<TBM_Profesion> TBM_Profesion { get; set; }
        public virtual DbSet<TBM_Provincia> TBM_Provincia { get; set; }
    }
}
