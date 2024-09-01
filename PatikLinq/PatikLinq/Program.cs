Random rnd = new Random();
List<int> randomNumbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    int random = rnd.Next(-1000, 1001);
    randomNumbers.Add(random);
}

var evenNumbers = randomNumbers.Where(n => n % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------");

var oddNumbers = randomNumbers.Where(n => n % 2 == 1);

foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------");

var negativeNumbers = randomNumbers.Where(n => n < 0);

foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------");

var positiveNumbers = randomNumbers.Where(n => n > 0);

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------");

var btw = randomNumbers.Where(n => n < 22 && n > -538);

foreach (var number in btw)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------");

var squares = randomNumbers.Select(n => n * n).ToList();

foreach (var number in squares)
{
    Console.WriteLine(number);
}
