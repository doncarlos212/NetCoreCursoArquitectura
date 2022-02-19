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

        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId)
        {
            return await dbContext.Products
                 .Where(x => x.CategoryId == categoryId)
                 .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
        {
            return await dbContext.Products
                .Where(x => x.ProductName.Contains(productName))
                .Include(x => x.Category)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductListAsync()
        {
            return await GetAllAsync(); //Ver si necesito los includes.
        }
    }
}
