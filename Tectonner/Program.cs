using Tectonner.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddOptions<PostgreConfiguration>().Configure(cfg =>
{
    cfg.ConnectionString = "Host=dpg-cp3p1bvsc6pc73ftcftg-a;Username=admin;Password=ItlTtyFERpO0ElbBh5FFNFYQjNU9Ot6L;Database=dbtectonnerinicial";
});


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
