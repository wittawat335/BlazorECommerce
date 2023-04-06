using BlazorECommerce.Shared.DTO;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Server.Repositories.Interfaces
{
    public interface IProductRepo
    {
        public Task<ServiceDTO> Add(Product model);
        public Task<ServiceDTO> GetList();
        public Task<ServiceDTO> GetById(int id);
    }
}
