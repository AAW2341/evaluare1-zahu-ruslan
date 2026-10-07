using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Literele românești rămân lizibile în View Source (Ctrl+U).
// Rândul nu este obiectul evaluării: nu îl modifica.
builder.Services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(UnicodeRanges.All));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "FiltrareCurse",
    pattern: "curse/tip/{tip}",
    defaults: new { controller = "Curse", action = "Tip" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
