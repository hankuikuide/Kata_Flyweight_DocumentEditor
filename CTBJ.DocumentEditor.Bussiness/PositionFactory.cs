using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace CTBJ.DocumentEditor.Bussiness
{
    public class PositionFactory
    {
        List<Position> positions = new List<Position>();

        private static PositionFactory factory = new PositionFactory();

        private PositionFactory()
        {  }

        public static PositionFactory getInstance()
        {
            return factory;
        }

        public Position getPosition(int x,int y)
        {

            foreach (var item in positions)
            {
                if (item.X==x && item.Y==y)
                {
                    return item;                    
                }
            }

            Position position = new Position(x, y);
            positions.Add(position);

            return position;
        }

    }
}
