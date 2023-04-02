using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using KolmeoProductAPI.Controllers;
using KolmeoProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using FluentAssertions;

public class ProductControllerTest{
    private readonly ProductsController _controller;
    private ProductContext GetProductContextwithData(){
        var options = new DbContextOptionsBuilder<ProductContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
        var context = new ProductContext(options);

        context.Products.Add(new Product {Id = 1, Name = "TestProd1Name", Description = "TestProd1Desc", Price = "TestProd1Price"});

        return context;
        
    }
    
    public ProductControllerTest(){
        
        _controller = new ProductsController(GetProductContextwithData());
    }

    [Fact]
    public void Get_WhenCalled_ReturnsOkResult()
    {
        var result = _controller.GetProducts();

        Assert.NotNull(result);
    }

}

