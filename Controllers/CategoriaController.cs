using cosmic_api.Models;
using cosmic_api.Services.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class CategoriaController(ICategoriaController controller) : ControllerBase
{
    private readonly ICategoriaController _controller = controller;
    [HttpGet]
    public IActionResult Get()
    {
       return _controller.Get();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Categoria categoria)
    {
        return _controller.Post(categoria);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
       return _controller.Delete(id);
    }

    [HttpPatch]
    public IActionResult Put([FromBody] Categoria categoria)
    {
        return _controller.Put(categoria);
    }

}