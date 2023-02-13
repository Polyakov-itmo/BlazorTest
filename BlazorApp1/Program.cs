using BlazorApp1;
using BlazorApp1.Data;
using BlazorApp1.Infrastructure;
using DataAccess.Contexts;
using DataAccess.Repos;
using DataAccess.Repos.Todo;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddScoped<IRepositoryGlobal, RepositoryGlobal>();
//builder.Services.AddScoped<ITodoRepository, TodoRepository>();
//builder.Services.AddHostedService<BackgroundWorkerService>();

builder.Services.ConfigureSqLiteContext(builder.Configuration);

builder.Services.ConfigureRepository();


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
