using MythicArena.Components;
using Microsoft.EntityFrameworkCore;
using MythicArena.Data;
using System.Net.Http;







var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<Fetch>();
builder.Services.AddScoped<IMonsterRepository, MonsterRepository>();
builder.Services.AddScoped<IPicsumService, PicsumService>();
//builder.Services.AddScoped<PicsumService>();
//builder.Services.AddScoped<HttpClient>();
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://picsum.photos/500/500") });
builder.Services.AddHttpClient<PicsumService>();



//set up for database
builder.Services.AddDbContext<MonsterContext>(options =>
{

    options.UseSqlite(builder.Configuration["ConnectionStrings:SQLiteDefault"]);
    //servicelifetimescoped?
    
    
    //options.UseSqlite(builder.Configuration.GetConnectionString("Default Connection"));
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapControllers();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<MonsterContext>();
    db.Database.EnsureCreated();
    //db.Database.Migrate();
}
app.Run();






