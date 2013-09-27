using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTBJ.DocumentEditor.Bussiness;
using Moq;

namespace CTBJ.DocumentEditor.Test
{
    [TestClass]
    public class DocumentTest
    {
     
        [TestMethod]
        public void initializeTest()
        {
            Document document = new Document();

            document.initialize(maxRows: 3, maxCols: 40);

            Assert.AreEqual(3, document.MaxRows);
            Assert.AreEqual(40, document.MaxCols);
        }

        [TestMethod]
        public void SetGlyphInPositionTest()
        {
            Document document = new Document();

            document.initialize(maxRows: 3, maxCols: 40);

            Mock<Position> mockPosition = new Mock<Position>(1, 1 );
            //Position position = PositionFactory.getInstance().getPosition(1, 1);

            Mock<Glyph> mockGlyph = new Mock<Glyph>("a");
            mockGlyph.Setup(mg => mg.Color = Color.BLUE).Returns(Color.BLUE);
            //Glyph glyph = GlyphFactory.getInstance().getGlyph("a", Color.BLUE);

            document.add(mockPosition.Object, mockGlyph.Object);

            Assert.AreEqual("a", document.getGlyphBy(mockPosition.Object).Alphabet);
            Assert.AreEqual(Color.BLUE, document.getGlyphBy(mockPosition.Object).Color);
        }

        [TestMethod]
        public void SetGlyph_InvalidRowTest()
        {
            string message=string.Empty;
            Document document = new Document();
            document.initialize(maxRows: 3, maxCols: 40);

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
            document.initialize(maxCols: 3, maxRows: 40);

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

        [TestMethod]
        public void addStringTest()
        {
            string message = string.Empty;

            Document document = new Document();
            document.initialize(3, 40);

            Position position= null;
            Glyph glyph = null;

            try
            {
                position = PositionFactory.getInstance().getPosition(0, 1);
                glyph = GlyphFactory.getInstance().getGlyph("D", Color.BLACK);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 2);
                glyph = GlyphFactory.getInstance().getGlyph("o", Color.BLACK);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 3);
                glyph = GlyphFactory.getInstance().getGlyph(" ", Color.WHITE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 4);
                glyph = GlyphFactory.getInstance().getGlyph("n", Color.BLACK);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 5);
                glyph = GlyphFactory.getInstance().getGlyph("o", Color.BLACK);
                document.add(position, glyph);
                position = PositionFactory.getInstance().getPosition(0, 6);
                glyph = GlyphFactory.getInstance().getGlyph("t", Color.BLACK);
                document.add(position, glyph);
                position = PositionFactory.getInstance().getPosition(0, 7);
                glyph = GlyphFactory.getInstance().getGlyph(" ", Color.WHITE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 8);
                glyph = GlyphFactory.getInstance().getGlyph("d", Color.RED);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 9);
                glyph = GlyphFactory.getInstance().getGlyph("w", Color.RED);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 10);
                glyph = GlyphFactory.getInstance().getGlyph("e", Color.RED);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 11);
                glyph = GlyphFactory.getInstance().getGlyph("l", Color.RED);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 12);
                glyph = GlyphFactory.getInstance().getGlyph("l", Color.RED);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 13);
                glyph = GlyphFactory.getInstance().getGlyph(" ", Color.BLUE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 14);
                glyph = GlyphFactory.getInstance().getGlyph("i", Color.BLACK);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 15);
                glyph = GlyphFactory.getInstance().getGlyph("n", Color.BLACK);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 16);
                glyph = GlyphFactory.getInstance().getGlyph(" ", Color.WHITE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 17);
                glyph = GlyphFactory.getInstance().getGlyph("p", Color.ORANGE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 18);
                glyph = GlyphFactory.getInstance().getGlyph("a", Color.ORANGE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 19);
                glyph = GlyphFactory.getInstance().getGlyph("s", Color.ORANGE);
                document.add(position, glyph);

                position = PositionFactory.getInstance().getPosition(0, 20);
                glyph = GlyphFactory.getInstance().getGlyph("t", Color.ORANGE);
                document.add(position, glyph);

            }
            catch (MyException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("", message);

        }
    }
}
