using System;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Назовите имя");
string name;
name = Console.ReadLine();

Console.WriteLine("Назовите ваш возраст");
int age;
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("назовите ваш знак Зодиака");
string zodiac;
zodiac = Console.ReadLine();

Console.WriteLine("Назовите место вашей работы");
string work;
work = Console.ReadLine();

Console.WriteLine($"Ваше имя {name}, вам {age}, ваш знак зодиака {zodiac},а Ваше место работы {work}");

