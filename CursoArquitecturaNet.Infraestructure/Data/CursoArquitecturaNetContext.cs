using CursoArquitecturaNet.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoArquitecturaNet.Infraestructure.Data
{
    public class CursoArquitecturaNetContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Product>(ConfigureProduct);
        //    builder.Entity<Category>(ConfigureCategory);
        //}

        //private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        //{
        //    builder.ToTable("Product");

        //    builder.HasKey(ci => ci.Id);

        //    builder.Property(cb => cb.ProductName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //}

        //private void ConfigureCategory(EntityTypeBuilder<Category> builder)
        //{
        //    builder.ToTable("Category");

        //    builder.HasKey(ci => ci.Id);

        //    builder.Property(cb => cb.CategoryName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //}
    }
}
