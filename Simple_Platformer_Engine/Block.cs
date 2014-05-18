using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Platformer_Engine
{
    class Block
    {
        public int X;
        public int Y;
        public int ID;
        public Block(int x,int y, int ID)
        {
            this.X = x;
            this.Y = y;
        }

        public int top(){
            return this.Y - 1;
        }
        public int bottom()
        {
            return this.Y + 65;
        }
        public int left()
        {
            return this.X - 1;
        }
        public int right()
        {
            return this.X + 65;
        }
    }
}
