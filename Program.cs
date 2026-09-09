public class Hero
{
    public string Name;
    public int Health;
    public int BaseAttack;
    
    public void PrintStatus()
    {
        Console.WriteLine($" [СТАТУС) {Name} | HP: {Health} | Сила: {BaseAttack}");
        
    }
    public void Hit(Hero target)
    {
        target. Health -= BaseAttack;
        Console.WriteLine($"{Name} атакує {target.Name} i завдає {BaseAttack} шкоди!");
        }
}

class Program
{
    static void Main()
    {
        Hero hero = new Hero {Name = "Саня", Health = 200, BaseAttack =52};
        Hero monster = new Hero { Name = "OpK", Health = 300, BaseAttack = 67 };
        
        hero.PrintStatus();
         monster. PrintStatus();
        
        while (hero.Health > 0 && monster.Health > 0)
        {
            hero.Hit(monster);
            monster.Hit(hero);
        }
        hero.PrintStatus();
         monster. PrintStatus();
    }
}
