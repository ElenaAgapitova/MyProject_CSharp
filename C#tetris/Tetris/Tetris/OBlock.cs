using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class OBlock : Block
    {
        // уникальный блок, т.к. занимает одни и те же позиции в каждом состоянии вращения (квадрат из 4х плиток)
        // ■■
        // ■■
        // нет необходимости копировать и вставлять одни и те же позиции вращения 4 раза, код будет работать прекрасно,
        // если мы предоставим одно состояние вращения

        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] {new(0,0), new(0, 1), new(1, 0), new(1,1)}
        };

        public override int id => 4;
        protected override Position StartOffset => new Position(0,4);
        protected override Position[][] Tiles => tiles;


    }
}
