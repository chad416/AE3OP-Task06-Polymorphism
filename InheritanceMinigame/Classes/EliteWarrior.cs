namespace InheritanceMinigame.Classes
{
    public class EliteWarrior : Warrior
    {
        public EliteWarrior(string name) : base($"Elite Member {name}")
        {
            AttackPower *= 2;
            ShieldBlock *= 2;
        }

        // This would be invalid, because Warrior.PerformAttack is sealed:
        // public override void PerformAttack(Character target)
        // {
        //     Console.WriteLine("This warrior attacks in a different way!");
        // }
        //
        // Compiler error:
        // 'EliteWarrior.PerformAttack(Character)': cannot override inherited member
        // 'Warrior.PerformAttack(Character)' because it is sealed.
    }
}
