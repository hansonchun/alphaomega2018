using AlphaOmega.ApplicationCore.Entities.BuyerAggregate;
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

        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Buyer>(ConfigureBuyer);
            builder.Entity<Order>(ConfigureOrder);
        }

        private void ConfigureBuyer(EntityTypeBuilder<Buyer> builder)
        {
            builder.ToTable("buyers");
            builder.OwnsOne(b => b.ShippingAddress);
            builder.OwnsOne(b => b.BillingAddress);
        }

        private void ConfigureOrder(EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(o => o.OrderItems)
                .WithOne(i => i.Order)
                .HasForeignKey(o => o.OrderId);
        }

    }
}
