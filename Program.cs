using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Напишіть ім'я героя");
        string name = Console.ReadLine();
        Console.WriteLine("Виберіть зброю(1-Меч, 2-Лук, 3-Посох) для вашого юніта");
        string weapon = Console.ReadLine();
        int.TryParse(weapon,out int weapons);
        int[] power = {30, 15, 20};
        int bosshp = 100;
        if (weapons >= 1 && weapons <= power.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                while (bosshp > 0)
                {
                    Console.WriteLine($"### {name} зносить {power[weapons - 1]} урона боссу");
                    bosshp -= power[weapons - 1];
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ви перемогли босса");
            }
            else
            {
                Console.WriteLine("Некоректний вибір зброї!");
            }
  }
}
