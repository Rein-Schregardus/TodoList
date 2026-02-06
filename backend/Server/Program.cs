using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Server;
using Server.Services;

var builder = WebApplication.CreateBuilder(args);

// register services
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddControllers();
builder.Services.AddScoped<ITodoService, TodoService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});



var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("./v1/swagger.json", "My API V1"); //originally "./swagger/v1/swagger.json"
});

app.UseAuthorization();

app.MapControllers();

app.UseDeveloperExceptionPage();

app.MapSwagger();



//using (var scope = app.Services.CreateScope())
//{
//    AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//    if (context == null)
//        throw new Exception("AppDbContext is null");
//    context.Database.Migrate();
//}

app.Run();