using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTBJ.DocumentEditor.Bussiness;
namespace CTBJ.DocumentEditor.UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty;

            Document document = new Document();
            document.initialize(3, 40);

            Position position = null;
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


                document.print();

                Console.ReadLine();
            }
            catch (MyException ex)
            {
                throw new MyException("something wrong happened");
            }
        }
    }
}
