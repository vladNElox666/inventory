using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public class Game
    {
        public Enemy[] Enemies;
        public Player Player;
        public int a;


        public Game()
        {


            Player = new Player("hero", 0, 0, 100);
           
            
            
            AwaitPlayerAction();
        }

        public void AwaitPlayerAction()
        {
            
            {
                
                string action  = string.Empty;
                while (action != "exit")
                {
                    Console.WriteLine("What to do?");
                    action = Console.ReadLine();
                    DoPlayerAction(action);
                }
            }
        }
        
        public void DoPlayerAction(string action)
        {
            switch (action)
            {
                case "move":
                    string gh = Console.ReadLine();
                    Console.WriteLine(gh);
                    Player.Move(gh);
                    break;
            }
        }
    }
}
