using Api;
using Application;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApiServices();

var app = builder.Build();

app.Run();
