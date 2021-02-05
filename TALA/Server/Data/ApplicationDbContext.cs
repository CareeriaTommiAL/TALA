using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALA.Server.Models;
using TALA.Shared;

namespace TALA.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Tehtava> Tehtavat { get; set; }
        public DbSet<Suoritus> Suoritukset { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Suoritus>()
                .HasKey(su => new { su.UserId, su.TehtavaId });

            builder.Entity<Suoritus>()
                .HasOne(su => su.ApplicationUser)
                .WithMany(ss => ss.Suoritukset)
                .HasForeignKey(su => su.UserId);

            builder.Entity<Suoritus>()
                .HasOne(su => su.Tehtavat)
                .WithMany(s => s.Suoritukset)
                .HasForeignKey(su => su.TehtavaId);

            builder.Entity<Suoritus>()
                .Property(sk => sk.Suorituskerrat)
                .HasDefaultValue(0);

        }


    }
}
