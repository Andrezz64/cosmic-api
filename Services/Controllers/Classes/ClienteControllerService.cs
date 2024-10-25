using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Controllers.Classes;

public class ClienteControllerService(ICliente cliente, IErrorHandler errorHandler) : ControllerBase, IClienteController
{
    private readonly ICliente _cliente = cliente;
    private readonly IErrorHandler _errorHandler = errorHandler;

    public IActionResult Delete(int id)
    {
        try
        {
            Cliente clienteLocal = new(){Id = id};
            _cliente.DeleteOne(clienteLocal);
            return Ok(cliente);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Get()
    {
        try
        {
            return Ok(_cliente.GetAll());
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Put(Cliente cliente)
    {
        try
        {
            _cliente.ChangeOne(cliente);
            return Ok(cliente);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Post(Cliente cliente)
    {
        try
        {
            _cliente.CreateOne(cliente);
            return Ok(cliente);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public string Login(string Usuário, string Senha)
    {
        throw new NotImplementedException();
    }

    public bool Logout(string JWT)
    {
        throw new NotImplementedException();
    }
}