using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public class Player:GameObject
    {
        private string name;
        private int health = 100;
        private int x = 50;
        private int y = 25;
        private int xp = 0;
        public string Cordinates => $"[{x},{y}]";
        public int Xp => xp;

        public int Health
        {
            get => health;
            set => health = value;
        }
        public bool IsAlive => health > 0;

        public Player(string name, int x, int y,int health)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.health = 100;
            Console.WriteLine($"Object{this.name} was created at {this.Cordinates}");
        }

    }
}
