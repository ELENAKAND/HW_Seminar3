/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = ("Введите корректное число");

        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(errorMessage);
                }
                else
                    break;
               
            }
            
        }
    return result;    
}
void Pow3(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
}
int number = GetNumber("Введите целое положительное число от 1");
Console.WriteLine("");// Отделить ввод числа от ответа 
Pow3(number);

