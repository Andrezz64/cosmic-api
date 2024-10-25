    using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class ClienteController(IClienteController controller) : ControllerBase
{
    private readonly IClienteController _controller = controller;
    [HttpGet]
    public IActionResult Get()
    {
       return _controller.Get();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Cliente cliente)
    {
        return _controller.Post(cliente);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
       return _controller.Delete(id);
    }

    [HttpPatch]
    public IActionResult Put([FromBody] Cliente cliente)
    {
        return _controller.Put(cliente);
    }

}