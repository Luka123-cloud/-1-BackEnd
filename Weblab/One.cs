namespace Weblab
{
    public static class One
    {
        public static string MainPage()
        {
            return """
            <html>
            <head><title>Главная</title></head>
            <body>
                <h1>Главная страница</h1>
                <p>Привет мир! Работает</p>
                <a href="/about">О нас</a><br>
                <a href="/contact">Контакты</a>
            </body>
            </html>
            """;
        }

        public static string AboutPage()
        {
            return """
            <html>
            <head><title>О нас</title></head>
            <body>
                <h1>О нас</h1>
                <p>Пример страницы</p>
                <a href="/">Главная</a><br>
                <a href="/contact">Контакты</a>
            </body>
            </html>
            """;
        }

        public static string ContactPage()
        {
            return """
            <html>
            <head><title>Контакты</title></head>
            <body>
                <h1>Контакты</h1>
                <p>Email: contactcopy@mail.com</p>
                
                <a href="/">Главная</a><br>
                <a href="/about">О нас</a>
            </body>
            </html>
            """;
        }
    }
}
