using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.DocumentEditor.Bussiness
{
    public class Document
    {
        private int rows;

        public int Rows
        {
            get { return rows; }
            private set { rows = value; }
        }

        private int cols;

        public int Cols
        {
            get { return cols; }
            private set { cols = value; }
        }

        Dictionary<Position, Glyph> context = new Dictionary<Position, Glyph>();

        public void initialize(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }

        public void add(Position position, Glyph glyph)
        {
            context.Add(position, glyph);
        }

        public Glyph getGlyphBy(Position position)
        {
            return context[position];
        }
    }

    public class Position
    {
        private int x;

        private int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
