using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTBJ.DocumentEditor.Bussiness
{
    public class GlyphFactory
    {
        List<Glyph> glyphs = new List<Glyph>();

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
            foreach (var item in glyphs)
            {
                if (item.Alphabet == alphabet)
                {
                    //在缓存中命中对象后还原对象的外部属性
                    item.Color = color;
                    return item;                    
                }
            }
            //如果缓存未命中则新建对象并加入缓存
            Glyph glyph = new Glyph(alphabet);
            glyph.Color = color;
            glyphs.Add(glyph);

            return glyph;
        }
    }
}
