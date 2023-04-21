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
            string[] names = new string[number];

                for (int i = 0; i < number; i++)
                
                    {
                        Console.WriteLine("Enter a name for an enemy " + i + ": ");
                            names[i] = Console.ReadLine();
                    
                    }

                foreach (string n in names)
                {
                    Console.WriteLine(n);
                } 

            }
     }    
}

