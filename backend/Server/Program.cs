using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// register services
builder.Services.AddControllers();

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
app.Run();