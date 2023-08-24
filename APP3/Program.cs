using System;

namespace APP3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать. Введите свои Имя и фамилию: ");
            string fullName = Console.ReadLine();
            string lastName = fullName.Split(' ')[^1]; 

            Console.WriteLine($"Привет, {fullName}!");

            while (true)
            {
                Console.Write("Выберете желаемую команду (get-data, get-time, get-temperature, exit): ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "get-data":
                        Console.WriteLine($"Текущая дата: {DateTime.Now.Date.ToShortDateString()}");
                        break;
                    case "get-time":
                        Console.WriteLine($"Текущее время: {DateTime.Now.ToShortTimeString()}");
                        break;
                    case "get-temperature":
                        double temperature = new Random().NextDouble() * 20 + 10;
                        Console.WriteLine($"Дата и время: {DateTime.Now}");
                        Console.WriteLine($"Темпрература: {temperature:F2}°C");
                        break;
                    case "exit":
                        Console.WriteLine($"Досвидания, {lastName}!");
                        return; 
                    default:
                        Console.WriteLine("Не верная команда. Завершение работы...");
                        return;
                }
            }
        }
    }
}
