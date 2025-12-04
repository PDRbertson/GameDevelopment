// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;
//using System.Security;
using System.Linq;
using System.Collections.Generic;
using System;

Card[] deck =
{
    new Card("Accident",Catagory.Hazard,1),
    new Card("Accident",Catagory.Hazard,1),
    new Card("Accident",Catagory.Hazard,1),
    new Card("Out of Gas",Catagory.Hazard,2),
    new Card("Out of Gas",Catagory.Hazard,2),
    new Card("Out of Gas",Catagory.Hazard,2),
    new Card("Flat Tire",Catagory.Hazard,3),
    new Card("Flat Tire",Catagory.Hazard,3),
    new Card("Flat Tire",Catagory.Hazard,3),
    new Card("Speed Limit",Catagory.Limit,4),
    new Card("Speed Limit",Catagory.Limit,4),
    new Card("Speed Limit",Catagory.Limit,4),
    new Card("Speed Limit",Catagory.Limit,4),
    new Card("Stop",Catagory.Stop,5),
    new Card("Stop",Catagory.Stop,5),
    new Card("Stop",Catagory.Stop,5),
    new Card("Stop",Catagory.Stop,5),
    new Card("Stop",Catagory.Stop,5),
    new Card("Repairs",Catagory.Fix,6),
    new Card("Repairs",Catagory.Fix,6),
    new Card("Repairs",Catagory.Fix,6),
    new Card("Repairs",Catagory.Fix,6),
    new Card("Repairs",Catagory.Fix,6),
    new Card("Repairs",Catagory.Fix,6),
    new Card("Gasoline",Catagory.Fix,7),
    new Card("Gasoline",Catagory.Fix,7),
    new Card("Gasoline",Catagory.Fix,7),
    new Card("Gasoline",Catagory.Fix,7),
    new Card("Gasoline",Catagory.Fix,7),
    new Card("Gasoline",Catagory.Fix,7),
    new Card("Spare Tire",Catagory.Fix,8),
    new Card("Spare Tire",Catagory.Fix,8),
    new Card("Spare Tire",Catagory.Fix,8),
    new Card("Spare Tire",Catagory.Fix,8),
    new Card("Spare Tire",Catagory.Fix,8),
    new Card("Spare Tire",Catagory.Fix,8),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("Go",Catagory.Go,9),
    new Card("End Speed Limit",Catagory.EndLimit,10),
    new Card("End Speed Limit",Catagory.EndLimit,10),
    new Card("End Speed Limit",Catagory.EndLimit,10),
    new Card("End Speed Limit",Catagory.EndLimit,10),
    new Card("End Speed Limit",Catagory.EndLimit,10),
    new Card("End Speed Limit",Catagory.EndLimit,10),
    new Card("Driving Ace",Catagory.Immunity,11),
    new Card("Extra Tank",Catagory.Immunity,12),
    new Card("Ambulance",Catagory.Immunity,13),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 25",Catagory.Distance,25),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 50",Catagory.Distance,50),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 75",Catagory.Distance,75),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 100",Catagory.Distance,100),
    new Card("Distance 200",Catagory.Distance,200),
    new Card("Distance 200",Catagory.Distance,200),
    new Card("Distance 200",Catagory.Distance,200),
    new Card("Distance 200",Catagory.Distance,200),

};
Console.WriteLine("Hello, World!");
Player playerA = new("Peter");
Player playerB = new("Tim");
Player[] players=[playerA,playerB]; 
int[]? shuffledDeck;
int topCard = deck.Length-1;

shuffledDeck = [.. Enumerable.Range(0, deck.Length)];
Console.WriteLine($"{shuffledDeck.Length} First {shuffledDeck[0]} Last {shuffledDeck[shuffledDeck.Length - 1]}");
var rng = new Random();
rng.Shuffle(shuffledDeck);
//dealing
for (int i = 0; i < 6; i++)
{
    foreach (Player p in players)
    {
        p.DrawCard(shuffledDeck[topCard--]);
    }
}
foreach (Player p in players)
{
    Console.WriteLine($"Player: {p.Name}");
    foreach (int index in p.Hand)
    {
        string catagoryName;
        switch (deck[index].Catagory)
        {
            case Catagory.Hazard:
            catagoryName="Hazard";
            break;
            case Catagory.Limit:
            catagoryName="Limit";
            break;
            case Catagory.EndLimit:
            catagoryName="End Limit";
            break;
            case Catagory.Distance:
            catagoryName=$"Distance {deck[index].Value}";
            break;
            default:
            catagoryName="Unknown";
            break;
        }
        Console.WriteLine($"{index} - {deck[index].Name} [{catagoryName}]");
    }
}


public class Player(string name)
{
    public string Name { get; set; } = name;
    public List<int> Hand { get; set; } = [];
    public PlayerTableau TheirTableau { get; set; } = new();

    public void DrawCard(int deckIndex)
    {
        this.Hand.Add(deckIndex);
    }
}
public class PlayerTableau
{
    public List<int> LightArea { get; set; } = [];
    public List<int> LimitArea { get; set; } = [];
    public List<int> DistanceArea { get; set; } = [];
    public List<int> SpecialArea { get; set; } = [];
}

public class Card(string name,Catagory catagory,int value)
{
    public string Name { get; set; } = name;
    public Catagory Catagory { get; set; } = catagory;
    public int Value { get; set; } = value;
}
public enum Catagory
{
    Hazard,
    Limit,
    Stop,
    Fix,
    Go,
    EndLimit,
    Immunity,
    Distance,
}


static class RandomExtensions
{
    public static void Shuffle<T> (this Random rng, T[] array)
    {
        int n = array.Length;
        while (n > 1) 
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}