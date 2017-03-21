using System;

namespace codewars4winner
{
    class Program
    {
        public class Fighter
        {
            public string Name;
            public int Health, DamagePerAttack;
            public Fighter(string name, int health, int damagePerAttack)
            {
                this.Name = name;
                this.Health = health;
                this.DamagePerAttack = damagePerAttack;
            }
        }
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            // Your code goes here. Have fun!
            double n = Math.Ceiling((float)fighter1.Health / fighter2.DamagePerAttack);
            double m = Math.Ceiling((float)fighter2.Health / fighter1.DamagePerAttack);
            if (fighter1.Name == firstAttacker && m <= n || (fighter2.Name == firstAttacker && m <= n - 1))
            {
                return fighter1.Name;
            }
            return fighter2.Name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}