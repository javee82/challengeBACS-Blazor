//using Clinic.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);
var MiCors = "MiCors";
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("MyConfig").GetValue<string>("LocalHttpClient"))
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MiCors,
                      builder =>
                      {
                          builder.WithOrigins("*");
                      });
});
builder.Services.AddBlazorBootstrap();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseCors(MiCors);

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
