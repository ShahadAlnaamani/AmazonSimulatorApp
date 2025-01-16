using AmazonSimulatorApp.Data;
using AmazonSimulatorApp.Data.DTOs;

namespace AmazonSimulatorApp.Services
{
    public interface IProductService
    {
        int AddProduct(ProductInDTO product);
        ProductOutDTO GetProductByID(int ID);
        List<Product> GetProducts(int Page, int PageSize, int? CatID, int? Price, string? searchvalue);
        int UpdateProduct(ProductInDTO product, int SellerID, string Role);
    }
}