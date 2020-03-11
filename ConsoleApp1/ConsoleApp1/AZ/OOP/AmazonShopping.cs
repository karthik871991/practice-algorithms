using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice.AZ.OOP
{
    public class Manager
    {
        //public static void Main()
        //{
        //    var gallery = new ProductGallery();

        //    var karthikVendor = new Vendor(gallery);
        //    karthikVendor.FirstName = "Karthik";

        //    var product1 = new Product { Vendor = karthikVendor, ProductId = 1, ProductName = "IPhone", Price = 1500 };
        //    karthikVendor.AddProduct(product1);

        //    var swetaVendor = new Vendor(gallery);
        //    swetaVendor.FirstName = "Sweta";

        //    var product2 = new Product { Vendor = swetaVendor, ProductId = 2, ProductName = "GOOGLE phone", Price = 500 };
        //    swetaVendor.AddProduct(product2);

        //    var product3 = new Product { Vendor = swetaVendor, ProductId = 2, ProductName = "GOOGLE phone", Price = 1000 };
        //    swetaVendor.AddProduct(product3);

        //    var result1 = swetaVendor.Search(new ProductSearchCriteria { ProductName = "GOOGLE phone" });

        //    karthikVendor.RemoveProduct(result1[0]);

        //    Console.WriteLine(string.Concat(",", result1.Select(x => x.ProductName)));
        //    Console.ReadKey();
        //}
    }

    public class PaymentDetails
    {

    }

    public class User
    {
        private UserType _type;
        public User(UserType type)
        {
            _type = type;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public List<PaymentDetails> PaymentDetails { get; set; }
    }

    public enum UserType
    {
        Admin,
        Vendor,
        AmazonUser
    }

    public class Vendor : User
    {
        private ProductGallery _gallery;
        public string VendorName { get; set; }
        public Vendor(ProductGallery gallery) : base(UserType.Vendor)
        {
            _gallery = gallery;
        }

        public void AddProduct(Product product)
        {
            _gallery.AddProduct(product);
        }

        public void RemoveProduct(Product product)
        {
            if (this.VendorName == product.Vendor.VendorName)
                _gallery.RemoveProduct(product);
        }

        public List<Product> Search(ProductSearchCriteria criteria)
        {
            return _gallery.SearchProducts(criteria);
        }
    }

    public enum ProductCategory
    {
        Phone,
        Tab,
        Computer,
        HeadPhones
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }
        public decimal Price { get; set; }
        public Vendor Vendor { get; set; }
    }

    public class ProductGallery
    {
        private Dictionary<ProductCategory, List<Product>> _products { get; set; }
        public ProductGallery()
        {
            _products = new Dictionary<ProductCategory, List<Product>>();
        }

        public void AddProduct(Product product)
        {
            if (!_products.ContainsKey(product.Category))
            {
                _products.Add(product.Category, new List<Product> { product });
            }

            _products[product.Category].Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _products[product.Category].Remove(product);
        }

        public List<Product> SearchProducts(ProductSearchCriteria criteria)
        {
            // sample search
            var result = new List<Product>();

            if (criteria.Price > 0)
                result.AddRange(_products[criteria.Category].FindAll(x => x.Price == criteria.Price));

            if (!string.IsNullOrWhiteSpace(criteria.ProductName))
                result.AddRange(_products[criteria.Category].FindAll(x => x.ProductName == criteria.ProductName));

            if (criteria.Vendor != null)
                result.AddRange(_products[criteria.Category].FindAll(x => x.Vendor == criteria.Vendor));

            if (criteria.ProductId > 0)
                result.AddRange(_products[criteria.Category].FindAll(x => x.ProductId == criteria.ProductId));

            return result;
        }
    }

    public class ProductSearchCriteria
    {
        public int ProductId { get; set; }
        public ProductCategory Category { get; set; }
        public string ProductName { get; set; }
        public Vendor Vendor { get; set; }
        public decimal Price { get; set; }
    }
}