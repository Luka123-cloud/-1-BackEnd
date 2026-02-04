using Weblab;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Главная
app.MapGet("/", () => Results.Text(One.MainPage(), "text/html; charset=utf-8"));
// О нас
app.MapGet("/about", () => Results.Text(One.AboutPage(), "text/html; charset=utf-8"));
// Контакты
app.MapGet("/contact", () => Results.Text(One.ContactPage(), "text/html; charset=utf-8"));

app.Run();
