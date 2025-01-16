using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AmazonSimulatorApp.Data
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsVerified { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        // Navigation Properties
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
    public class Client
    {
        [Key]
        public int CID { get; set; }

        [ForeignKey("User")]
        public int UID { get; set; }
        public User User { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        public int CompletedOrders { get; set; }
        // Navigation Properties
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
    }
    public class Seller
    {
        [Key]
        public int SID { get; set; }

        [ForeignKey("User")]
        public int UID { get; set; }
        public User User { get; set; }

        public float Rating { get; set; }
        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
    }
    public class Product
    {
        [Key]
        public int PID { get; set; }

        [ForeignKey("Seller")]
        public int SID { get; set; }
        public Seller Seller { get; set; }


        [ForeignKey("Category")]
        public int CatID { get; set; }
        public Category Category { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Range(1, 5)]
        [DefaultValue(5)]
        public int Rating { get; set; }
        // Navigation Properties
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }

    public class ProductImage
    {
        [Key]
        public int PImageID { get; set; }

        [ForeignKey("Product")]
        public int PID { get; set; }
        public string Image { get; set; }
    }

    public class Category
    {
        [Key]
        public int CatID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        // Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
    }
    public class Order
    {
        [Key]
        public int OID { get; set; }

        [ForeignKey("Client")]
        public int CID { get; set; }
        public Client Client { get; set; }

        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        // Navigation Properties
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail
    {
        [ForeignKey("Order")]
        public int OID { get; set; }
        public Order Order { get; set; }


        [ForeignKey("Product")]
        public int PID { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        // Navigation Properties
    }
    public class ProductReview
    {
        [Key]
        public int RID { get; set; }
        [ForeignKey("Product")]
        public int PID { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Client")]
        public int CID { get; set; }
        public Client Client { get; set; }

        public string Comment { get; set; }
        public float Rate { get; set; }
        // Navigation Properties
    }
}











