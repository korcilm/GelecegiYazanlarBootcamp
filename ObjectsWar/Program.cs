using System;

namespace ObjectsWar
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Army myArmy = new Army();
            myArmy.Name = "My Army";
            myArmy.Soldiers=myArmy.ProduceSoldiers(3,12);  
            Army enemy = new Army();
            enemy.Name = "Enemy";
            enemy.Soldiers=enemy.ProduceSoldiers(2,10);
            Game game = new Game();
            var winner=game.StartTheWar(myArmy, enemy);
            Console.WriteLine($"{winner.Name} won the war");
            Console.WriteLine($"{winner.Soldiers.Count} soldier is alive");
        }
    }
}
