List<int> numbers = new(){1,2,3,4,5,6};

int result = numbers.Find(IsNegative);
Console.WriteLine(result);

static bool IsNegative(int num)
{
    return num < 0;
}