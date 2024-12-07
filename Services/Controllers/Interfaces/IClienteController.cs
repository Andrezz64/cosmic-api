using cosmic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace cosmic_api.Services.Controllers.Interfaces;

public interface IClienteController
{
    public IActionResult Get();
    public IActionResult Post(Cliente cliente);
    public IActionResult Delete(int id);
    public IActionResult Put(Cliente cliente);

    public IActionResult Login(string Usuário, string Senha);

    public bool Logout(string JWT);
}