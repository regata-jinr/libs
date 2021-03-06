/***************************************************************************
 *                                                                         *
 *                                                                         *
 * Copyright(c) 2017-2021, REGATA Experiment at FLNP|JINR                  *
 * Author: [Boris Rumyantsev](mailto:bdrum@jinr.ru)                        *
 *                                                                         *
 * The REGATA Experiment team license this file to you under the           *
 * GNU GENERAL PUBLIC LICENSE                                              *
 *                                                                         *
 ***************************************************************************/

using Microsoft.EntityFrameworkCore;
using Regata.Core.DataBase.Models;
using AdysTech.CredentialManager;
using Regata.Core.Settings;

namespace Regata.Core.DataBase
{
    public class RegataContext : DbContext
    {
     // public DbSet<Monitor>              Monitors              { get; set; }
     // public DbSet<MonitorsSet>          MonitorsSets          { get; set; }
     // public DbSet<SRM>                  SRMs                  { get; set; }
     // public DbSet<SRMsSet>              SRMsSets              { get; set; }
     // public DbSet<reweightInfo>         Reweights             { get; set; }

        public DbSet<Sample>               Samples               { get; set; }
        public DbSet<SamplesSet>           SamplesSets           { get; set; }
        public DbSet<Irradiation>          Irradiations          { get; set; }
        public DbSet<Measurement>          Measurements          { get; set; }
        public DbSet<MeasurementsRegister> MeasurementsRegisters { get; set; }
        public DbSet<SharedSpectrum>       SharedSpectra         { get; set; }
        public DbSet<SpectrumSLI>          SLISpectra            { get; set; }
        public DbSet<SpectrumLLI>          LLISpectra            { get; set; }
        public DbSet<UILabel>              UILabels              { get; set; }
        public DbSet<MessageBase>          MessageBases          { get; set; }
        public DbSet<MessageDefault>       MessageDefaults       { get; set; }
        public DbSet<User>                 Users                 { get; set; }
        public DbSet<Log>                  Logs                  { get; set; }

        //private const string DBTarget = "MSSQL_TEST_DB_ConnetionString"; // "RegataDB";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)   
        {
            optionsBuilder.UseSqlServer(CredentialManager.GetCredentials(GlobalSettings.Targets.DB).Password, 
                                        options => 
                                            {
                                                options.EnableRetryOnFailure(3);
                                                options.CommandTimeout(60);
                                            }
                                       );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Irradiation>()
                            .HasKey(i => i.Id);

            modelBuilder.Entity<Measurement>()
                            .HasKey(m => m.Id);

            modelBuilder.Entity<MeasurementsRegister>()
                           .HasKey(mr => mr.Id);

            modelBuilder.Entity<SpectrumLLI>()
                           .HasKey(slis => slis.SampleSpectra);

            modelBuilder.Entity<SpectrumSLI>()
                           .HasKey(llis => llis.SampleSpectra);

            modelBuilder.Entity<SharedSpectrum>()
                           .HasKey(ss => ss.fileS);

            modelBuilder.Entity<UILabel>()
                           .HasKey(l => new { l.FormName, l.ComponentName });

            modelBuilder.Entity<MessageBase>()
                           .HasKey(m => new { m.Code, m.Language});

            modelBuilder.Entity<MessageDefault>()
                           .HasKey(m => new { m.Language });

            modelBuilder.Entity<User>()
                           .HasKey(u => new { u.Id });

            modelBuilder.Entity<Log>()
                           .HasKey(l => new { l.Id });

            modelBuilder.Entity<Sample>()
                               .HasKey(s => new
                               {
                                   s.CountryCode,
                                   s.ClientNumber,
                                   s.Year,
                                   s.SetNumber,
                                   s.SetIndex,
                                   s.SampleNumber
                               });

            modelBuilder.Entity<SamplesSet>()
                               .HasKey(s => new
                               {
                                   s.Country_Code,
                                   s.Client_Id,
                                   s.Year,
                                   s.Sample_Set_Id,
                                   s.Sample_Set_Index
                               });

            #region to be added

            //modelBuilder.Entity<Monitor>()
            //                   .HasKey(s => new
            //                   {
            //                       s.Monitor_Set_Name,
            //                       s.Monitor_Set_Number,
            //                       s.Monitor_Number
            //                   });

            //modelBuilder.Entity<MonitorsSet>()
            //                   .HasKey(s => new
            //                   {
            //                       s.Monitor_Set_Name,
            //                       s.Monitor_Set_Number
            //                   });

            //modelBuilder.Entity<SRM>()
            //                   .HasKey(s => new
            //                   {
            //                       s.SRM_Set_Name,
            //                       s.SRM_Set_Number,
            //                       s.SRM_Number
            //                   });

            //modelBuilder.Entity<SRMsSet>()
            //                   .HasKey(s => new
            //                   {
            //                       s.SRM_Set_Name,
            //                       s.SRM_Set_Number
            //                   });

            //modelBuilder.Entity<reweightInfo>().HasKey(s => new
            //{
            //    s.loadNumber,
            //    s.Country_Code,
            //    s.Client_Id,
            //    s.Year,
            //    s.Sample_Set_Id,
            //    s.Sample_Set_Index,
            //    s.Sample_ID
            //});

            #endregion

        }

    } // public class WeightingContext : DbContext
} // namespace SamplesWeighting
