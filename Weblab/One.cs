namespace Weblab
{
    public static class One
    {
        public static string MainPage()
        {
            return
                "<div style='text-align: center;'>" +
                "<h1>Главная страница</h1>" +
                "<li><a href='/about'>О нас</a></li>" +
                "<li><a href='/contact'>Контакты</a></li>" +
                "<p>Hello world!</p>";
           
        }
        public static string AboutPage()
        {
            return
                "<div style='text-align: center;'>" +
                "<h1>О нас</h1>" +
                "<li> <a href='/'>Главная</a> </li>" +
                "<li><a href='/contact'>Контакты</a></li>" +
                "<p>Приложение работает</p>";
        }
        
        public static string ContactPage()
        {
            return
                "<div style='text-align: center;'>" +
                "<h1>Контакты</h1>" +
                "<li> <a href='/'>Главная</a> </li>" +
                "<li><a href='/about'>О нас</a></li>" +
                "<p>Почта: Keycopy@mail.com</p>";
        }
    }
}
