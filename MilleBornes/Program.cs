// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;
//using System.Security;
using System.Linq;
using System.Collections.Generic;
using System;

Card[] deck =
{
    new Card("Accident"),
    new Card("Accident"),
    new Card("Accident"),
    new Card("Out of Gas"),
    new Card("Out of Gas"),
    new Card("Out of Gas"),
    new Card("Flat Tire"),
    new Card("Flat Tire"),
    new Card("Flat Tire"),
    new Card("Speed Limit"),
    new Card("Speed Limit"),
    new Card("Speed Limit"),
    new Card("Speed Limit"),
    new Card("Stop"),
    new Card("Stop"),
    new Card("Stop"),
    new Card("Stop"),
    new Card("Stop"),
    new Card("Repairs"),
    new Card("Repairs"),
    new Card("Repairs"),
    new Card("Repairs"),
    new Card("Repairs"),
    new Card("Repairs"),
    new Card("Gasoline"),
    new Card("Gasoline"),
    new Card("Gasoline"),
    new Card("Gasoline"),
    new Card("Gasoline"),
    new Card("Gasoline"),
    new Card("Spare Tire"),
    new Card("Spare Tire"),
    new Card("Spare Tire"),
    new Card("Spare Tire"),
    new Card("Spare Tire"),
    new Card("Spare Tire"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("Go"),
    new Card("End Speed Limit"),
    new Card("End Speed Limit"),
    new Card("End Speed Limit"),
    new Card("End Speed Limit"),
    new Card("End Speed Limit"),
    new Card("End Speed Limit"),
    new Card("Driving Ace"),
    new Card("Extra Tank"),
    new Card("Ambulance"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 25"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 50"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 75"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 100"),
    new Card("Distance 200"),
    new Card("Distance 200"),
    new Card("Distance 200"),
    new Card("Distance 200"),

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
        Console.WriteLine($"{index} - {deck[index].Name}");
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

public class Card(string name)
{
    public string Name { get; set; } = name;
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