using Animals;

var cat = new Cat();
Console.WriteLine("Введите имя кота");
cat.Name = Console.ReadLine();
cat.SayHelloToCat();
cat.Feed(FoodType.CatFood, 25);

var pig = new Pig();
Console.WriteLine("Введите возраст свиньи");
pig.Age = Convert.ToInt32(Console.ReadLine());
pig.Feed(5);


public enum FoodType
{
    PigFood,
    CatFood,
    Other
}