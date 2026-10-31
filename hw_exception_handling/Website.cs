using System;
using System.Collections.Generic;
using System.Text;

namespace hw_exception_handling
{
    class Website
    {
        // поля класу
        private string name;         // назва сайту
        private string path;         // шлях до сайту (URL)
        private string description;  // опис сайту
        private string ip;           // IP-адреса сайту

        // конструктор за замовчуванням
        public Website()
        {
            name = string.Empty;
            path = string.Empty;
            description = string.Empty;
            ip = string.Empty;
        }

        // конструктор з параметрами
        public Website(string name, string path, string description, string ip)
        {
            this.name = name;
            this.path = path;
            this.description = description;
            this.ip = ip;
        }

        // ---- методи введення даних ----
        public void Input()
        {
            Console.Write("Введіть назву сайту: ");
            name = Console.ReadLine();

            Console.Write("Введіть шлях до сайту (URL): ");
            path = Console.ReadLine();

            Console.Write("Введіть опис сайту: ");
            description = Console.ReadLine();

            Console.Write("Введіть IP-адресу сайту: ");
            ip = Console.ReadLine();
        }

        // ---- методи виведення даних ----
        public void Output()
        {
            Console.WriteLine(">>> Інформація про веб-сайт:");
            Console.WriteLine($"Назва:        {name}");
            Console.WriteLine($"Шлях:         {path}");
            Console.WriteLine($"Опис:         {description}");
            Console.WriteLine($"IP-адреса:    {ip}");
        }

        // ---- доступ до окремих полів через методи (гетери/сетери) ----
        public string GetName() => name;
        public void SetName(string value) => name = value;

        public string GetPath() => path;
        public void SetPath(string value) => path = value;

        public string GetDescription() => description;
        public void SetDescription(string value) => description = value;

        public string GetIp() => ip;
        public void SetIp(string value) => ip = value;
    }
}
