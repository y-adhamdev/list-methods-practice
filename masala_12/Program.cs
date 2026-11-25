List<int> ages = new()
{
    12, 15, 16, 17, 18
};

bool result = ages.Exists(IsGreaterEighteen);
System.Console.WriteLine(result);

static bool IsGreaterEighteen(int age)
{
    return age > 18;
}