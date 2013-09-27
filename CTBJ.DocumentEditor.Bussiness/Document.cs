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

        public Response add(Position position, Glyph glyph)
        {
            Response response = 0;

            if (position.X > 0 && position.X < this.maxRows)
            {
                if (position.Y > 0 && position.Y < this.MaxCols)
                {
                    //todo the Regex needs to be updated
                    Regex r = new Regex("^[a-zA-Z,. $]");
                    if (r.IsMatch(glyph.Alphabet))
                    {
                        context.Add(position, glyph);
                    }
                    else
                    {
                        response = Response.INVALIDALPHABET;
                    }
                }
                else
                {
                    Console.WriteLine("列行不合法:{0}", position.Y);
                    response = Response.INVALIDCOL;
                }
            }
            else
            {
                Console.WriteLine("行不合法:{0}", position.X);
                response = Response.INVALIDROW;
            }

            return response;
        }

        public Glyph getGlyphBy(Position position)
        {
            return context[position];
        }
    }
}
