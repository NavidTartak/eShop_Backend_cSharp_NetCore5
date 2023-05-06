using Domain.ComplexModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IProductsRepository
    {
        Task<List<Products_ApiModel>> GetProducts();
        Task<Products_ApiModel> GetProduct(long Id);
        Task<List<Products_ApiModel>> GetSearchedProducts(string textToSearch);
        Task<Products_ApiModel> GetProduct(string name);
        Task<List<Products_ApiModel>> GetProductIncredibleOffers();
        Task<List<Products_ApiModel>> GetProductDailySuggests();
        Task<Products_Categories_ApiModel> GetProductCategory(string categoryName);
        Task<List<Products_Categories_ApiModel>> GetProductCategories();
        Task<List<Products_ApiModel>> GetProductBySevenIcons(string url);


    }
}
