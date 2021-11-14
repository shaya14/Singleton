using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Leasson
{
    class Singleton
    {
        public static Singleton Instance;
        float bankMoney;

        private Singleton()
        {
            Instance = this;
            bankMoney = 0;
        }
        public float Deposit(float amount)
        {
            if(amount > 0)
            {
                Console.WriteLine($"You deposit {amount} to your account!");
                bankMoney += amount;
                return amount;
            }
            else
            {
                Console.WriteLine("Invaild Amount!");
                return 0;
            }
        }
        public float WithDraw(float amount)
        {
            if(bankMoney - amount > 0)
            {
                Console.WriteLine($"You withdraw {amount} from your account , You have {bankMoney} now");
                bankMoney -= amount;
                return amount;
            }
            else
                Console.WriteLine("Invaild Amount!");
            return 0;
        }
    }
}
