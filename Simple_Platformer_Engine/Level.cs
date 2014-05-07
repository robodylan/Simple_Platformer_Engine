using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Simple_Platformer_Engine
{
    class Level
    {
        public static Bitmap levelImage;
        public static void Load(int levelID)
        {
            Player.x = 70;
            Player.y = 64;
            levelImage = new Bitmap("Content/Level0/blocks.bmp");
            for (int x = 0; x < levelImage.Width; x++)
            {
                for (int y = 0; y < levelImage.Height; y++)
                {
                    Color c = levelImage.GetPixel(x, y);
                    if (c.B < 100)
                    {
                        Game.blocks.Add(new Block(x * 64, y * 64));
                    }
                }
            }
        }
    }
}
