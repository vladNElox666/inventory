using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame;

namespace ff
{

    public class GameObject
    {
        private int x;
        private int y;
        public int X => x;
        public int Y => y;
        public string cords => $"{x},{y}";

        public void Move(string dirextion)
        {
            Console.WriteLine("sdf");
            switch (dirextion)
            {
                case "forward":
                    x++;
                    break;
                case "backward":
                    x--;
                    break;
                case "up":
                    y++;
                    break;
                case "down":
                    y--;
                    break;
            }
            Console.WriteLine(cords);            
        }
    }
}