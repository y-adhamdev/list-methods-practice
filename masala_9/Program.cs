List<decimal> prices = new()
{
    50m, 100m, 250m, 500m, 700m, 450m
};

List<decimal> result = prices.FindAll(IsExpensive);
foreach(decimal price in result)
{
    System.Console.WriteLine(price);
}

static bool IsExpensive(decimal price)
{
    return price >= 100m &&  price <= 500m;
}
