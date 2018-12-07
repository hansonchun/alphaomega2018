using AlphaOmega.ApplicationCore.Entities.Order;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>(ConfigureOrder);
        }

        private void ConfigureOrder(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
        }
    }
}
