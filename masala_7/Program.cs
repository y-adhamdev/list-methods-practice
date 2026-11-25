
List<string> names = new(){"Ali", "Muhammad", "Vali", "Malika", "Anvar"};
List<string>? result = names.FindAll(IsLong);
foreach(string name in result)
{
    System.Console.WriteLine(name);
}

static bool IsLong(string name)
{
    return name.Length > 4;
}