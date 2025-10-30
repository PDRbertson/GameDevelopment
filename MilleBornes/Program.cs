// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security;

Console.WriteLine("Hello, World!");
Player playerA = new()
{
    Name = "Peter"
};
Player playerB = new()
{
    Name = "Tim"
};
public class Player
{
    public string? Name { get; set; }
    public Card[]? HandStack { get; set; }
    public PlayerArea? TheirArea { get; set; }
}
public class PlayerArea
{
    public Card[]? LightStack { get; set; }
    public Card[]? LimitStack { get; set; }
    public Card[]? DistanceStack { get; set; }
    public Card[]? SpecialStack { get; set; }
}

public class Card
{
    public string Name { get; set; }
    Card(string name)
    {
        Name = name;
    }
    
}
