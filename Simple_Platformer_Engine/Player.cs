using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import SFML
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
namespace Simple_Platformer_Engine
{
    class Player
    {
        public static int x;
        public static int y;
        public static int Speed = 64;
        public static void Move(Object sender, KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.W: if (!isColliding(1)) { y = y - Speed;} break;
                case Keyboard.Key.S: if (!isColliding(2)) { y = y + Speed;} break;
                case Keyboard.Key.A: if (!isColliding(3)) { x = x - Speed;} break;
                case Keyboard.Key.D: if (!isColliding(4)) { x = x + Speed;} break;
            }
        }
        public static bool isColliding(int I)
        {
            bool Colliding = false;
            Block p = new Block(Player.x,Player.y, 10);
            foreach (Block c in Game.blocks)
            {
                switch(I)
                {
                    case 1: if (y - 64 == c.Y && x == c.X) { Colliding = true; } break;
                    case 2: if (y + 64 == c.Y && x == c.X) { Colliding = true; } break;
                    case 3: if (x - 64 == c.X && y == c.Y) { Colliding = true; } break;
                    case 4: if (x + 64 == c.X && y == c.Y) { Colliding = true; } break;
                }
            }
             if(Colliding) Console.WriteLine("Collision");
                return Colliding;
    }

    }
}
