List<decimal> prices = new(){12m, 25m, 120m, 95m};

decimal result = prices.Find(IsGreater);
Console.WriteLine($"Natija: {result}");

static bool IsGreater(decimal price)
{
    return price > 100m;
}

