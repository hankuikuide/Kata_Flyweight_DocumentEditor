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

        public Response add(Position position, Glyph glyph)
        {
            Response response = 0;

            if (position.X > 0 && position.X < this.rows)
            {
                if (position.Y > 0 && position.Y < this.Cols)
                {
                    context.Add(position, glyph);

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
