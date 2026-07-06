using PickRandomCards;

class Program
{

    static void Main(string[] args)
    {
        Console.Write("Escolha o número de cartas para pegar: ");
        string line = Console.ReadLine();

        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Numero invalido!");

        }
    }
}