using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTBJ.DocumentEditor.Bussiness;

namespace CTBJ.DocumentEditor.Test
{
    [TestClass]
    public class DocumentTest
    {
        [TestMethod]
        public void initializeTest()
        {
            Document document = new Document();

            document.initialize(3,40);

            Assert.AreEqual(3, document.Rows);
            Assert.AreEqual(40, document.Cols);
        }

        [TestMethod]
        public void SetGlyphTest()
        {
            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(1, 1);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);
            string msg=document.add(position,glyph);

            Assert.AreEqual("leagal", msg);
            Assert.AreEqual("a", document.getGlyphBy(position).Alphabet);
            Assert.AreEqual(Color.BLUE, document.getGlyphBy(position).Color);
        }

        [TestMethod]
        public void SetGlyph_IlleagalRowTest()
        {
            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(4, 1);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);
            string msg=document.add(position, glyph);

            Assert.AreEqual("illeagal row", msg);
        }

        [TestMethod]
        public void SetGlyph_IlleagalColTest()
        {
            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(2, 50);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);
            string msg = document.add(position, glyph);

            Assert.AreEqual("illeagal col", msg);
        }

    }
}
