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
            //首先在缓存中查找对象
            foreach (var item in positions)
            {
                if (item.X==x && item.Y==y)
                {
                    //在缓存中命中对象后还原对象的外部属性
                    return item;                    
                }
            }
            //如果缓存未命中则新建对象并加入缓存
            Position position = new Position(x, y);
            positions.Add(position);

            return position;
        }

    }
}
