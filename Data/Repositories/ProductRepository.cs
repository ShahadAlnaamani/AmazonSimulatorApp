using AmazonSimulatorApp.Data.DTOs;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AmazonSimulatorApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //Adds a new product [returns product id]
        public int AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.PID;
        }

        //Update product details [returns false product not found, true successful update]
        public bool UpdateProduct(ProductInDTO newprod, int ProdID)
        {
            var oldprod = GetProductByID(ProdID);

            //Updating details on the original product with new details
            if (oldprod != null)
            {
                oldprod.Name = newprod.Name;
                oldprod.Description = newprod.Description;
                oldprod.Price = newprod.Price;
                oldprod.CatID = newprod.CatID;

                _context.Products.Update(oldprod);
                _context.SaveChanges();
                return true; //Updated successfully
            }
            else return false; //Product not found 
        }

        public bool UpdateAfterReview(int newRating, int ProdID)
        {
            var oldprod = GetProductByID(ProdID);

            //Updating details on the original product with new details
            if (oldprod != null)
            {
                oldprod.Rating = newRating;

                _context.Products.Update(oldprod);
                _context.SaveChanges();
                return true; //Updated successfully
            }

            else return false; //Product not found 
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public Product GetProductByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }
        public string GetProductNameByID(int ID)
        {
            var product = GetProductByID(ID);
            return product.Name;
        }

        //Search for product by ID 
        public Product GetProductByID(int ID)
        {
            return _context.Products.FirstOrDefault(p => p.PID == ID);
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
