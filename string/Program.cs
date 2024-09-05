using System;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Назовите имя");
string Name;
Name = Console.ReadLine();

Console.WriteLine("Назовите ваш возраст");
int Age;
Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("назовите ваш знак Зодиака");
string Zodiac;
Zodiac = Console.ReadLine();

Console.WriteLine("Назовите место вашей работы");
string Work;
Work = Console.ReadLine();

Console.WriteLine($"Ваше имя {Name}, вам {Age}, ваш знак зодиака {Zodiac},а Ваше место работы {Work}");

