var intList = new List<int>();
Console.WriteLine("Введите список чисел");
for (int i = 0; i < 5; i++ )
{
    intList.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.WriteLine("Сортировка листа");
intList.Sort();
foreach (int i in intList)
{
    Console.WriteLine(i);
}

Console.WriteLine("Вывод четных чисел");
var even = intList.Where(i => i % 2 == 0).ToList();
foreach (int i in even)
{
    Console.WriteLine(i);
}

Console.WriteLine("Вывод чисел больше 42");
var moreThan42 = intList.Where(i => i > 42).ToList();
foreach (int i in moreThan42)
{
    Console.WriteLine(i);
}

Console.WriteLine("Вывод суммы всех чисел");
Console.WriteLine(intList.Sum());
Console.WriteLine();


var stringList = new List<string>();
Console.WriteLine("Введите строки");
for (int i = 0; i < 5; i++)
{
    stringList.Add(Console.ReadLine());
}

Console.WriteLine("Вывод строк без пробелов");
var noSpace = stringList.Where(x => !x.Contains(" "));
foreach (var i in noSpace)
{
    Console.WriteLine(i);
}

Console.WriteLine("Вывод строки с заглавными буквами");
var uppercase = stringList.Where(x => x != x.ToLower());
foreach (var i in uppercase)
{
    Console.WriteLine(i);
}

Console.WriteLine("Вывод строки содержащей заданную подстроку\n Введите подстроку");
var word = Console.ReadLine();
var search = stringList.Where(x => x.Contains(word));
foreach (var i in search)
{
    Console.WriteLine(i);
}

Console.WriteLine("Вывод ответа на вопрос есть ли в любой строке число");
Console.WriteLine(stringList.Any(x => x.Any(y => Char.IsDigit(y))));
