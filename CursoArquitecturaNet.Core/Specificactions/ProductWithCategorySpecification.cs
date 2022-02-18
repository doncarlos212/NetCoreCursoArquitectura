using CursoArquitecturaNet.Core.Entities;
using CursoArquitecturaNet.Core.Specificactions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoArquitecturaNet.Core.Specificactions
{
    public class ProductWithCategorySpecification : BaseSpecification<Product>
    {
        public ProductWithCategorySpecification(string productName)
            : base(p => p.ProductName.ToLower().Contains(productName.ToLower()))
        {
            AddInclude(p => p.Category);            
        }

        public ProductWithCategorySpecification() : base(null)
        {
            AddInclude(p => p.Category);
        }
    }
}
