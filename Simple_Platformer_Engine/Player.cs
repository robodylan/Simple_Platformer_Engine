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
        public static int Speed = 3;
        public static void Move(Object sender, KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.W: y = y - Speed; if (isColliding()) { y = y + Speed; } break;
                case Keyboard.Key.S: y = y + Speed; if (isColliding()) { y = y - Speed; } break;
                case Keyboard.Key.A: x = x - Speed; if (isColliding()) { x = x + Speed; } break;
                case Keyboard.Key.D: x = x + Speed; if (isColliding()) { x = x - Speed; } break;
            }
        }
        public static bool isColliding()
        {
            foreach(Block c in Game.blocks){
                if()
                {

                }
        }
    }
    }
}
