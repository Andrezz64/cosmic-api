    using cosmic_api.Models;
using cosmic_api.Services.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class VendaController(IVendaController controller) : ControllerBase
{
    private readonly IVendaController _controller = controller;
    [HttpGet]
    public IActionResult Get()
    {
       return _controller.Get();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Venda venda)
    {
        return _controller.Post(venda);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
       return _controller.Delete(id);
    }

    [HttpPatch]
    public IActionResult Put([FromBody] Venda venda)
    {
        return _controller.Put(venda);
    }

}