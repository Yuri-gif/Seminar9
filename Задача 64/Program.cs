Console.WriteLine("Введите натуральное число больше 1:");
int N = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int N )
{
    if (N < 0) Console.Write($"{N} не натуральное число");
    if (N == 0) return;
    Console.Write("{0,4}", N);
    NumberCounter (N - 1);
}

NumberCounter(N);