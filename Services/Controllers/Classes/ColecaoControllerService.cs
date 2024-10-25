using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Controllers.Classes;

public class ColecaoControllerService(IColecao colecao, IErrorHandler errorHandler) : ControllerBase, IColecaoController
{
    private readonly IColecao _colecao = colecao;
    private readonly IErrorHandler _errorHandler = errorHandler;

    public IActionResult Delete(int id)
    {
        try
        {
            Coleco colecaoLocal = new(){Id = id};
            _colecao.DeleteOne(colecaoLocal);
            return Ok(colecao);
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
            return Ok(_colecao.GetAll());
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Put(Coleco colecao)
    {
        try
        {
            _colecao.ChangeOne(colecao);
            return Ok(colecao);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Post(Coleco colecao)
    {
        try
        {
            _colecao.CreateOne(colecao);
            return Ok(colecao);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }
}