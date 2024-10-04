using Microsoft.AspNetCore.Mvc;

namespace cosmic_api.Services.Interfaces;

public interface IErrorHandler
{
   public IActionResult GenericError(System.Exception ex);
}