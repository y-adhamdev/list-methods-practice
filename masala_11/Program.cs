List<int> numbers = new()
{
    5, 10, 15, 20
};

bool result = numbers.Exists(HasZero);
System.Console.WriteLine(result);

static bool HasZero(int num)
{
    return num == 0;
}