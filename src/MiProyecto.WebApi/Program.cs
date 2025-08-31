using MiProyecto.Modules.Catalog;
using MiProyecto.Modules.Orders;
using MiProyecto.SharedKernel.Events; 

var builder = WebApplication.CreateBuilder(args);

// 1. Registro de los servicios de nuestros módulos (esto no cambia)
builder.Services.AddScoped<ICatalogApi, CatalogService>();
builder.Services.AddScoped<IOrderApi, OrdersService>();

// 2. Registro de MediatR (la forma más robusta y explícita)
builder.Services.AddMediatR(cfg => {
    // Escanea el proyecto WebApi (donde está Program)
    cfg.RegisterServicesFromAssemblyContaining<Program>();
    // Escanea el proyecto Orders (identificado por IOrdersApi)
    cfg.RegisterServicesFromAssemblyContaining<IOrderApi>();
    // Escanea el proyecto Catalog (identificado por ICatalogApi)
    cfg.RegisterServicesFromAssemblyContaining<ICatalogApi>();
    // Escanea el proyecto SharedKernel (identificado por OrderCreatedEvent)
    cfg.RegisterServicesFromAssemblyContaining<OrderCreatedEvent>(); 
});


var app = builder.Build();


app.MapPost("/orders", async (IOrderApi ordersApi) => {
    await ordersApi.CreateNewOrderAsync("user-007", new List<object>());
    return Results.Ok("Pedido creado exitosamente y evento publicado!");
});

app.Run();