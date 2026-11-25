List<string> names = new()
{
    "Ali", "Vali", "Malik", "Anvar"
};

bool result = names.Exists(HasName);
System.Console.WriteLine(result);

static bool HasName(string name)
{
    return name == "Malika";
}
