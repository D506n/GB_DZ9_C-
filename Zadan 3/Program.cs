double AccFunc(double n, double m){
    if (n == 0){
        return m + 1;
    }
    if (n != 0 && m == 0){ 
        return AccFunc(n - 1, 1);
    }
    if (n > 0 && m > 0){ 
    return AccFunc(n - 1, AccFunc(n, m - 1));
    }
    return AccFunc(n,m);
}
Console.WriteLine("Введите число n: ");
double n = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Введите число m: ");
double m = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine($"A({n}, {m}) = {AccFunc(n, m)}");