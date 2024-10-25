using cosmic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace cosmic_api.Services.Controllers.Interfaces;

public interface ICoresController
{
    public IActionResult Get();
    public IActionResult Post(Core cor);
    public IActionResult Delete(int id);
    public IActionResult Put(Core cor);
}