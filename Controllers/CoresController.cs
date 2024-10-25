    using cosmic_api.Models;
using cosmic_api.Services.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class CoresController(ICoresController controller) : ControllerBase
{
    private readonly ICoresController _controller = controller;
    [HttpGet]
    public IActionResult Get()
    {
       return _controller.Get();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Core cor)
    {
        return _controller.Post(cor);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
       return _controller.Delete(id);
    }

    [HttpPatch]
    public IActionResult Put([FromBody] Core cor)
    {
        return _controller.Put(cor);
    }

}