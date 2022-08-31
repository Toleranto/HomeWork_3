internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 19
        // Напишите программу, которая принимает на вход пятизначное число
        // и проверяет, является ли оно палиндромом.
        // Console.Clear();
        // Console.WriteLine("Введите 5-ти значное число и вы узнаете являеться ли оно палиндромом: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // string fiveNum = Convert.ToString(num);
        // if (fiveNum[0] == fiveNum[4] && fiveNum[1] == fiveNum[3])
        // {
        //     Console.WriteLine($"Число {num} является палиндромом!!!");
        // }
        // else 
        // {
        //  Console.WriteLine($"Число {num} не является палиндромом!!!");
        // }
        //
        Console.Clear();
        Console.WriteLine("Введите 5-ти значное число и вы узнаете являеться ли оно палиндромом: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int znak1 = num / 10000, znak2 = num / 1000 % 10,
            znak4 = num % 100 / 10, znak5 = num % 10;
        if (znak1 == znak5 && znak2 == znak4)
        {
            Console.WriteLine($"Число {num}-палиндром.");
        }
        else Console.WriteLine($"Число {num} не является палиндром.");
    }
}