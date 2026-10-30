using System;

namespace InheritanceMinigame.Classes
{
    // sealed: no class can inherit from Mage
    // public class ArchMage : Mage { ... }  ->  error: cannot derive from sealed type 'Mage'
    public sealed class Mage : Character
    {
        public int Mana { get; private set; } = 50;

        public Mage(string name) : base(name, 80, 25)
        {
            BattleCry = "By the arcane flame!";
        }

        public override void PerformAttack(Character target)
        {
            if (Mana >= 20)
            {
                Mana -= 20;
                Console.WriteLine($"{Name} shouts '{BattleCry}' and casts a massive Fireball at {target.Name}! (Mana left: {Mana})");
                target.TakeDamage(AttackPower);
            }
            else
            {
                Console.WriteLine($"{Name} is out of mana! They whack {target.Name} weakly with a staff.");
                target.TakeDamage(5);
            }
        }
    }
}
