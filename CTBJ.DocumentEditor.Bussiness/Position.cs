using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.DocumentEditor.Bussiness
{
    public class Position
    {
        private int x;

        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
