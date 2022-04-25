using Microsoft.AspNetCore.Mvc;
using CancStore.Models;

namespace CancStore.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase {
    private readonly IRepository _repository;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(IRepository repository, ILogger<ProductsController> logger) {
        _repository = repository;
        _logger = logger;
        _logger.LogInformation("Controller initialized");
    }

    [HttpGet("[action]")]
    public IQueryable<Product> Get() {
        _logger.LogInformation("Get request");
        return _repository.Products;
    }
}