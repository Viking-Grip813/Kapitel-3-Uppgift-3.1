using System;
namespace Uppgift3_1
{ class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int år = int.Parse(Console.ReadLine());
            if (år < 16 )
            {
                Console.WriteLine("Du är för ung för att delta");
            }
            else if (år == 16)
            {
                Console.WriteLine("Du är gammal nog att delta");
            }
            else if (år == 17)
            {
                Console.WriteLine("Du är gammal nog att delta");
            }
            else if (år == 18)
            {
                Console.WriteLine("Du är gammal nog att delta");
            }
            else if (år == 19)
            {
                Console.WriteLine("Du är gammal nog att delta");
            }
            else if (år > 19)
            {
                Console.WriteLine("Du är för gammal för att delta");
            }
            
        }
    }
}
