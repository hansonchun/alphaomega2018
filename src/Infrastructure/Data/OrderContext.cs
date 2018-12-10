using AlphaOmega.ApplicationCore.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Buyer> Buyers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>(ConfigureOrder);
            builder.Entity<Buyer>(ConfigureBuyer);
        }

        private void ConfigureOrder(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
        }

        private void ConfigureBuyer(EntityTypeBuilder<Buyer> builder)
        {
            builder.ToTable("Buyers");
        }
    }
}
