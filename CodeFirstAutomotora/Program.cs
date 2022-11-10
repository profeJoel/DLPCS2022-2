using BDAutomotora;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Incluir conexión a la base de datos Automotora
builder.Services.AddDbContext<AutomotoraContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AutomotoraConnection"))
);

var app = builder.Build();

//Descripción de la Migración a la base de datos.
//Solamente se ejecuta en la primera ejecución en el momento de actualizar la estructura de la base de datos
/*using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AutomotoraContext>();
    context.Database.Migrate();
}*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
