using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block // это абстрактный класс для каждого блока, в нем нам нужно создать двумерный массив сетки для каждого блока
    {
        protected abstract Position[][] Tiles { get; } // массив содержит состояние плитки блока в 4х состояниях вращения
        protected abstract Position StartOffset { get; } // начальное смещение, которое решает, где блок появляется в сетке
        public abstract int id { get; } // идентификатор, чтобы различать блоки (всего 7 блоков)

        private int rotationState; // будем хранить текущее состояние вращения 
        private Position offset; // и текущее состояние смещения

        // В конструкторе устанавливаем смещение равное начальному смещению

        public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        // Метод, который возвращает позиции сетки, занимаемые блоком с учетом текущего поворота и смещения

        public IEnumerable<Position> TilePositions() // перебирает позиции плитки в текущем состоянии поворота и добавляет смещение строки и столбца
        {
            foreach (Position p in TilePositions())
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }

        }

        // Метод, который поворачивает блок на 90 градусов по часовой стрелке:
        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        // Метод поворачивает блок против часовой стрелки
        public void RotateCCW()
        {
            if(rotationState == 0)
                rotationState = Tiles.Length - 1;
            else
                rotationState--;
        }

        // Метод, который перемещает блок с заданным количеством строк и столбцов:
        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        // Метод, который сбрасывает вращение и смещение - метод сброса
        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}
