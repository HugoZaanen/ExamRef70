using System;

namespace Objective_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int i = 42;
            //double d = i;

            //Animal animal = new Animal();
            //Dog dog = (Dog)animal;

            //double x = 1234.7;
            //int m = (int)x;

            //Console.WriteLine(m);
            #endregion

            int x = 5;
            double d = x;

            decimal d1 = 5.5M;
            int x1 = (int)d1;

            Money money = new Money(5.0M);
            decimal d2 = money;
            //int x2 = money;
        }

        class Animal {
            public string Name { get; set; }
        }

        class Dog : Animal
        {
            public void Bark()
            {

            }
        }

        class Money
        {
            public Money(decimal amount)
            {
                this.Amount = amount;
            }

            public decimal Amount { get; set; }

            public static implicit operator decimal(Money money)
            {
                return money.Amount;
            }

            public static explicit operator int(Money money)
            {
                return (int)money.Amount;
            }
        }
    }
}
