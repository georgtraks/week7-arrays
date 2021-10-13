using System;

namespace week7arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal valida, mida ta hommikusöögiks sööb

            string[] food = { "võileib juustuga", "jogurt", "banaan", "peekon", "muna"};


            food[3] = "vinku";

            food[2] = "keefir";

            Console.WriteLine("menüüs:");

            for(int i = 0; i < food.Length; i++)
            {
                
                Console.WriteLine(food[i]);
            }

            Console.WriteLine("vali toit (sisesta number1 - 5:");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"oled valinud {food[userchoice]}");




        }
    }
}
