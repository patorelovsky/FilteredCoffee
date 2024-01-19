namespace FilteredCoffee;

public class Coffee
{
    // Unique identifier for each coffee brewing record
    public int Id { get; set; }
    // Name or brand of the coffee
    public string CoffeeName { get; set; }
    // Indicates the roast level of the coffee
    public string? RoastLevel { get; set; }
    // The region or country where the coffee beans are sourced
    public string? Origin { get; set; }
    // Describes the taste characteristics of the coffee
    public string? FlavorProfile { get; set; }
    // The cost of the filtered coffee
    public decimal? Price { get; set; }
    // Current available quantity in stock
    public int? StockQuantity { get; set; }
}
