using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CTBJ.DocumentEditor.Bussiness
{
    public class GlyphFactory
    {

        private Hashtable glyphs = new Hashtable();

        private static GlyphFactory factory = new GlyphFactory();

        private GlyphFactory()
        {  }

        public static GlyphFactory getInstance()
        {
            return factory;
        }

        public Glyph getGlyph(string alphabet, Color color)
        {
            //首先在缓存中查找对象
            if (glyphs.ContainsKey(alphabet))
            {
                return (Glyph)glyphs[alphabet];
            }
            //如果缓存未命中则新建对象并加入缓存
            Glyph glyph = new Glyph(alphabet);
            glyph.Color = color;
            glyphs.Add(alphabet,glyph);

            return glyph;
        }
    }
}
