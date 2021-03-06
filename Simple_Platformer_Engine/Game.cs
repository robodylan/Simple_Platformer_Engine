﻿using System;
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
    class Game
    {
        public static Vector2f offset = new Vector2f(0,0);
        public static RenderWindow window;
        public static Sprite blockSprite;
        public static Sprite playerSprite;
        public static List<Block> blocks;
        public static void Start()
        {
            window = new RenderWindow(new VideoMode(1000, 800), "I Am Goc");
            blocks = new List<Block>();
            blockSprite = new Sprite(new Texture("Content/Block.png"),new IntRect(0,0,64,64));
            playerSprite = new Sprite(new Texture("Content/Player.png"), new IntRect(0, 0, 64, 64));
            window.Closed += onWindowClose;
            window.KeyReleased += Player.Move;
            window.SetFramerateLimit(25);
            Level.Load(0);
            while(window.IsOpen())
            {
                window.Clear();
                window.DispatchEvents();
                Update();
                window.Display();
                Level.DrawBackground();
            }
        }
        public static void Update()
        {
            foreach(Block c in blocks)
            {
                blockSprite.Position = new Vector2f(c.X - offset.X, c.Y - offset.Y);
                window.Draw(blockSprite);
            }
            playerSprite.Position = new Vector2f(Player.x,Player.y);
            window.Draw(playerSprite);
        }

        public static void onWindowClose(Object sender, EventArgs e)
        {
            window.Close();
        }
    }
}
