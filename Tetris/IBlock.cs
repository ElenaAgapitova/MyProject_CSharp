using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class IBlock : Block
    {
        // блок представляет собой прямую из 4х плиток ■■■■
        private readonly Position[][] tiles = new Position[][] // 4 состояния вращения для блока
        {
            new Position[]  {new(1,0), new(1,1), new(1,2), new(1,3)},
            new Position[] {new(0,2), new(1,2), new(2,2),new(3,2)},
            new Position[] {new(2,0), new(2,1), new(2,2),new(2,3)},
            new Position[] {new(0,1), new(1,1), new(2,1),new(3,1)}
        };

        // идентификатор должен быть 1, начальное смещение должно быть Start = (-1,3), 
        // это заставит блок появиться в середине верхней строки
        public override int id => 1;                              
        protected override Position StartOffset => new Position(-1, 3);
        protected override Position[][] Tiles => tiles;  // для плиток мы вернем массив плиток выше
        
        // это все, что нужно, для функциональности блока все находится в базовом классе Block (вращение и смещение)
        
        

    }
}
