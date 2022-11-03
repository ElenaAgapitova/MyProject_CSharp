using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block // это абстрактный класс для каждого блока, в нем нам нужно создать двумерный массив сетки для каждого блока
    {
        protected abstract Position[][] Tiles { get; } // массив содержит состояние плитки блока в 4х состояниях вращения
        protected abstract Position StarOffset { get; } // начальное смещение, которое решает, где блок появляется в сетке
        public abstract int id { get; } // идентификатор, чтобы различать блоки (всего 7 блоков)

        private int rotationState; // будем хранить текущее состояние вращения 
        private Position offSet; // и текущее состояние смещения

        // В конструкторе устанавливаем смещение равное начальному смещению

        public Block()
        {
            offSet = new Position(StarOffset.Row, StarOffset.Column);
        }

        // Метод, который возвращает позиции сетки, занимаемые блоком с учетом текущего поворота и смещения

        public IEnumerable<Position> TilePositions() // перебирает позиции плитки в текущем состоянии поворота и добавляет смещение строки и столбца
        {
            foreach (Position p in TilePositions())
            {
                yield return new Position(p.Row + offSet.Row, p.Column + offSet.Column);
            }

        }

        // Метод, который поворачивает блок на 90 градусов по часовой стрелке:


    }
}
