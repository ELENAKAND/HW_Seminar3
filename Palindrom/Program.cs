/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
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
                if (result > 9999 && result < 100000)
                    break;
                else
                {
                    Console.Clear();
                    Console.WriteLine(errorMessage);
                }
               
            }
            
        }
    return result;    
}
void Palindrom(int number)
    {
    /*
    if (number/10000 == number%10000 && (number/1000)%10 == (number/10)%10) 
     так не сработало
    */
    int firstNumber = number/10000; //первая цифра
    int lastNumber = number%10;     //последняя цифра 
    int secondNumber = (number/1000)-(firstNumber*10); //вторая цифра
    int secondLastNumber = ((number%100)-lastNumber)/10; // предпоследняя цифра 

    if (firstNumber == lastNumber && secondNumber == secondLastNumber)
        Console.WriteLine($"Число {number} является палиндромом");
    else
        Console.WriteLine($"Число {number} не является палиндромом");
    }   
int number = GetNumber("Введите пятизначное число");
Palindrom(number);

