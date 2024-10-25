    using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class ColecaoController(IColecaoController controller) : ControllerBase
{
    private readonly IColecaoController _controller = controller;
    [HttpGet]
    public IActionResult Get()
    {
       return _controller.Get();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Coleco colecao)
    {
        return _controller.Post(colecao);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete(int id)
    {
       return _controller.Delete(id);
    }

    [HttpPatch]
    public IActionResult Put([FromBody] Coleco colecao)
    {
        return _controller.Put(colecao);
    }

}