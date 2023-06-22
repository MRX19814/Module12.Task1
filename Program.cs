﻿using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Создание списка пользователей
        List<User> users = new List<User>
        {
            new User { Login = "user1", Name = "John", IsPremium = true },
            new User { Login = "user2", Name = "Alice", IsPremium = false },
            new User { Login = "user3", Name = "Bob", IsPremium = true }
        };

        // Перебор пользователей
        foreach (User user in users)
        {
            // Приветствие по имени
            Console.WriteLine($"Привет, {user.Name}!");

            // Проверка премиум-подписки
            if (!user.IsPremium)
            {
                // Показ рекламы
                ShowAds();
            }
        }

        Console.ReadLine();
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}

class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}