using cosmic_api;
using cosmic_api.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CosmicContext>();
builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {   
                        // builder.WithOrigins("https://cadastrodeusuarios.alterdata.matriz") //Prod
                        // builder.WithOrigins("http://localhost:5000") //URL Do front
                        builder.WithOrigins("*") //testes c vitest (precisa desabilitar o jwt)
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
ServiceBuilder.Injector(builder.Services);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowSpecificOrigin");
app.MapControllers();

app.Run();
