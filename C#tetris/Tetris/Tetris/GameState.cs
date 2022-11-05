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
        // плитки текущего блока: не выходит ли какая-либо из них из сетки или перекрывает другую плитку)

        private bool BlockFits()
        {
            foreach(Position p in CurrentBlock.TilePositions())
            {
                if (!GameGrid.IsEmpty(p.Row, p.Column)) // все позиции, кроме этих: r >= 0 && r < Rows && c >= 0 && c < Columns&& grid[r,c] == 0;
                    return false;
            }
            return true;
        }
         
        // Метод для поворота текущего блока по часовой стрелке, но только если это возможно, делаем из того места, где это возможно

        public void RotateBlockCW()
        {
            CurrentBlock.RotateCW();
            if (!BlockFits()) // если (блок не подходит)
                CurrentBlock.RotateCCW(); // метод вращает блок, но если он в недопустимой позиции и 
                                          //  и повернуть нельзя, то поворачиваем его обратно, 
                                          // в методе BlockFits перебираются позиции для каждой плитки блока
        }

        public void RotateBlockCCW() // против часовой стрелки
        {
            CurrentBlock.RotateCCW();
            if (!BlockFits())
                CurrentBlock.RotateCW();

        }

        // Методы перемещения блока вправо и влево по такому же принципу, если позиция недопустима
        // (выходит за игровую сетку или перекрывают плитку другого блока, заходит на другой блок),
        // то перемещаем блок обратно

        public void MoveBlockLeft() 
        {
            CurrentBlock.Move(0, -1);
            if (!BlockFits())
                CurrentBlock.Move(0, 1);
        }

        public void MoveBlockRight()
        {
            CurrentBlock.Move(0, 1);
            if (!BlockFits())
                CurrentBlock.Move(0, -1);
        }

        // Метод проверка закончилась ли игра

        private bool IsGameOver() 
        {
            return !(GameGrid.IsRowEmpty(0) && GameGrid.IsRowEmpty(1)); // если какая-либо из верхних скрытых строк
                                                                        // не пуста, то игра проиграна (игровая сетка
                                                                        // 20х10, но мы создали еще 2 скрытых строки 
                                                                        // для зарождения блока, сетка 22х10
        }

        // Метод вызывается, если блок не может быть перемещен вниз
        

        private void PlaceBlock()
        {
            foreach(Position p in CurrentBlock.TilePositions()) 
            {
                GameGrid[p.Row, p.Column] = CurrentBlock.id;
            }
              
            GameGrid.ClearFullRows();

            if (IsGameOver())
                GameOver = true;
            else
                CurrentBlock = BlockQueue.GetAndUpdate();
        }

        // Метод перемещения блока вниз, работает также, как и блоки с вращением, но также вызываем метод PlaceBlock
        // на случай, если блок не может быть перемещен вниз

        public void MoveBlockDown() 
        {
            CurrentBlock.Move(1, 0);
            if (!BlockFits())
            {
                CurrentBlock.Move(-1, 0);
                PlaceBlock();
            }
        }
    }
}
