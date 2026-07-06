using System;

namespace Casino
{
    public class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Escreve meu nome e quanto dinheiro tenho no console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " +
                    "I don't have enough cash to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Recebe algum dinheiro, adicionando-o à minha carteira
        /// (ou escrevendo uma mensagem no console se a quantia é inválida)
        /// </summary>
        /// <param name="amount">Quantia de dinheiro a entregar.</param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}