using ApplicatinTest.BussinessService;
using ApplicatinTest.DataEntity;
using ApplicatinTest.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.
builder.Services.AddControllersWithViews();
var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("M19DBConnectionString");


builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddDbContext<EDMSContext>(options => options.UseSqlServer(connectionString));

RepositoryDepedencyContainer.Registration(builder.Services);
ServiceDepedencyContainer.Registration(builder.Services);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
