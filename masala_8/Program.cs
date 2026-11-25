List<int> numbers = new(){-10, 5, -3, 0, 8, -15, 20};
List<int> result = numbers.FindAll(IsNegative);

foreach(int num in result)
{
    System.Console.WriteLine(num);
}

static bool IsNegative(int num)
{
    return num < 0;
}