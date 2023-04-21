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
            Foe[] array_inimigos = new Foe[num_inimigos];

            for (int i=0; i < array_inimigos.Length; i++)
            {
                Console.Write("Give a name to the enemy please: ");
                string nome_inimigo = Console.ReadLine();
                Foe inimigo = new Foe(nome_inimigo);
                array_inimigos[i] = inimigo;

            }
            Console.WriteLine(" ");
            for(int j=0; j < array_inimigos.Length; j++)
            {
                Console.WriteLine($"Enemy name: {array_inimigos[j].GetName()}");

            }
            
            array_inimigos[0].PickUpPower(PowerUp.shield, 55f);
            Console.WriteLine(array_inimigos[0].GetShield());

            array_inimigos[array_inimigos.Length-1].TakeDamage(5f);
            Console.WriteLine(array_inimigos[array_inimigos.Length-1].GetHealth());

            Console.WriteLine("Obrigado por ter usado este programa!");
        }
    }
}

