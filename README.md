# AE3OP Task 06 - Polymorphism

[Polymorphism tutorial](https://github.com/icebeam7/oop-tutorials/blob/main/03-polymorphism/README.md): extends the dungeon minigame from Task 05.

## Steps done

| Step | Feature | Where |
|---|---|---|
| 01 | `abstract` class and `abstract PerformAttack`: `Character` can no longer be instantiated, every subclass must implement the attack | `Classes/Character.cs`, commented example in `Program.cs` |
| 02 | `sealed override` method: `Warrior.PerformAttack` cannot be overridden by `EliteWarrior` (double attack and shield); the player is asked whether they are an Elite Warrior | `Classes/Warrior.cs`, `Classes/EliteWarrior.cs`, `Program.cs` |
| 03 | `sealed` class: nothing can derive from `Mage` (the `ArchMage` test class was removed after seeing the compiler error) | `Classes/Mage.cs` |
| 04 | `protected` member: `BattleCry` is set in each subclass constructor and shown when attacking; it is not accessible from `Program.cs` | all classes |
| 05 | `is` (with pattern variable) and `as` type checks on the player | `Program.cs` |

## Compiler errors demonstrated during the steps

```
new Character("Hero", 100, 10)          -> Cannot create an instance of the abstract type or interface 'Character'
override PerformAttack in EliteWarrior  -> cannot override inherited member 'Warrior.PerformAttack(Character)' because it is sealed
class ArchMage : Mage                   -> cannot derive from sealed type 'Mage'
player.BattleCry = "..." in Program.cs  -> 'Character.BattleCry' is inaccessible due to its protection level
```

## Run

```bash
dotnet run --project InheritanceMinigame
```
