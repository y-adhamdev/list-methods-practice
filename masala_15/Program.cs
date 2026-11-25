List<decimal> prices = new(){ 50m, 120m, 250m, 80m, 500m, 1000m, 300m };

decimal result = prices.Find(IsExpensive);
List<decimal> results = prices.FindAll(IsAvailable); 
bool res = prices.Exists(IsThousand);
bool res2 = prices.Exists(IsThere);

System.Console.WriteLine($"200 dan yuqori mahsulot: {result}");
System.Console.Write("100 va 500 oralig'idagi:");
foreach(decimal num in results)
{
    Console.Write(num + " ");
}
System.Console.WriteLine($"\n1000 ga teng bo'lgan product bormi: {res}");
System.Console.WriteLine($"1500 dan yuqori bo'lgan product bormi: {res2}");

static bool IsThere(decimal price)
{
    return price > 1500;
}
    

static bool IsThousand(decimal price)
{
    return price == 1000m;
}

static bool IsAvailable(decimal price)
{
    return price >= 100m && price <= 500m;
}

static bool IsExpensive(decimal price)
{
    return price > 200m;
}


