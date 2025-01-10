using Endpoint_EightToTen.Services.Mini8;
using Endpoint_EightToTen.Services.Mini9A;
using Endpoint_EightToTen.Services.Mini9B;
using Endpoint_EightToTen.Services.Mini9C;
using Endpoint_EightToTen.Services.Mini10;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMini8Service, Mini8Service>();
builder.Services.AddScoped<IMini9AService, Mini9AService>();
builder.Services.AddScoped<IMini9BService, Mini9BService>();
builder.Services.AddScoped<IMini9CService, Mini9CService>();
builder.Services.AddScoped<IMini10Service, Mini10Service>();

var app = builder.Build();

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
