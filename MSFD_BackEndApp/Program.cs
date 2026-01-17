var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.AddOpenApi();

// builder.Services.AddDbContext<MyDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseCors();

// API Endpoint - A GET route that returns product data
app.MapGet( "/products", () => new[] { 
    new { Id =1, Name = "Laptop", Price = 999.99 },
    new { Id =2, Name = "Phone", Price = 699.99 },
    new { Id =3, Name = "Tablet", Price = 449.99 },
    new { Id =4, Name = "Monitor", Price = 299.99 },
    new { Id =5, Name = "Keyboard", Price = 79.99 },
    new { Id =6, Name = "Mouse", Price = 29.99 }
 } );

app.Run();