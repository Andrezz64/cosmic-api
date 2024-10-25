using cosmic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace cosmic_api.Services.Controllers.Interfaces;

public interface IVendaController
{
    public IActionResult Get();
    public IActionResult Post(Venda venda);
    public IActionResult Delete(int id);
    public IActionResult Put(Venda venda);
}