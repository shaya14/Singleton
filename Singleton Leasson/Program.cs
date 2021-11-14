using System;

namespace Singleton_Leasson
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallet = 50000;
            while (true)
            {


                Console.WriteLine("Welcome to your bank account , You want to deposit or withdraw?");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "deposit":
                        Console.WriteLine("How much you want to deposit?");
                        float deposit = float.Parse(Console.ReadLine());
                        deposit += Singleton.Instance.Deposit(deposit);
                        break;
                    case "withdraw":
                        Console.WriteLine("How much you want to withdraw?");
                        float wittdraw = float.Parse(Console.ReadLine());
                        wittdraw -= Singleton.Instance.WithDraw(wittdraw);
                        break;

                    default:
                        Console.WriteLine("Invaild input, please enter corrent answer");
                        break;
                }
            }


        }
    }
}
