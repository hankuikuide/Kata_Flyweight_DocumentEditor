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

        public string add(Position position, Glyph glyph)
        {
            string msg = string.Empty;

            if (position.X > 0 && position.X < this.rows)
            {
                if (position.Y > 0 && position.Y < this.Cols)
                {
                    context.Add(position, glyph);
                    msg = "leagal";
                }
                else
                {
                    Console.WriteLine("列行不合法:{0}", position.Y);
                    msg = "illeagal col";
                }
            }
            else
            {
                Console.WriteLine("行不合法:{0}", position.X);
                msg = "illeagal row";
            }

            return msg;
        }

        public Glyph getGlyphBy(Position position)
        {
            return context[position];
        }
    }
}
