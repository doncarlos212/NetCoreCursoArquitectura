using CursoArquitecturaNet.Application.Interfaces;
using CursoArquitecturaNet.Core.Entities;
using CursoArquitecturaNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoArquitecturaNet.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> Create(Product product)
        {
            await ValidateProductIfExist(product);

            var newEntity = await productRepository.AddAsync(product);
            return newEntity;
        }

        public async Task Delete(Product product)
        {
            ValidateProductIfNotExist(product);
            var deletedProduct = await productRepository.GetByIdAsync(product.Id);
            if (deletedProduct == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await productRepository.DeleteAsync(deletedProduct);
        }    

        public async Task<Product> GetProductById(int productId)
        {
            var product = await productRepository.GetByIdAsync(productId);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductByName(string productName)
        {
            var productList = await productRepository.GetProductByNameAsync(productName);
            return productList;
        }

        public async Task<IEnumerable<Product>> GetProductList()
        {
            var producList = await productRepository.GetAllAsync();
            return producList;
        }

        public async Task Update(Product product)
        {
            ValidateProductIfNotExist(product);

            var editProduct = await productRepository.GetByIdAsync(product.Id);
            if (editProduct == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await productRepository.UpdateAsync(editProduct);
        }

        private async Task ValidateProductIfExist(Product product)
        {
            var existingEntity = await productRepository.GetByIdAsync(product.Id);
            if (existingEntity != null)
                throw new ApplicationException($"{product.ToString()} with this id already exists");
        }

        private void ValidateProductIfNotExist(Product product)
        {
            var existingEntity = productRepository.GetByIdAsync(product.Id);
            if (existingEntity == null)
                throw new ApplicationException($"{product.ToString()} with this id is not exists");
        }
    }
}
