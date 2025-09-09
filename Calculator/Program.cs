Console.WriteLine("Нажмите q, если хотите выполнить операцию");
string ret = Convert.ToString(Console.ReadLine());
while (ret == "q")
{
    Console.WriteLine("Добро пожаловать в калькулятор \t Введите первое число :");
    double a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Какую операцию ходите выполнить ? \n Сложение ---> s \n Вычитание ---> d \n Деление ---> f \n Умножение ---> a");
    string str = Console.ReadLine();
    switch (str)
    {
        case "s":
            Console.WriteLine($"Выполняймая операция сложение двух чисел {a} и {b}: \t {a} + {b} = {a + b}");
            break;
        case "d":
            Console.WriteLine($"Выполняймая операция вычетание двух чисел {a} и {b}: \t {a} - {b} = {a - b}");
            break;
        case "f":
            Console.WriteLine($"Выполняймая операция деление двух чисел {a} и {b}: \t {a} / {b} = {a / b}");
            break;
        case "a":
            Console.WriteLine($"Выполняймая операция умножение двух чисел {a} и {b}: \t {a} * {b} = {a * b}");
            break;

    }

    Console.WriteLine("Нажмите q, если хотите выполнить операцию");
    ret = Convert.ToString(Console.ReadLine());
};
Console.WriteLine("Приложение закрыта");

Console.WriteLine();
