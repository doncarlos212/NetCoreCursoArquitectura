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
    }
}
