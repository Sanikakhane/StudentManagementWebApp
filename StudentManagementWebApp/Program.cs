using Microsoft.EntityFrameworkCore;
using Serilog;
using StudentManagementWebApp.Components;
using StudentManagementWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Set up Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()  // Log to console (optional)
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)  // Log files that roll daily
    .CreateLogger();

// Add Serilog to the logging pipeline
builder.Logging.ClearProviders();  // Clear other providers (if any)
builder.Logging.AddSerilog();  // Add Serilog for logging

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DefaultConnection"]
        )
);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
