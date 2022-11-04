using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameState
    {
        // Класс состояния игры, который будет обрабатывать взаимодействия между частями написанными ранее:
        // игоровая сетка, классы блоков и очередь блока, позиция

        // Свойство с резервным полем для текущего блока

        private Block currentBlock;
        public Block CurrentBlock
        {
            get => currentBlock;
            private set
            {
                currentBlock = value;
                currentBlock.Reset(); // когда обновляем блок вызывается метод сброса, чтобы установить правильную 
                // позицию и ротацию блока
            }
        }

        // Добавим свойства для игровой сетки, очереди блоков и логическое значение игры (GameOver)

        public GameGrid GameGrid { get; }
        public BlockQueue BlockQueue { get; }
        public bool GameOver { get; private set; }

        // В конструкторе инициализируем игровую сетку с 22 строками и 10 столбцами, также инициализируем очередь блоков 
        // и используем для получения случайного блока для текущего свойства блока

        public GameState()
        {
            GameGrid = new GameGrid(22, 10);
            BlockQueue = new BlockQueue();
            CurrentBlock = BlockQueue.GetAndUpdate();
        }

        // Важный метод, который проверяет находится ли текущий блок в допустимой позиции или нет (перебирает позиции  
        // плитки текущего блока: не выходит ли какая-либо из них из сетки или перекрывает другую плитку - возвращаем ложь)

        private bool BlockFits()
        {
            foreach(Position p in CurrentBlock.TilePositions())
            {
                if (!GameGrid.IsEmpty(p.Row, p.Column))
                    return false;
            }
            return true;
        }
         
        // Метод для поворота текущего блока по часовой стрелке, но только если это возможно, делаем из того места, где это возможно

        public void RotateBlockCW()
        {
            CurrentBlock.RotateCW();
            if (!BlockFits())
                CurrentBlock.RotateCCW(); // метод вращает блок, но если он в недопустимой позиции, то поворачиваем его обратно
        }

        public void RotateBlockCCW()
        {
            CurrentBlock.RotateCCW();
            if (!BlockFits())
                CurrentBlock.RotateCW();

        }
    }
}
