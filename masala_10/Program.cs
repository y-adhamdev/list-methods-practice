List<string> names = new()
{
    "Ali", "Malika", "Anvar", "Aziza", "Vali", "Madina"
};

List<string> result = names.FindAll(EndsWitha);
foreach(string name in result)
{
    System.Console.WriteLine(name);
}

static bool EndsWitha(string name)
{
    return name.EndsWith("a");
}