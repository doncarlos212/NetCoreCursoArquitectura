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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(CursoArquitecturaNetContext dbContext) : base(dbContext)
        {
        }

        public async Task<Category> GetCategoryWithProductsAsync(int categoryId)
        {
            return await dbContext.Categories
                .Include(x => x.Products)
                .FirstOrDefaultAsync(x => x.Id == categoryId);                
        }
    }
}
