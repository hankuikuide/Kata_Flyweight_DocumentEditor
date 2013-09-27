using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CTBJ.DocumentEditor.Bussiness
{
    public class Document
    {
        private int maxRows;

        public int MaxRows
        {
            get { return maxRows; }
            private set { maxRows = value; }
        }

        private int maxCols;

        public int MaxCols
        {
            get { return maxCols; }
            private set { maxCols = value; }
        }

        Dictionary<Position, Glyph> context = new Dictionary<Position, Glyph>();

        public void initialize(int rows, int cols)
        {
            this.maxRows = rows;
            this.maxCols = cols;
        }

        public void add(Position position, Glyph glyph)
        {

            if (position.X < 0 || position.X > this.maxRows)
            {
                throw new MyException("Invalid Row");
            }

            if (position.Y < 0 || position.Y > this.MaxCols)
            {
                throw new MyException("Invalid Col");               
            }

            //todo the Regex needs to be updated
            Regex r = new Regex("^[a-zA-Z,. $]");
            if (!r.IsMatch(glyph.Alphabet))
            {
                throw new MyException("Invalid Alphabet");               

            }

            context.Add(position, glyph);

        }

        public Glyph getGlyphBy(Position position)
        {
            return context[position];
        }
    }
}
