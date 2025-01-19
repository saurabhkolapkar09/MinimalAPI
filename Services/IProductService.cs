using System.Collections.Generic;
using System.Threading.Tasks;
using minimalAPIDemo.Models;
using minimalAPIDemo.Models.DTO;

namespace minimalAPIDemo.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<Product> CreateProductAsync(ProductDto productDto);
        Task<Product?> UpdateProductAsync(int id, ProductDto productDto);
        Task<bool> DeleteProductAsync(int id);
    }
}
