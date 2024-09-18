using MicroserviceRabbitMQ.MVC.Refit.Interfaces;
using MicroserviceRabbitMQ.MVC.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<ITransferService,TransferService>();
// Adicionando o cliente Refit para a interface da API
builder.Services.AddRefitClient<IBankingApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:44348/"));


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
