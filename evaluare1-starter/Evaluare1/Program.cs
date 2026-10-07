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

// Sarcina 3: ruta ta se scrie AICI, înaintea rutei implicite de mai jos.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
