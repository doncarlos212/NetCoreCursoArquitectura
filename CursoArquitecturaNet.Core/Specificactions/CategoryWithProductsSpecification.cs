using CursoArquitecturaNet.Core.Entities;
using CursoArquitecturaNet.Core.Specificactions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoArquitecturaNet.Core.Specificactions
{
    public class CategoryWithProductsSpecification : BaseSpecification<Category>
    {
        public CategoryWithProductsSpecification(int categoryId)
            :base(c => c.Id == categoryId)
        {
            AddInclude(c => c.Products);
        }
    }
}
