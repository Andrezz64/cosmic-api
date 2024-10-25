using cosmic_api.Models;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Controllers.Classes;

public class CategoriaControllerService(ICategoria categoria, IErrorHandler errorHandler) : ControllerBase, ICategoriaController
{
    private readonly ICategoria _categoria = categoria;
    private readonly IErrorHandler _errorHandler = errorHandler;

    public IActionResult Delete(int id)
    {
        try
        {
            Categoria categoriaLocal = new(){Id = id};
            _categoria.DeleteOne(categoriaLocal);
            return Ok(categoria);
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
            return Ok(_categoria.GetAll());
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Put(Categoria categoria)
    {
        try
        {
            _categoria.ChangeOne(categoria);
            return Ok(categoria);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }

    public IActionResult Post(Categoria categoria)
    {
        try
        {
            _categoria.CreateOne(categoria);
            return Ok(categoria);
        }
        catch (System.Exception ex)
        {
            return _errorHandler.GenericError(ex);
        }
    }
}