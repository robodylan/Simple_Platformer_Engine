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

        public static void Move(Object sender, KeyEventArgs e)
        {
                switch (e.Code)
                {
                    case Keyboard.Key.W: y--; if(!isColliding()){ y++; } break;
                    case Keyboard.Key.S: if (!isColliding()) { y++; } else { /*y--;*/ } break;
                    case Keyboard.Key.A: if (!isColliding()) { x--; } else { /*x++;*/ }break;
                    case Keyboard.Key.D: if (!isColliding()) { x++; } else { /*x--;*/ }break;
                }
        }
        public static bool isColliding()
        {
            bool f = false;
            foreach(Block c in Game.blocks){
                if (x > c.X && x < (c.X + 64) || y > c.Y && y < (c.Y + 64))
                {
                    f = true;
                }
            }
            return f;
        }
    }
}
