﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VDWWorkEntities : DbContext
    {
        public VDWWorkEntities()
            : base("name=VDWWorkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Telederm_Condition> Telederm_Condition { get; set; }
        public DbSet<Telederm_Consult> Telederm_Consult { get; set; }
        public DbSet<Telederm_ConsultXCondition> Telederm_ConsultXCondition { get; set; }
        public DbSet<Telederm_DifferentialDiagnosis> Telederm_DifferentialDiagnosis { get; set; }
        public DbSet<Telederm_PathologyReport> Telederm_PathologyReport { get; set; }
        public DbSet<Telederm_PathologyReportRaw> Telederm_PathologyReportRaw { get; set; }
        public DbSet<Telederm_Patient> Telederm_Patient { get; set; }
        public DbSet<Telederm_PatientAddress> Telederm_PatientAddress { get; set; }
        public DbSet<Telederm_TreatmentRequest> Telederm_TreatmentRequest { get; set; }
        public DbSet<Consult> Consults { get; set; }
        public DbSet<SPatient> SPatients { get; set; }
    }
}