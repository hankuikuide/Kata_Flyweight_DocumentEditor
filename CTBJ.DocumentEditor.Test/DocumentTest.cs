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
        private Document document = null;

        [TestInitialize()]
        public void setUp()
        {
            document = new Document();
            document.initialize(maxRows: 3, maxCols: 40);
        }

        [TestMethod]
        public void initializeTest()
        {
            Assert.AreEqual(3, document.MaxRows);
            Assert.AreEqual(40, document.MaxCols);
        }

        [TestMethod]
        public void SetGlyphInPositionTest()
        {

            Mock<Position> mockPosition = new Mock<Position>(1, 1 );
            Mock<Glyph> mockGlyph = new Mock<Glyph>("a");
            mockGlyph.SetupProperty(mg => mg.Color, Color.BLUE);

            document.add(mockPosition.Object, mockGlyph.Object);

            Assert.AreEqual("a", document.getGlyphBy(mockPosition.Object).Alphabet);
            Assert.AreEqual(Color.BLUE, document.getGlyphBy(mockPosition.Object).Color);
        }

        [TestMethod]
        public void SetGlyph_InvalidRowTest()
        {
            string message=string.Empty;

            Mock<Position> mockPosition = new Mock<Position>(4, 1);
            Mock<Glyph> mockGlyph = new Mock<Glyph>("a");
            mockGlyph.SetupProperty(mg => mg.Color, Color.BLUE);

            try
            {
                document.add(mockPosition.Object, mockGlyph.Object);
            }
            catch (ValidationException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Row", message);
        }

        [TestMethod]
        public void SetGlyph_InvalidColTest()
        {
            string message = string.Empty;

            Mock<Position> mockPosition = new Mock<Position>(2, 50);
            Mock<Glyph> mockGlyph = new Mock<Glyph>("a");
            mockGlyph.SetupProperty(mg => mg.Color, Color.BLUE);

            try
            {
                document.add(mockPosition.Object, mockGlyph.Object);
            }
            catch (ValidationException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Col", message);

        }

        [TestMethod]
        public void SetGlyph_InvalidAlphabet()
        {
            string message = string.Empty;

            Mock<Position> mockPosition = new Mock<Position>(2, 2);
            Mock<Glyph> mockGlyph = new Mock<Glyph>("?");
            mockGlyph.SetupProperty(mg => mg.Color, Color.BLUE);

            try
            {
                document.add(mockPosition.Object, mockGlyph.Object);
            }
            catch (ValidationException ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Alphabet", message);

        }

        [TestCleanup()]
        public void tearDown()
        {
            document = null;
        }
    }
}
