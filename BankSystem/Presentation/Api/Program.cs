using Api;
using Application;
using Persistence;
using Persistence.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApiServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    DevInitializer.Initialize(app.Services);

app.Run();
