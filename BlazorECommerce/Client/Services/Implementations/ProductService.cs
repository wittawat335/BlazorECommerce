using BlazorECommerce.Client.Services.Interfaces;
using BlazorECommerce.Shared.DTO;
using BlazorECommerce.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceDTO?> Add(Product product)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Product", product);
            return await result.Content.ReadFromJsonAsync<ServiceDTO?>();
        }

        public async Task<ServiceDTO?> GetById(int id)
        {
            var result = await _httpClient.GetAsync($"api/Product/{id}");
            return await result.Content.ReadFromJsonAsync<ServiceDTO>();
        }

        public async Task<ServiceDTO?> GetList()
        {
            var result = await _httpClient.GetAsync("api/Product");
            return await result.Content.ReadFromJsonAsync<ServiceDTO>();
        }
    }
}
