using AutoMapper;
using Core.Util.Jwt;
using FichaAvaliacao.API.Configuration;
using System.Reflection;
using MediatR;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfigurationFichaAvaliacao(builder.Configuration);

builder.Services.AddJwtConfiguration(builder.Configuration);

builder.Services.AddSwaggerConfigurationFichaAvaliacao();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.ResolveDependenciesFichaAvaliacao();

builder.WebHost.UseUrls("http://localhost:8001");

var app = builder.Build();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthConfiguration();

app.UseSwaggerConfigurationFichaAvaliacao();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
