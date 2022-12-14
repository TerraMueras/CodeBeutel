using Codebeutel.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CodebeutelContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


var corsPolicyName = "AllowAll";
builder.Services.AddCors(o => o.AddPolicy(corsPolicyName, builder =>
{
    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

/* // Create database if not exists */
using (var scope = app.Services.CreateAsyncScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<CodebeutelContext>();
    await ctx.Database.EnsureDeletedAsync();
    await ctx.Database.MigrateAsync();
}


if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateAsyncScope())
    {
        var ctx = scope.ServiceProvider.GetRequiredService<CodebeutelContext>();
        new InitData(ctx);
    }
}

//app.UseHttpsRedirection();

app.UseCors(corsPolicyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
