List<int> numbers = new(){11,22,13,45,16,70,8};

List<int> result = numbers.FindAll(IsEvenNum);
foreach(int num in result)
{
    Console.WriteLine(num);
}
static bool IsEvenNum(int num)
{
    return num % 2 == 0;
}