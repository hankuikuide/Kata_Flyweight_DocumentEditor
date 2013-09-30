using CTBJ.DocumentEditor.Bussiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;

namespace CTBJ.DocumentEditor.Test
{
    
    /// <summary>
    ///这是 GlyphFactoryTest 的测试类，旨在
    ///包含所有 GlyphFactoryTest 单元测试
    ///</summary>
    [TestClass()]
    public class GlyphFactoryTest
    {

        /// <summary>
        ///GlyphFactory 构造函数 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CTBJ.DocumentEditor.Bussiness.dll")]
        public void GlyphFactoryConstructorTest()
        {
            GlyphFactory_Accessor target = new GlyphFactory_Accessor();

            Assert.IsNotNull(target);
        }

        /// <summary>
        ///getGlyph 的测试
        ///</summary>
        [TestMethod()]
        public void getGlyphTest()
        {
            GlyphFactory_Accessor target = new GlyphFactory_Accessor(); 
            string alphabet ="a"; 
            Color color = Color.BLACK;

            //Mock<Glyph> expected = new Mock<Glyph>("a");
            //expected.SetupProperty(mg => mg.Color, Color.BLACK);

            Glyph actual = target.getGlyph(alphabet, color);

            Assert.IsNotNull(actual);




        }

        /// <summary>
        ///getInstance 的测试
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {
            GlyphFactory actual = GlyphFactory.getInstance();

            Assert.IsNotNull(actual);
        }
    }
}
