//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int NatNum(int Num){
    if (Num == 1) return 1;
    Console.Write($"{Num}, ");
    return NatNum(Num-1);
}
Console.WriteLine("Введите число:");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{NatNum(Num)}");