using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FourthCoffee.Models;

namespace FourthCoffee.Data {
    public class ProductsService : IProductsService {
        public IList<Product> Products { get; private set; }

        private string productsFile = "Products.json";

        public ProductsService() {
            if (!File.Exists(productsFile)) {
                string productsAsJson = JsonSerializer.Serialize(Products);
                File.WriteAllText(productsFile, productsAsJson);
            } else {
                string content = File.ReadAllText(productsFile);
                Products = JsonSerializer.Deserialize<List<Product>>(content);
            }
        }
    }
}