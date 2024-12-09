using Common_API.Data;
using Common_API.Middleware;
using Common_API.Repositories1;
using Common_API.Repositories1.RepositoryInterface;
using Common_API.Services2;
using Common_API.Services2.ServiceInterface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cstr = builder.Configuration.GetConnectionString("dbcs");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(cstr));

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddOpenApi(); // Register OpenAPI services for Swagger
//builder.Services.AddSwaggerGen(); // Make sure to add this line


builder.Services.AddScoped<IRoleRepository, RoleRepository>();


var app = builder.Build();

// Use custom error handling middleware

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/V1.json", "Weather api"));
    //app.UseSwagger();  // Enable Swagger JSON endpoint
    //app.UseSwaggerUI(); // Enable Swagger UI for API documentation
}
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
