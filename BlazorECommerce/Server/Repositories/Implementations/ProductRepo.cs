using Azure;
using BlazorECommerce.Server.Repositories.Interfaces;
using BlazorECommerce.Shared.DBContext;
using BlazorECommerce.Shared.DTO;
using BlazorECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Server.Repositories.Implementations
{
    public class ProductRepo : IProductRepo
    {
        public readonly EcommerceDBContext _dbContext;

        public ProductRepo(EcommerceDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceDTO> Add(Product model)
        {
            var response = new ServiceDTO();
            if (model != null)
            {
                try
                {
                    _dbContext.Products.Add(model);
                    await _dbContext.SaveChangesAsync();
                    response.SingleProduct = model;
                    response.Success = true;
                    response.Message = model.Name + "added successfully!";
                    response.CssClass = "success";
                }
                catch (Exception ex)
                {
                    response.CssClass = "danger";
                    response.Message = ex.Message.ToString();
                }
            }
            else
            {
                response.Success = false;
                response.Message = "Sorry New" + model!.Name + "object is empty!";
                response.CssClass = "warning";
                response.SingleProduct = null!;
            }
            return response;
        }

        public async Task<ServiceDTO> GetList()
        {
            var response = new ServiceDTO();
            try
            {
                var list = await _dbContext.Products.ToListAsync();
                if (list != null)
                {
                    response.ProductList = list;
                    response.Success = true;
                    response.Message = "Products found!";
                    response.CssClass = "success";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Sorry No products found!";
                    response.CssClass = "info";
                    response.ProductList = null!;
                }

            }
            catch (Exception ex)
            {
                response.CssClass = "danger";
                response.Message = ex.Message.ToString();
            }
            return response;
        }

        public async Task<ServiceDTO> GetById(int id)
        {
            var response = new ServiceDTO();
            if (id > 0)
            {
                try
                {
                    var product = await _dbContext.Products.SingleOrDefaultAsync(x => x.Id == id);
                }
                catch(Exception ex)
                {
                    response.CssClass = "danger";
                    response.Message = ex.Message.ToString();
                }
            }
            else
            {
                response.Success = false;
                response.Message = "object is empty!";
                response.CssClass = "warning";
                response.SingleProduct = null!;
            }
            return response;
        }
    }
}
