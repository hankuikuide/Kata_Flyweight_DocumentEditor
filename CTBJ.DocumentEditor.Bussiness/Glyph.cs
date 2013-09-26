using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.DocumentEditor.Bussiness
{
    public enum Color
    {
        REd=1,
        ORANGE,
        YELLOW,
        GREEN,
        BLUE,
        INDIGO,
        VIOLET
    }
    public class Glyph
    {
        private string alphabet;

        public string Alphabet
        {
            get { return alphabet; }
            private set { alphabet = value; }
        }

        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Glyph(string alphabet)
        {
            this.alphabet = alphabet;
        }
    }
}
