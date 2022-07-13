// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
    {
    Console.WriteLine("Неверное число. Нужно ввести трёхзначное");
    }
else
    {
        number = (number - ((number/100)*100))/10;
        Console.WriteLine("Вторая цифра введенного числа: " + number);
    }


*/

//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;

if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
else
    
    {       
    while (temp > 999)
        {
        temp = temp / 10;
        number = temp % 10;
        }
    }

Console.WriteLine("Третья цифра числа: " + number);
*/

// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Укажите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
    {
        Console.WriteLine("Бог создал в неделе ровно семь дней. Их не может быть больше или меньше");
    }
if (number < 6)
    {
        Console.WriteLine("Будний день. Бегом работать!");
    }
if (number > 5)
    {
        Console.WriteLine("Выходной. Можешь отдыхать ^^");
    }
*/