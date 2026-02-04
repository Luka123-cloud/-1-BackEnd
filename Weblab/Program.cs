using Weblab;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
// Главная
app.MapGet("/", () => Results.Text(One.MainPage(), "text/html; charset=utf-8"));
// О нас
app.MapGet("/about", () => Results.Text(One.AboutPage(), "text/html; charset=utf-8"));
// Контакты
app.MapGet("/contact", () => Results.Text(One.ContactPage(), "text/html; charset=utf-8"));

app.Run();
