using cosmic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace cosmic_api.Services.Controllers.Interfaces;

public interface IProdutosController
{
    public IActionResult Get();
    public IActionResult Post(Produto produto);
    public IActionResult Delete(int id);
    public IActionResult Patch(Produto produto);
}