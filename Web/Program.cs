using DataAccess.Contexts;
using DataAccess.Extensions;
using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Def;
using BusinessLogic.Services;
using DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Web.Data;
using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.ViewModels.TodoModels;
using BusinessLogic.Mappers;
using BusinessLogic.ViewModels.UserModels;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.ConfigureSqlServerContext(builder.Configuration);

builder.Services.AddScoped<IRepository<Todo>, TodoRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();

builder.Services.AddScoped<IMapper<TodoCreate, TodoUpdate, TodoResult, TodoResult,Todo>, TodoMapper>();
builder.Services.AddScoped<IMapper<UserCreate, UserUpdate, UserResult, UserListResult, User>, UserMapper>();

builder.Services.AddTransient<ITodoService, TodoService>();
builder.Services.AddTransient<IUserService, UserService>();


builder.Services.AddBlazorise(options =>
 {
     options.Immediate = true;
 })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();


builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
