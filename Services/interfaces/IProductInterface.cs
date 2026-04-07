
using Services.DTOs;
using Services.Requests;

namespace Services.interfaces
{
    public interface IProductInterface
    {

        Task<ProductDTO> CreateAsync(ProductRequest request);

    }
}
