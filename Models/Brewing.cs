namespace FilteredCoffee;

public class Brewing
{
    // Unique identifier for each coffee brewing record
    public int Id { get; set; }
    // Id of the related coffee
    public int CoffeeId { get; set; }
    // The quantity of coffee used for brewing, measured in grams
    public int CoffeeAmountGrams { get; set; }
    // The type or brand of the coffee grinder used
    public string GrinderUsed { get; set; }
    // The grind level of the coffee beans, measured in clicks on the grinder
    public int GrindLevelInClicks { get; set; }
    // The temperature of the water used in brewing
    public int WaterTemperature { get; set; }
    // Recommended brewing time in minutes
    public int BrewingTime { get; set; }
}
