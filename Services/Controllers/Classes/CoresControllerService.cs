using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Controllers.Classes;

public class CoresControllerService(ICor cores, IErrorHandler errorHandler) : ControllerBase, ICoresController
{
    private readonly ICor _cores = cores;
    private readonly IErrorHandler _errorHandler = errorHandler;

    public IActionResult Delete(int id)
    {
        try
        {
            Core corLocal = new(){Id = id};
            _cores.DeleteOne(corLocal);
            return Ok(corLocal);
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
            return Ok(_cores.GetAll());
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Put(Core cor)
    {
        try
        {
            _cores.ChangeOne(cor);
            return Ok(cor);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Post(Core cor)
    {
        try
        {
            _cores.CreateOne(cor);
            return Ok(cor);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }
}