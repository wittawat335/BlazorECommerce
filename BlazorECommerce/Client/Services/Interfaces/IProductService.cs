using BlazorECommerce.Shared.DTO;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Services.Interfaces
{
    public interface IProductService
    {
        public Task<ServiceDTO?> Add(Product product);
        public Task<ServiceDTO?> GetList();
        public Task<ServiceDTO?> GetById(int id);
    }
}
