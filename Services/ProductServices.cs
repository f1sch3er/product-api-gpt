
using Services.DTOs;
using Services.interfaces;
using Services.Requests;

namespace Services
{
    public class ProductServices : IProductInterface
    {
        public async Task<ProductDTO> CreateAsync(ProductRequest request)
        {
            return new ProductDTO
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Category = request.Category,
                Stock = request.Stock
            };
        }
    }
}
