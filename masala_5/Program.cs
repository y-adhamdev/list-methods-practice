using System;
using System.Text;

List<string> names = new(){"ali", "vali", "Aziz", "Husan", "Xasan"};

string? result = names.Find(IsUpperCase);
Console.WriteLine(result ?? "Topilmadi.");

static bool IsUpperCase(string name)
{
    return name.StartsWith("A");
}