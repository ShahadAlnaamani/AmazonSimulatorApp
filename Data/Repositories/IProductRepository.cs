using AmazonSimulatorApp.Data.DTOs;

namespace AmazonSimulatorApp.Data.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(Product product);
        void DeleteProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductByID(int ID);
        string GetProductNameByID(int ID);
        bool UpdateAfterReview(int newRating, int ProdID);
        bool UpdateProduct(ProductInDTO newprod, int ProdID);
        Product GetProductByName(string name);
    }
}