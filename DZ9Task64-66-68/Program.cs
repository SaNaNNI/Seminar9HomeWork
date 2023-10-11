// ДЗ Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int start = PutNumber("Enter a number for value N: ");
int stop = 1;
Console.WriteLine(PrintNumbers(start, stop));

int PutNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string PrintNumbers(int start, int stop)
{
    if (start == stop) 
        return Convert.ToString(start);
    return $"{start}, {PrintNumbers(start - 1, stop)}";
}




// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


class Program
{
    static int CalculateSumOfNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            
            int temp = m;
            m = n;
            n = temp;
        }

        int sum = 0;

        for (int i = m; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter the value of M: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Enter the value of N: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = CalculateSumOfNaturalNumbers(m, n);
                Console.WriteLine($"The sum of natural numbers from {m} to {n} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input for N. Please enter an integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for M. Please enter an integer.");
        }
    }
}





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = SetNumber("Enter number M: ");
int n = SetNumber("Enter number N: ");
Console.WriteLine($"A({m}, {n}) = {Ankerman(m, n)}");

int SetNumber(string message)
{
    Console.Write($"{message}");
    string strNum = Console.ReadLine()!;
    int num = 0;
    if (int.TryParse(strNum, out num))
        	if (num >= 0)
                return num;
    Console.WriteLine("Enter a non-negative number!");
    return SetNumber(message);
}

int Ankerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
        return Ankerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Ankerman(m - 1, Ankerman(m, n - 1));
    return Ankerman(m,n);
}

