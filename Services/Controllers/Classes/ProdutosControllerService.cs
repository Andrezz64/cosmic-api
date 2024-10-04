using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Controllers.Classes;

public class ProdutosControllerService(IProduto produto, IErrorHandler errorHandler) : ControllerBase, IProdutosController
{
    private readonly IProduto _produto = produto;
    private readonly IErrorHandler _errorHandler = errorHandler;

    public IActionResult Delete(int id)
    {
        try
        {
            Produto produto = new(){Id = id};
            _produto.DeleteOne(produto);
            return Ok(produto);
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
            return Ok(_produto.GetAll());
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Patch(Produto produto)
    {
        try
        {
            _produto.CreateOne(produto);
            return Ok(produto);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Post(Produto produto)
    {
        try
        {
            _produto.CreateOne(produto);
            return Ok(produto);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }
}