using cosmic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace cosmic_api.Services.Controllers.Interfaces;

public interface ICategoriaController
{
    public IActionResult Get();
    public IActionResult Post(Categoria categoria);
    public IActionResult Delete(int id);
    public IActionResult Put(Categoria categoria);
}