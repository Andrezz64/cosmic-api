using cosmic_api.Controllers;
using cosmic_api.Repository.Classes;
using cosmic_api.Repository.interfaces;
using cosmic_api.Services.Classes;
using cosmic_api.Services.Controllers.Classes;
using cosmic_api.Services.Controllers.Interfaces;
using cosmic_api.Services.Interfaces;

public static class ServiceBuilder
{
    public static void Injector(IServiceCollection service)
    {
        service.AddScoped<IProduto,ProdutoRepository>();
        service.AddScoped<ICategoria,CategoriaRepository>();
        service.AddScoped<ICliente,ClienteRepository>();
        service.AddScoped<IColecao,ColecaoRepository>();
        service.AddScoped<ICor,CorRepository>();
        service.AddScoped<IRole,RoleRepository>();
        service.AddScoped<IUsuario,UsuarioRepository>();
        service.AddScoped<IVenda,VendaRepository>();
        service.AddScoped<IErrorHandler,ErrorHandler>();
        service.AddScoped<IProdutosController,ProdutosControllerService>();
        service.AddScoped<ICategoriaController,CategoriaControllerService>();
        service.AddScoped<IClienteController,ClienteControllerService>();
        service.AddScoped<IColecaoController,ColecaoControllerService>();
        service.AddScoped<ICoresController,CoresControllerService>();
        service.AddScoped<IProdutosController,ProdutosControllerService>();
        service.AddScoped<IVendaController,VendaControllerService>();
    }
}