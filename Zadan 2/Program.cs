//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
bool CheckNumMBiggerThanNumN(int NumM, int NumN){
    bool CheckResult = false;
    if (NumM>NumN)
    {
        CheckResult = true;
        return CheckResult;
    }
    return CheckResult;
}
int SumNatNumMtoN(int FirstNum, int SecondNum){
    if (FirstNum == SecondNum){
    return SecondNum;
    }
    else{
        return FirstNum + SumNatNumMtoN(FirstNum-1, SecondNum);
    }
}
Console.WriteLine("Введите число M:");
int NumM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int NumN = Convert.ToInt32(Console.ReadLine());
if(NumM == NumN){
    Console.WriteLine($"Результат: 0");
    goto end;
}
bool MBiggerThanN = CheckNumMBiggerThanNumN(NumM, NumN);
if (MBiggerThanN==true){
    Console.WriteLine($"Результат: {SumNatNumMtoN(NumM, NumN)}");
}
else{
    Console.WriteLine($"Результат: {SumNatNumMtoN(NumN, NumM)}");
}
end:;