//Задание 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
//Решаем с помощью "/" и "%", со строками не работаем
// Console.WriteLine("----------Задание №1----------");
// Console.WriteLine("Напишите трехзначное число от 100 до 999");
// int num = int.Parse(Console.ReadLine()!);
// int result = 0;
// if (num < 1000 && num > 99)
// {
//     result = num / 10 % 10;
//     Console.WriteLine($"Вторая цифра числа {num} - это {result}");
// }
// else
// {
//     Console.WriteLine("Не выполнено условие: трехзначное число от 100 до 999");
// }

//Задание 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)
Console.WriteLine("----------Задание №2----------");
Console.WriteLine("Напишите число до 100 000");
int num2 = int.Parse(Console.ReadLine()!);
int result2 = num2 / 10;
int result3 = num2 / 100;
int result4 = num2 / 1000;

if (num2 < 100 ){
    Console.WriteLine("Третьей цифры нет");
}
else {
    if (num2 > 99 && num2 < 1000){
        Console.WriteLine($"Третья цифра числа {num2} будет {num2%10}");
    }
    else{
        if((result2 > 99 && result2 < 1000)){
            Console.WriteLine($"Третья цифра числа {num2} будет {result2%10}");
        }
        else {
            if (result3 > 99 && result3 < 1000){
                Console.WriteLine($"Третья цифра числа {num2} будет {result3%10}");
            }
            else{
                if (result4 > 99 && result4 < 1000){
                    Console.WriteLine($"Третья цифра числа {num2} будет {result4%10}");
                }
            }
    }
        
    }
}