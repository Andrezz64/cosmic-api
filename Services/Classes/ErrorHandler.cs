
using cosmic_api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace cosmic_api.Services.Classes;

public class ErrorHandler(IWebHostEnvironment env) : ControllerBase, IErrorHandler
{
    private readonly IWebHostEnvironment _env = env;
    public IActionResult GenericError(System.Exception ex)
    {
        if(_env.IsDevelopment())
        {
            return StatusCode(500, new
            {
                Status="Error",
                Msg = ex.Message,
                Trace = ex
            });
        }
        return StatusCode(500,new 
        {
            Status = "Error",
            msg="An unexpected Ocurred"
        });
    }

}