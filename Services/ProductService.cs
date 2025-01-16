using AmazonSimulatorApp.Data.DTOs;
using AmazonSimulatorApp.Data.Repositories;
using AmazonSimulatorApp.Data;

namespace AmazonSimulatorApp.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productrepository;

        public ProductService(IProductRepository productrepo)
        {
            _productrepository = productrepo;
        }

        public int AddProduct(ProductInDTO product)
        {
            var NewProd = new Product
            {
                Name = product.Name,
                Description = product.Description,
                CatID = product.CatID,
                Price = product.Price,
                SID = product.SellerID
            };

            return _productrepository.AddProduct(NewProd);
        }

        public int UpdateProduct(ProductInDTO product, int SellerID, string Role)
        {
            Product prod = new Product(); 

            try
            {
                //validating - kicks out anyone that is not permited  
                 prod = _productrepository.GetProductByName(product.Name);

                if (Role.ToLower() == "seller")
                {
                    if (prod.SID == SellerID)
                    {
                        // all good continue 
                    }
                    else return 5; //can only change products that belong to you 
                }
                else return 4; //unauthorized to make this change must be a seller 
            }
            catch { return 3; } //product not valid 

            if (prod.PID != 0 || prod.PID != null)
            {
                bool updated = _productrepository.UpdateProduct(product, prod.PID);
                if (updated) return 0; //successful no errors
                else return 1; //not updated error occured 
            }
            else return 2; //improper category inputted 
        }

        public ProductOutDTO GetProductByID(int ID)
        {
            var product = _productrepository.GetProductByID(ID);
            var output = new ProductOutDTO
            {
                PID = product.PID,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Category = product.Category.Name,
            };
            return output;
        }


        public List<Product> GetProducts(int Page, int PageSize, int? CatID, int? Price, string? searchvalue)
        {
            var Products = _productrepository.GetAllProducts();

            // Filters by if catID if provided 
            if (CatID.HasValue)
            {
                Products = Products.Where(p => p.CatID == CatID).ToList();
            }

            // Filters by Price if provided 
            if (Price.HasValue)
            {
                Products = Products.Where(p => p.Price <= Price).ToList();
            }

            // Filters by searchvalue if provided 
            if (searchvalue != null)
            {
                Products = Products.Where(p => p.Name.Contains(searchvalue) || p.Description.Contains(searchvalue)).ToList();
            }

            // Paginating results and returning 
            int number = PageSize * Page;
            return Products.OrderBy(p => p.Rating).Skip(number).Take(PageSize).ToList();
        }
    }
}
