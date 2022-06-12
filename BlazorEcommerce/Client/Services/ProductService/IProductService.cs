﻿namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

        Task<ServiceResponse<Product>> GetProductById(int productId);

    }
}
