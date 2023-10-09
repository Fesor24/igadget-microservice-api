﻿namespace ProductService.Response;

public class GetProductResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public string CategoryName { get; set; }
}