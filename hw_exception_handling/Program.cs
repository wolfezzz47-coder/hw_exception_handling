//// mission 1
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Console.Write("Введіть довжину сторони квадрата: ");
//int side = int.Parse(Console.ReadLine());

//Console.Write("Введіть символ для квадрата: ");
//char symbol = Console.ReadLine()[0];

//DrawSquare(side, symbol);

//static void DrawSquare(int side, char symbol)
//{
//    if (side <= 0)
//    {
//        Console.WriteLine("Довжина сторони має бути більшою за 0.");
//        return;
//    }

//    for (int i = 0; i < side; i++)
//    {
//        for (int j = 0; j < side; j++)
//        {
//            Console.Write(symbol);
//        }
//        Console.WriteLine();
//    }
//}

////mission 2
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Console.Write("Введіть число для перевірки: ");
//int number = int.Parse(Console.ReadLine());

//bool result = IsPalindrome(number);

//Console.WriteLine(result
//    ? $"Число {number} є паліндромом."
//    : $"Число {number} не є паліндромом.");

//static bool IsPalindrome(int number)
//{
//    // Від’ємні числа не вважаємо паліндромами через знак '-'
//    if (number < 0)
//    {
//        return false;
//    }

//    string str = number.ToString();

//    int left = 0;
//    int right = str.Length - 1;

//    while (left < right)
//    {
//        if (str[left] != str[right])
//        {
//            return false;
//        }

//        left++;
//        right--;
//    }

//    return true;
//}

//// mission 3

//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Console.WriteLine(">>> Введіть елементи оригінального масиву (через пробіл):");
//int[] original = ParseArray(Console.ReadLine());

//Console.WriteLine(">>> Введіть елементи масиву для фільтрації (через пробіл):");
//int[] filter = ParseArray(Console.ReadLine());

//int[] result = FilterArray(original, filter);

//Console.WriteLine(">>> Оригінальний масив:");
//PrintArray(original);

//Console.WriteLine(">>> Масив для фільтрації:");
//PrintArray(filter);

//Console.WriteLine(">>> Результат фільтрації:");
//PrintArray(result);

//static int[] ParseArray(string str)
//{
//    string[] items = str.Split(new char[] { ' ', '\t' },
//        StringSplitOptions.RemoveEmptyEntries);

//    int[] array = new int[items.Length];
//    for (int i = 0; i < items.Length; i++)
//    {
//        array[i] = int.Parse(items[i]);
//    }
//    return array;
//}

//static void PrintArray(int[] array)
//{
//    foreach (int item in array)
//    {
//        Console.Write($"{item} ");
//    }
//    Console.WriteLine();
//}

//static int[] FilterArray(int[] original, int[] filter)
//{
//    // спочатку рахуємо, скільки елементів залишиться
//    int count = 0;
//    for (int i = 0; i < original.Length; i++)
//    {
//        bool found = false;
//        for (int j = 0; j < filter.Length; j++)
//        {
//            if (original[i] == filter[j])
//            {
//                found = true;
//                break;
//            }
//        }
//        if (!found) count++;
//    }

//    // формуємо результуючий масив
//    int[] result = new int[count];
//    int k = 0;
//    for (int i = 0; i < original.Length; i++)
//    {
//        bool found = false;
//        for (int j = 0; j < filter.Length; j++)
//        {
//            if (original[i] == filter[j])
//            {
//                found = true;
//                break;
//            }
//        }
//        if (!found)
//        {
//            result[k] = original[i];
//            k++;
//        }
//    }

//    return result;
//}

//// mission 4

//using hw_exception_handling;
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Website site = new Website();
//site.Input();
//Console.WriteLine();
//site.Output();

//Console.WriteLine("\n>>> Демонстрація доступу до полів через методи:");
//Console.WriteLine($"Назва: {site.GetName()}");
//Console.WriteLine($"Шлях: {site.GetPath()}");
//Console.WriteLine($"Опис: {site.GetDescription()}");
//Console.WriteLine($"IP-адреса: {site.GetIp()}");

//// змінюємо одне з полів через сетер
//site.SetName("Нова назва сайту");
//Console.WriteLine($"\nПісля зміни назви через SetName: {site.GetName()}");

//// mission 5

//using hw_exception_handling;
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Journal journal = new Journal();
//journal.Input();
//Console.WriteLine();
//journal.Output();

//Console.WriteLine("\n>>> Демонстрація доступу до полів через методи:");
//Console.WriteLine($"Назва:            {journal.GetName()}");
//Console.WriteLine($"Рік заснування:   {journal.GetYear()}");
//Console.WriteLine($"Опис:             {journal.GetDescription()}");
//Console.WriteLine($"Телефон:          {journal.GetPhone()}");
//Console.WriteLine($"Email:            {journal.GetEmail()}");

//// змінюємо окремі поля через сетери
//journal.SetPhone("+380 44 123 45 67");
//journal.SetEmail("new.email@journal.ua");

//Console.WriteLine("\n>>> Після зміни телефону та email через сетери:");
//journal.Output();

//// альтернативне створення об'єкта через конструктор з параметрами
//Journal journal2 = new Journal(
//    "National Geographic",
//    1888,
//    "Науково-популярний журнал про природу, науку та подорожі",
//    "+1 800 555 1234",
//    "info@natgeo.com");

//Console.WriteLine("\n>>> Другий журнал (створений через конструктор):");
//journal2.Output();

//// mission 6

//using hw_exception_handling;
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Store store = new Store();
//store.Input();
//Console.WriteLine();
//store.Output();

//Console.WriteLine("\n>>> Демонстрація доступу до полів через методи:");
//Console.WriteLine($"Назва:            {store.GetName()}");
//Console.WriteLine($"Адреса:           {store.GetAddress()}");
//Console.WriteLine($"Профіль:          {store.GetProfile()}");
//Console.WriteLine($"Телефон:          {store.GetPhone()}");
//Console.WriteLine($"Email:            {store.GetEmail()}");

//// змінюємо окремі поля через сетери
//store.SetPhone("+380 44 987 65 43");
//store.SetEmail("new.email@store.ua");

//Console.WriteLine("\n>>> Після зміни телефону та email через сетери:");
//store.Output();

//// альтернативне створення об'єкта через конструктор з параметрами
//Store store2 = new Store(
//    "Rozetka",
//    "м. Київ, вул. Хрещатик, 1",
//    "Інтернет-магазин електроніки та побутової техніки",
//    "+380 44 502 3000",
//    "info@rozetka.com.ua");

//Console.WriteLine("\n>>> Другий магазин (створений через конструктор):");
//store2.Output();

// mission 7

// mission complite