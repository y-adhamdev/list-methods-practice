List<string> names = new(){"Ali", "Vali", "Muhammad", "Malika", "Aziz"};

string? result = names.Find(IsLongest);
System.Console.WriteLine($"Natija: {result ?? "Topilmadi."}");
static bool IsLongest(string name)
{
    return name.Length > 5;
}