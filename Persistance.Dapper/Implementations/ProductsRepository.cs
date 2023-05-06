using Dapper;
using Domain.ComplexModels;
using Domain.Services;
using Persistance.Dapper.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Dapper.Implementations
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly EshopContext _db;
        public ProductsRepository(EshopContext db)
        {
            this._db = db;
        }

        public async Task<List<Products_ApiModel>> GetProducts()
        {
            try
            {
                var connection = this._db.CreateConnection();
                var products = (await connection.QueryAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products]")).ToList();
                for (int i = 0; i < products.Count; i++)
                {
                    products[i].Images = (await connection.QueryAsync<Product_Images_ApiModel>("SELECT [Id] ,[Original] ,[Thumbnail] FROM [dbo].[Product_Images] WHERE [Product_Id] = @ProductID", new
                    {
                        ProductID = products[i].Id
                    })).ToList();
                }
                return products;
            }
            catch (Exception)
            {
                return new List<Products_ApiModel>();
            }
        }
        public async Task<Products_ApiModel> GetProduct(long Id)
        {
            try
            {
                var connection = this._db.CreateConnection();
                var product = await connection.QueryFirstOrDefaultAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Id] = @Id", new { Id = Id });
                if (product != null)
                {
                    product.Images = (await connection.QueryAsync<Product_Images_ApiModel>("SELECT [Id] ,[Original] ,[Thumbnail] FROM [dbo].[Product_Images] WHERE [Product_Id] = @ProductID", new
                    {
                        ProductID = Id
                    })).ToList();
                }
                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Products_ApiModel>> GetSearchedProducts(string textToSearch)
        {
            try
            {
                var connection = this._db.CreateConnection();
                var products = (await connection.QueryAsync<Products_ApiModel>($"SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Name] LIKE N'%{textToSearch}%' OR [Description] LIKE N'%{textToSearch}%'")).ToList();
                for (int i = 0; i < products.Count; i++)
                {
                    products[i].Images = (await connection.QueryAsync<Product_Images_ApiModel>("SELECT [Id] ,[Original] ,[Thumbnail] FROM [dbo].[Product_Images] WHERE [Product_Id] = @ProductID", new
                    {
                        ProductID = products[i].Id
                    })).ToList();
                }
                return products;
            }
            catch (Exception)
            {
                return new List<Products_ApiModel>();
            }
        }

        public async Task<Products_ApiModel> GetProduct(string name)
        {
            try
            {
                var connection = this._db.CreateConnection();
                var product = await connection.QueryFirstOrDefaultAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Name] = @Name", new { Name = name });
                if (product != null)
                {
                    product.Images = (await connection.QueryAsync<Product_Images_ApiModel>("SELECT [Id] ,[Original] ,[Thumbnail] FROM [dbo].[Product_Images] WHERE [Product_Id] = @ProductID", new
                    {
                        ProductID = product.Id
                    })).ToList();
                }
                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Products_ApiModel>> GetProductIncredibleOffers()
        {
            try
            {
                var connection = this._db.CreateConnection();
                return (await connection.QueryAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Incredible_Offers] = @TrueIncredibleOffers", new { TrueIncredibleOffers = true })).ToList();

            }
            catch (Exception)
            {
                return new List<Products_ApiModel>();
            }
        }

        public async Task<List<Products_ApiModel>> GetProductDailySuggests()
        {
            try
            {
                var connection = this._db.CreateConnection();
                return (await connection.QueryAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Daily_Suggest] = @TrueDailySuggest", new { TrueDailySuggest = true })).ToList();

            }
            catch (Exception)
            {
                return new List<Products_ApiModel>();
            }
        }

        public async Task<Products_Categories_ApiModel> GetProductCategory(string categoryName)
        {
            try
            {
                var connection = this._db.CreateConnection();
                var category = await connection.QueryFirstOrDefaultAsync<Products_Categories_ApiModel>($"SELECT * FROM [dbo].[Products_Categories] WHERE [Name] = N'{categoryName}'");
                if (category != null)
                {
                    category.Products = (await connection.QueryAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Category_Id] = @CategoryID", new { CategoryID = category.Id })).ToList();
                }
                return category;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<Products_Categories_ApiModel>> GetProductCategories()
        {
            try
            {
                var connection = this._db.CreateConnection();
                var categories = (await connection.QueryAsync<Products_Categories_ApiModel>("SELECT * FROM [dbo].[Products_Categories]")).ToList();
                for (int i = 0; i < categories.Count; i++)
                {
                    categories[i].Products = (await connection.QueryAsync<Products_ApiModel>("SELECT [Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] WHERE [Category_Id] = @CategoryID", new { CategoryID = categories[i].Id })).ToList();
                }
                return categories;
            }
            catch (Exception)
            {
                return new List<Products_Categories_ApiModel>();
            }
        }

        public async Task<List<Products_ApiModel>> GetProductBySevenIcons(string url)
        {
            try
            {
                var connection = this._db.CreateConnection();
                return (await connection.QueryAsync<Products_ApiModel>($"SELECT product.[Id][Id] ,[Name] ,[Description] ,[Stock] ,[Price] ,[Price_With_Discount][PriceWithDiscount] ,[Incredible_Offers][IncredibleOffers] ,[Daily_Suggest][DailySuggest] ,[Index_Image_Url][IndexImageUrl] FROM [dbo].[Products] product INNER JOIN [dbo].[Suggested_Products] suggest ON product.[Id] = suggest.[Product_Id] INNER JOIN [dbo].[Seven_Icons] sevenicon ON suggest.[SevenIcon_Id] = sevenicon.[Id] WHERE sevenicon.[Url] = N'{url}'")).ToList();
            }
            catch (Exception)
            {
                return new List<Products_ApiModel>();
            }
        }
    }
}
