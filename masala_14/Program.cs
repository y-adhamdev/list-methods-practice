List<int> scores = new()
{
    45, 78, 90, 32, 65, 88, 50
};

int result = scores.Find(Check);
List<int> results = scores.FindAll(Check);
bool natija = scores.Exists(HasBall);

System.Console.WriteLine(result);

foreach(int num in results)
{
    System.Console.Write(num + " ");
}


System.Console.WriteLine($"\n{natija} ");


static bool HasBall(int num)
{
    return num == 100;
}
static bool Check(int num)
{
    return num > 60;
}
