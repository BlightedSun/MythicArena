using MythicArena.Components;
using Microsoft.EntityFrameworkCore;
using MythicArena.Data;





var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<GameLogic>();

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

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();




