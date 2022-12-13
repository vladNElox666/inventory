using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public class Enemy
    {
        private string name;
        private int health = 100;
        private int x = 50;
        private int y = 25;
        public string Cordinates => $"[{x},{y}]";

        public Enemy (string name, int x, int y, int health)
        {

            this.name = name;
            this.x = x;
            this.y = y;
            this.health = 100;
            Console.WriteLine($"Object{this.name} was created at {this.Cordinates}");
        }
    }
}
