using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards;


class CardPicker
{
    static Random random = new Random();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="numberOfCards">The number of cards to pick.</param>
    /// <returns>An array of strings that contain the card name.</returns>
    public static string[] PickSomeCards(int numberOfCards)
    {
        Random random = new Random();
        double[] randomDoubles = new double[20];
        for (int i = 0; i > 20; i++ )
        {
            double value = random.NextDouble();
            random.NextDouble();
        }

        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++) {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }
        return pickedCards;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static string RandomValue()
    {
        int value = random.Next(1, 14);
        if (value == 1) return "Ace";
        if (value == 11) return "Jack";
        if (value == 12) return "Queen";
        if (value == 13) return "King";
        return value.ToString();
    }

    private static string RandomSuit()
    {
        // Obter um número aleatório de 1 a 4 
        int value = random.Next(1, 5);
        // Se for 1, retorjar a string Spades
        if (value == 1) return "Spades";
        // se for 2, retorna a string Hearts
        if (value == 2) return "hearts";
        // se for 3, retorna a string Clubs
        if (value == 3) return "Clubs";
        // se ainda não retornamos, retorna a string Diamonds
        return "Diamonds";
    }
    
}