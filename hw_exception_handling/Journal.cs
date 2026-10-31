using System;
using System.Collections.Generic;
using System.Text;

namespace hw_exception_handling
{
    class Journal
    {
        // поля класу
        private string name;         // назва журналу
        private int year;            // рік заснування
        private string description;  // опис журналу
        private string phone;        // контактний телефон
        private string email;        // контактний email

        // конструктор за замовчуванням
        public Journal()
        {
            name = string.Empty;
            year = 0;
            description = string.Empty;
            phone = string.Empty;
            email = string.Empty;
        }

        // конструктор з параметрами
        public Journal(string name, int year, string description,
                       string phone, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        // ---- методи введення даних ----
        public void Input()
        {
            Console.Write("Введіть назву журналу: ");
            name = Console.ReadLine();

            Console.Write("Введіть рік заснування: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Введіть опис журналу: ");
            description = Console.ReadLine();

            Console.Write("Введіть контактний телефон: ");
            phone = Console.ReadLine();

            Console.Write("Введіть контактний email: ");
            email = Console.ReadLine();
        }

        // ---- методи виведення даних ----
        public void Output()
        {
            Console.WriteLine(">>> Інформація про журнал:");
            Console.WriteLine($"Назва:            {name}");
            Console.WriteLine($"Рік заснування:   {year}");
            Console.WriteLine($"Опис:             {description}");
            Console.WriteLine($"Телефон:          {phone}");
            Console.WriteLine($"Email:            {email}");
        }

        // ---- доступ до окремих полів через методи (гетери/сетери) ----
        public string GetName() => name;
        public void SetName(string value) => name = value;

        public int GetYear() => year;
        public void SetYear(int value) => year = value;

        public string GetDescription() => description;
        public void SetDescription(string value) => description = value;

        public string GetPhone() => phone;
        public void SetPhone(string value) => phone = value;

        public string GetEmail() => email;
        public void SetEmail(string value) => email = value;
    }
}
