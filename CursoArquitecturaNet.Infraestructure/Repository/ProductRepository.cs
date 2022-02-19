using CursoArquitecturaNet.Core.Entities;
using CursoArquitecturaNet.Core.Repositories;
using CursoArquitecturaNet.Infraestructure.Data;
using CursoArquitecturaNet.Infraestructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoArquitecturaNet.Infraestructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CursoArquitecturaNetContext dbContext) : base(dbContext)
        {
        }   

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
        {
            return await dbContext.Products
                .Where(x => x.ProductName.Contains(productName))              
                .ToListAsync();
        }        
    }
}
