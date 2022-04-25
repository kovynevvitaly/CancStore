using Xunit;
using CancStore.Models;
using CancStore.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CancStore.Tests;

public class ProductsControllerTests
{
    [Fact]
    public void CanReturnProducts()
    {
        var logger = Mock.Of<ILogger<ProductsController>>();
        var repository = new Mock<IRepository>();
        repository.Setup(r => r.Products).Returns(new Product[] {
            new() {Id = 1, Name = "p1", Category = "c1", Price = 100, StoredAmount = 100},
            new() {Id = 2, Name = "p2", Category = "c2", Price = 100, StoredAmount = 100},
            new() {Id = 3, Name = "p3", Category = "c3", Price = 100, StoredAmount = 100},
        }.AsQueryable());
        var controller = new ProductsController(repository.Object, logger);

        var result = controller.Get().ToArray();

        Assert.Equal(3, result.Length);
        Assert.Equal("p1", result[0].Name);
        Assert.Equal("p2", result[1].Name);
        Assert.Equal("p3", result[2].Name);
    }
}