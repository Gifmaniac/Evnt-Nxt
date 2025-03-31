using Evnt_Nxt;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Makes a memory database.
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(
        "Server=mssqlstud.fhict.local;Database=dbi567108_nxtevnt;User Id=dbi567108_nxtevnt;Password=Test123;TrustServerCertificate=True;",
sqlOptions => sqlOptions.EnableRetryOnFailure(maxRetryCount: 5,
    maxRetryDelay: TimeSpan.FromSeconds(5),
    errorNumbersToAdd: null)));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
