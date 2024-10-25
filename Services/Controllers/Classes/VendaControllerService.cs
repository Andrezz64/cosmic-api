using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Controllers.Classes;

public class VendaControllerService(IVenda venda, IErrorHandler errorHandler) : ControllerBase, IVendaController
{
    private readonly IVenda _venda = venda;
    private readonly IErrorHandler _errorHandler = errorHandler;

    public IActionResult Delete(int id)
    {
        try
        {
            Venda vendaLocal = new(){Id = id};
            _venda.DeleteOne(vendaLocal);
            return Ok(vendaLocal);
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
            return Ok(_venda.GetAll());
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Put(Venda venda)
    {
        try
        {
            _venda.ChangeOne(venda);
            return Ok(venda);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Post(Venda venda)
    {
        try
        {
            _venda.CreateOne(venda);
            return Ok(venda);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }
}