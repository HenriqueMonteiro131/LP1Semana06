using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Hi there traveler! Please tell me"+ 
            "the number of enemies between 1 and 9 for this simulation:");
            int num_inimigos = int.Parse(Console.ReadLine());
            string[] array_inimigos = new string[num_inimigos];

            for (int i=0; i < array_inimigos.Length; i++)
            {
                Console.Write("Give a name to the enemy: ");
                string nome_inimigo = Console.ReadLine();
                array_inimigos[i] = nome_inimigo;
                Foe inimigo = new Foe(nome_inimigo);

            }
            Console.WriteLine(" ");
            for(int j=0; j < array_inimigos.Length; j++)
            {
                Console.WriteLine($"Enemy name: {array_inimigos[j]}");
            }

        }
    }
}

