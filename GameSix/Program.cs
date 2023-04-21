using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Hi there traveler! Please tell me"+ 
            "the number of enemies between 1 and 9 for this simulation:");
            int number = int.Parse(Console.ReadLine());
            Foe[] EnemyArray = new Foe[number];

                for (int i = 0; i < number; i++)
                
                    {
                        Console.WriteLine("Enter a name for an enemy " + i + ": ");
                            EnemyArray[i] = Console.ReadLine();

                                Foe inimigo = new Foe(nome);
                                inimigos[i] = inimigo
                    
                    }

                Console.WriteLine("Enemies Names: ")
                foreach (string n in names)
                {
                    Console.WriteLine(n);
                } 

            }
     }    
}

