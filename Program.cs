/*

// 1. Напишите программу, которая на вход принимает число и выдает  его квардрат (число умноженное на само себя)
Console.Write("Imput integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Result is " + result);


// 2. Напишите программу, которая  на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (num1 == square)
  Console.Write("First number is square of second number");
else
  Console.Write("First number is not square of second number");


// 3. Напишите программу, которая будет выдавать названиее дня недели по заданному номеру

Console.Write("Imput number of the day: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7){
    Console.WriteLine("Incorrect number");
}
else{
    if (day == 1){
    Console.Write("Monday");
    }
    if (day == 2){
    Console.Write("Tuesday");
    }
    if (day == 3){
    Console.Write("Wednesday");
    }
    if (day == 4){
    Console.Write("Thursday");
    }
    if (day == 5){
    Console.Write("Friday");
    }
    if (day == 6){
    Console.Write("Saturday");
    }
    if (day == 7){
    Console.Write("Sunday");
    }
}


// 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -1 * num +1;
while(current < num){
    Console.Write(current + " ");
    current++;
}


// 5. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

Console .WriteLine("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num % 10;
Console.WriteLine(a);




// Домашнее задание по 1 семминару


// 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2){
  Console.Write("First number is equal to the second number");
}
else{
  if (num1 > num2){
  Console.Write("First number is greater than the second number");
  }
  if (num1 < num2){
  Console.Write("First number is not greater than the second number");
  }
}


// 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int numMax = num1;
if (num2 > numMax) numMax = num2;
if (num3 > numMax) numMax = num3;
Console.Write("Maximum number is " + numMax);


// 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным

Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.Write("Number is even");
else
Console.Write("Number is odd");

*/

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= num)
{
  {
  if (current % 2 == 0)
    Console.Write(current + " ");
  current++;
  }
}
