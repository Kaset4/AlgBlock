﻿public class Program
{
    static void ShowAds(User user)
    {


        Console.WriteLine($"Добро пожаловать {user.Name}");
        if (user.IsPremium == false)
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
    static void Main(string[] args)
	{
        User user = new User()
        {
            Login = "Ivan",
            Name = "Ivan",
            IsPremium = false
        };

        ShowAds(user);
	}
}