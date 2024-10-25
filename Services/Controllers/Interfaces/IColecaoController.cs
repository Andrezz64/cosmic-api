using cosmic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace cosmic_api.Services.Controllers.Interfaces;

public interface IColecaoController
{
    public IActionResult Get();
    public IActionResult Post(Coleco colecao);
    public IActionResult Delete(int id);
    public IActionResult Put(Coleco colecao);
}