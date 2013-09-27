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

            Assert.AreEqual(3, document.MaxRows);
            Assert.AreEqual(40, document.MaxCols);
        }

        [TestMethod]
        public void SetGlyphTest()
        {
            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(1, 1);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);
            document.add(position,glyph);

            Assert.AreEqual("a", document.getGlyphBy(position).Alphabet);
            Assert.AreEqual(Color.BLUE, document.getGlyphBy(position).Color);
        }

        [TestMethod]
        public void SetGlyph_InvalidRowTest()
        {
            string message=string.Empty;
            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(4, 1);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);
            try
            {
                 document.add(position, glyph);
            }
            catch (MyException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Row", message);
        }

        [TestMethod]
        public void SetGlyph_InvalidColTest()
        {
            string message = string.Empty;

            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(2, 50);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);
            try
            {
                document.add(position, glyph);
            }
            catch (MyException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Col", message);

        }

        [TestMethod]
        public void SetGlyph_InvalidAlphabet()
        {
            string message = string.Empty;

            Document document = new Document();
            document.initialize(3, 40);

            Position position = PositionFactory.getInstance().getPosition(2, 2);
            Glyph glyph = GlyphFactory.getInstance().getGlyph("?", Color.BLUE);
            try
            {
                document.add(position, glyph);
            }
            catch (MyException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Alphabet", message);

        }
    }
}
