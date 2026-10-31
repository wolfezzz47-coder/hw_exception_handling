using System;
using System.Collections.Generic;
using System.Text;

namespace hw_exception_handling
{
    class Store
    {
        // поля класу
        private string name;         // назва магазину
        private string address;      // адреса
        private string profile;      // опис профілю магазину
        private string phone;        // контактний телефон
        private string email;        // контактний email

        // конструктор за замовчуванням
        public Store()
        {
            name = string.Empty;
            address = string.Empty;
            profile = string.Empty;
            phone = string.Empty;
            email = string.Empty;
        }

        // конструктор з параметрами
        public Store(string name, string address, string profile,
                     string phone, string email)
        {
            this.name = name;
            this.address = address;
            this.profile = profile;
            this.phone = phone;
            this.email = email;
        }

        // ---- методи введення даних ----
        public void Input()
        {
            Console.Write("Введіть назву магазину: ");
            name = Console.ReadLine();

            Console.Write("Введіть адресу магазину: ");
            address = Console.ReadLine();

            Console.Write("Введіть опис профілю магазину: ");
            profile = Console.ReadLine();

            Console.Write("Введіть контактний телефон: ");
            phone = Console.ReadLine();

            Console.Write("Введіть контактний email: ");
            email = Console.ReadLine();
        }

        // ---- методи виведення даних ----
        public void Output()
        {
            Console.WriteLine(">>> Інформація про магазин:");
            Console.WriteLine($"Назва:            {name}");
            Console.WriteLine($"Адреса:           {address}");
            Console.WriteLine($"Профіль:          {profile}");
            Console.WriteLine($"Телефон:          {phone}");
            Console.WriteLine($"Email:            {email}");
        }

        // ---- доступ до окремих полів через методи (гетери/сетери) ----
        public string GetName() => name;
        public void SetName(string value) => name = value;

        public string GetAddress() => address;
        public void SetAddress(string value) => address = value;

        public string GetProfile() => profile;
        public void SetProfile(string value) => profile = value;

        public string GetPhone() => phone;
        public void SetPhone(string value) => phone = value;

        public string GetEmail() => email;
        public void SetEmail(string value) => email = value;
    }
}
